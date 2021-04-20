using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Recipe.Models;
using Recipe.ViewModels;

namespace Recipe.Controllers
{
    [Authorize]
    public class RecipeController : Controller
    {
        private readonly MyContext myContext;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public RecipeController(MyContext myContext,
                                UserManager<User> userManager,
                                SignInManager<User> signInManager)
        {
            this.myContext = myContext;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var currentUserId = userManager.GetUserId(HttpContext.User);
            //recent recipes
            var recentRecipes = new List<RecentRecipes>();
            var recentAddedRecipes = myContext.Recipes.OrderByDescending(x => x.CreatedAt).Take(3).ToList();
            foreach (var recipe in recentAddedRecipes)
            {
                var user = myContext.Userz.FirstOrDefault(x => x.Id == recipe.CreatedBy);
                var isSaved = myContext.Saves.Any(x => x.UserId == currentUserId && x.RecipeId == recipe.RecipeId);
                var recipeToShow = new RecentRecipes()
                {
                    Image = recipe.Image,
                    RecipeId = recipe.RecipeId,
                    Name = recipe.Name,
                    IsSaved = isSaved,
                    CreatedBy = user.Name
                };
                recentRecipes.Add(recipeToShow);
            }
            ViewBag.RecentRecipes = recentRecipes.ToList();
            //main dashboard
            var dashboard = new List<DashboardViewModel>();
            var following = myContext.Followers.Where(x => x.UserId == currentUserId).ToList();
            if (following.Count() != 0)
            {
                foreach (var follower in following)
                {
                    var followerRecipes = myContext.Recipes.Include(x => x.RecipeIngredients).OrderByDescending(x => x.CreatedAt).Where(x => x.CreatedBy == follower.FollowerId || x.CreatedBy == currentUserId).ToList();

                    foreach (var recipe in followerRecipes)
                    {
                        var totalRating = 0;
                        var sumRating = 0;
                        var ratings = myContext.Reviews.Where(x => x.RecipeId == recipe.RecipeId).ToList();
                        foreach (var rating in ratings)
                        {
                            sumRating += rating.Rating;
                            totalRating++;
                        }
                        var isSaved = myContext.Saves.Any(x => x.UserId == currentUserId && x.RecipeId == recipe.RecipeId);
                        var recipeUser = myContext.Userz.FirstOrDefault(x => x.Id == recipe.CreatedBy);
                        var dashboardRecipe = new DashboardViewModel()
                        {
                            Recipe = recipe,
                            IsSaved = isSaved,
                            CreatedBy = recipeUser.Name,
                            Rating = sumRating == 0 ? 0 : System.Math.Round((sumRating / (double)totalRating), 2)
                        };
                        dashboard.Add(dashboardRecipe);
                    }
                }
            }
            else
            {
                var myRecipes = myContext.Recipes.Include(x => x.RecipeIngredients).OrderByDescending(x => x.CreatedAt).Where(x => x.CreatedBy == currentUserId).ToList();
                foreach (var recipe in myRecipes)
                {
                    var isSaved = myContext.Saves.Any(x => x.UserId == currentUserId && x.RecipeId == recipe.RecipeId);
                    var recipeUser = myContext.Userz.FirstOrDefault(x => x.Id == recipe.CreatedBy);
                    var dashboardRecipe = new DashboardViewModel()
                    {
                        Recipe = recipe,
                        IsSaved = isSaved,
                        CreatedBy = recipeUser.Name
                    };
                    dashboard.Add(dashboardRecipe);
                }
            }
            ViewBag.DashboardRecipes = dashboard.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(string recipeTitle, IFormFile recipeImage)
        {
            Recipes newRecipe = new Recipes();
            if (recipeImage != null)
            {
                newRecipe.Image = GetByteArrayFromImage(recipeImage);
                newRecipe.ImageFileName = System.IO.Path.GetFileName(recipeImage.FileName);
                newRecipe.ImageContentType = recipeImage.ContentType;
            }
            var currentUserId = userManager.GetUserId(HttpContext.User);
            newRecipe.Name = recipeTitle;
            newRecipe.CreatedBy = currentUserId;
            newRecipe.Prepare = "";
            newRecipe.Description = "";
            newRecipe.Category = "";
            myContext.Recipes.Add(newRecipe);
            myContext.SaveChanges();
            return RedirectToAction("Update", new { newRecipe.RecipeId });
        }

        [HttpGet]
        [Route("Update/{recipeId}")]
        public IActionResult Update(int recipeId)
        {
            var model = myContext.Recipes.Include(x => x.RecipeIngredients).FirstOrDefault(x => x.RecipeId == recipeId);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update([FromBody] UpdateRecipeViewModel model)
        {
            try
            {
                var recipe = myContext.Recipes.FirstOrDefault(x => x.RecipeId == model.RecipeId);
                recipe.Name = model.Name;
                recipe.Serving = model.Serving;
                recipe.Time = model.Time;
                recipe.Prepare = model.Prepare;
                recipe.Description = model.Description;
                recipe.Category = model.Category;
                recipe.Calories = model.Calories;
                myContext.SaveChanges();
                return Json(new { status = "Success" });
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult AddIngredients([FromBody] AddIngredients model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return Json(new { status = "Error" });
                var newIngredient = new RecipeIngredients()
                {
                    RecipeId = model.RecipeId,
                    Name = model.Name,
                    Quantity = model.Quantity
                };
                myContext.RecipeIngredients.Add(newIngredient);
                myContext.SaveChanges();
                return Json(new { status = "Success" });
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        [HttpPost]
        // [Route("/DeleteIngredient/{ingredientId}")]
        public IActionResult DeleteIngredient(int ingredientId)
        {
            var model = myContext.RecipeIngredients.FirstOrDefault(x => x.RecipeIngredientsId == ingredientId);
            myContext.RecipeIngredients.Remove(model);
            myContext.SaveChanges();
            return Json(new { status = "Success" });
        }

        [HttpGet]
        [Route("Details/{recipeId}")]
        public IActionResult Details(int recipeId)
        {
            var model = new RecipeDetailsViewModel();
            var currentUserId = userManager.GetUserId(HttpContext.User);
            var recipe = myContext.Recipes.Include(x => x.RecipeIngredients).Include(x => x.Reviews).ThenInclude(x => x.User).FirstOrDefault(x => x.RecipeId == recipeId);
            var recipeUser = myContext.Userz.FirstOrDefault(x => x.Id == recipe.CreatedBy);
            var isSaved = myContext.Saves.Any(x => x.UserId == currentUserId && x.RecipeId == recipeId);
            var follows = myContext.Followers.Any(x => x.UserId == currentUserId && x.FollowerId == recipe.CreatedBy);
            var totalRating = 0;
            var sumRating = 0;
            var ratings = myContext.Reviews.Where(x => x.RecipeId == recipeId).ToList();
            foreach (var rating in ratings)
            {
                sumRating += rating.Rating;
                totalRating++;
            }
            model.Recipe = recipe;
            model.CreatedBy = recipeUser.Name;
            model.IsSaved = isSaved;
            model.Follows = follows;
            model.UserId = currentUserId;
            ViewBag.Rating = sumRating == 0 ? 0 : System.Math.Round((sumRating / (double)totalRating), 2);
            return View(model);
        }

        [HttpGet]
        public IActionResult MyRecipes()
        {
            var currentUserId = userManager.GetUserId(HttpContext.User);
            var model = myContext.Recipes.Where(x => x.CreatedBy == currentUserId).ToList();
            return View(model);
        }

        [HttpPost]
        // [Route("Save/{recipeId}")]
        public IActionResult Save(int recipeId)
        {
            var currentUserId = userManager.GetUserId(HttpContext.User);
            var save = myContext.Saves.Where(x => x.UserId == currentUserId).FirstOrDefault(x => x.RecipeId == recipeId);
            if (save != null)
            {
                myContext.Saves.Remove(save);
                myContext.SaveChanges();
            }
            else
            {
                Save newSave = new Save()
                {
                    RecipeId = recipeId,
                    UserId = currentUserId
                };
                myContext.Saves.Add(newSave);
                myContext.SaveChanges();
            }
            return Json(new { status = "Success" });
        }

        [HttpPost]
        public IActionResult Follow(string followerId)
        {
            var currentUserId = userManager.GetUserId(HttpContext.User);
            var follows = myContext.Followers.Where(x => x.UserId == currentUserId).FirstOrDefault(x => x.FollowerId == followerId);
            if (follows != null)
            {
                myContext.Followers.Remove(follows);
                myContext.SaveChanges();
            }
            else
            {
                Follow newFollow = new Follow()
                {
                    UserId = currentUserId,
                    FollowerId = followerId
                };
                myContext.Followers.Add(newFollow);
                myContext.SaveChanges();
            }
            return Json(new { status = "Success" });
        }

        [HttpGet]
        public IActionResult Saved()
        {
            var currentUserId = userManager.GetUserId(HttpContext.User);
            var saves = myContext.Saves.Where(x => x.UserId == currentUserId).OrderByDescending(x => x.SavedAt).ToList();
            var savedRecipes = new List<RecentRecipes>();
            foreach (var saved in saves)
            {
                var recipe = myContext.Recipes.FirstOrDefault(x => x.RecipeId == saved.RecipeId);
                var recipeUser = myContext.Userz.FirstOrDefault(x => x.Id == recipe.CreatedBy);
                var recipeToShow = new RecentRecipes()
                {
                    Image = recipe.Image,
                    RecipeId = recipe.RecipeId,
                    Name = recipe.Name,
                    IsSaved = true,
                    CreatedBy = recipeUser.Name
                };
                savedRecipes.Add(recipeToShow);
            }
            return View(savedRecipes);
        }

        [HttpPost]
        public IActionResult AddReview(string comment, int rating, int recipeId)
        {
            var currentUserId = userManager.GetUserId(HttpContext.User);
            var newReview = new Review()
            {
                Comment = comment,
                Rating = rating,
                RecipeId = recipeId,
                UserId = currentUserId
            };
            myContext.Reviews.Add(newReview);
            myContext.SaveChanges();

            return Json(new { status = "Success" });
        }

        [HttpGet]
        public IActionResult Profile(string userId)
        {
            if (userId == null)
            {
                var currentUserId = userManager.GetUserId(HttpContext.User);
                var dashboard = new List<DashboardViewModel>();
                var followerRecipes = myContext.Recipes.Include(x => x.RecipeIngredients).Where(x => x.CreatedBy == currentUserId).ToList();
                foreach (var recipe in followerRecipes)
                {
                    var totalRating = 0;
                    var sumRating = 0;
                    var ratings = myContext.Reviews.Where(x => x.RecipeId == recipe.RecipeId).ToList();
                    foreach (var rating in ratings)
                    {
                        sumRating += rating.Rating;
                        totalRating++;
                    }
                    var isSaved = myContext.Saves.Any(x => x.UserId == currentUserId && x.RecipeId == recipe.RecipeId);
                    var recipeUser = myContext.Userz.FirstOrDefault(x => x.Id == recipe.CreatedBy);
                    var dashboardRecipe = new DashboardViewModel()
                    {
                        Recipe = recipe,
                        IsSaved = isSaved,
                        CreatedBy = recipeUser.Name,
                        Rating = sumRating == 0 ? 0 : System.Math.Round((sumRating / (double)totalRating), 2)
                    };
                    dashboard.Add(dashboardRecipe);
                }
                ViewBag.UserRecipes = dashboard.ToList();
                var userName = myContext.Userz.FirstOrDefault(x => x.Id == currentUserId);
                ViewBag.Fullname = userName.Name;
                ViewBag.UserId = currentUserId;
                var follows = myContext.Followers.Where(x => x.UserId == currentUserId).Count();
                ViewBag.NumberOfFollowing = follows;
            }
            else
            {
                var currentUserId = userManager.GetUserId(HttpContext.User);
                var dashboard = new List<DashboardViewModel>();
                var followerRecipes = myContext.Recipes.Include(x => x.RecipeIngredients).Where(x => x.CreatedBy == userId).ToList();
                foreach (var recipe in followerRecipes)
                {
                    var totalRating = 0;
                    var sumRating = 0;
                    var ratings = myContext.Reviews.Where(x => x.RecipeId == recipe.RecipeId).ToList();
                    foreach (var rating in ratings)
                    {
                        sumRating += rating.Rating;
                        totalRating++;
                    }
                    var isSaved = myContext.Saves.Any(x => x.UserId == currentUserId && x.RecipeId == recipe.RecipeId);
                    var recipeUser = myContext.Userz.FirstOrDefault(x => x.Id == recipe.CreatedBy);
                    var dashboardRecipe = new DashboardViewModel()
                    {
                        Recipe = recipe,
                        IsSaved = isSaved,
                        CreatedBy = recipeUser.Name,
                        Rating = sumRating == 0 ? 0 : System.Math.Round((sumRating / (double)totalRating), 2)
                    };
                    dashboard.Add(dashboardRecipe);
                }
                ViewBag.UserRecipes = dashboard.ToList();
                var userName = myContext.Userz.FirstOrDefault(x => x.Id == userId);
                ViewBag.Fullname = userName.Name;
                ViewBag.UserId = userId;
                var follows = myContext.Followers.Where(x => x.UserId == userId).Count();
                ViewBag.NumberOfFollowing = follows;
            }
            return View();
        }

        [HttpGet]
        public IActionResult Following(string userId)
        {
            var follows = myContext.Followers.Where(x => x.UserId == userId).ToList();
            var followings = new List<FollowerViewModel>();
            foreach (var follow in follows)
            {
                var name = myContext.Userz.FirstOrDefault(x => x.Id == follow.FollowerId);
                var following = new FollowerViewModel()
                {
                    Username = name.Name,
                    Follows = true,
                    FollowerId = follow.FollowerId
                };
                followings.Add(following);
            }
            ViewBag.Following = followings.ToList();
            return View();
        }
        private byte[] GetByteArrayFromImage(IFormFile file)
        {
            using (var target = new MemoryStream())
            {
                file.CopyTo(target);
                return target.ToArray();
            }
        }
    }
}