using Recipe.Models;

namespace Recipe.ViewModels
{
    public class RecipeDetailsViewModel
    {
        public Recipes Recipe { get; set; }
        public bool IsSaved { get; set; }
        public bool Follows { get; set; }
        public string CreatedBy { get; set; }
        public string UserId { get; set; }
    }
}