using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recipe.Models;
using Recipe.ViewModels;

namespace Recipe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly MyContext myContext;

        public HomeController(ILogger<HomeController> logger,
                                UserManager<User> userManager,
                                SignInManager<User> signInManager,
                                MyContext myContext)
        {
            _logger = logger;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.myContext = myContext;
        }

        public IActionResult Index()
        {
            var indexRecipes = new List<IndexViewModel>();
            var recentAddedRecipes = myContext.Recipes.OrderByDescending(x => x.CreatedAt).Take(3).ToList();
            foreach (var recipe in recentAddedRecipes)
            {
                var user = myContext.Userz.FirstOrDefault(x => x.Id == recipe.CreatedBy);
                var recipeToShow = new IndexViewModel()
                {
                    CreatedBy = user.Name,
                    Recipe = recipe
                };
                indexRecipes.Add(recipeToShow);
            }
            ViewBag.RecentRecipes = indexRecipes.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
