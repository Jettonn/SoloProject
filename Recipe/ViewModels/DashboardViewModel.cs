using Recipe.Models;

namespace Recipe.ViewModels
{
    public class DashboardViewModel
    {
        public Recipes Recipe { get; set; }
        public bool IsSaved { get; set; }
        public string CreatedBy { get; set; }
        public double Rating { get; set; }
    }

    public class RecentRecipes
    {
        public int RecipeId { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public bool IsSaved { get; set; }
        public string CreatedBy { get; set; }
    }

    public class IndexViewModel
    {
        public Recipes Recipe { get; set; }
        public string CreatedBy { get; set; }
    }
}