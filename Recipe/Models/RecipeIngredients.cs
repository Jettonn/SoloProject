using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recipe.Models
{
    public class RecipeIngredients
    {
        [Key]
        public int RecipeIngredientsId { get; set; }
        public int RecipeId { get; set; }
        public Recipes Recipe { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Quantity { get; set; }
    }
}