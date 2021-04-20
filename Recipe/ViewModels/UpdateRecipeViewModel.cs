using System.ComponentModel.DataAnnotations;
using Recipe.Models;

namespace Recipe.ViewModels
{
    public class UpdateRecipeViewModel
    {
        [Key]
        public int RecipeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Serving should be greater than 0!")]
        public int Serving { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Time should be greater than 0!")]
        public int Time { get; set; }
        public string Prepare { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        public int Calories { get; set; }
    }

    public class AddIngredients
    {
        [Required]
        public int RecipeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Quantity { get; set; }
    }
}