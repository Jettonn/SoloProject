using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Recipe.Models;

namespace Recipe.Models
{
    public class Recipes
    {
        [Key]
        public int RecipeId { get; set; }
        [Required]
        public string Name { get; set; }
        public int Serving { get; set; }
        public int Time { get; set; }
        public string Prepare { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        public int Calories { get; set; }
        public byte[] Image { get; set; }
        public string ImageFileName { get; set; }
        public string ImageContentType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Save> Saves { get; set; }
        public List<Review> Reviews { get; set; }
        public List<RecipeIngredients> RecipeIngredients { get; set; }
    }
}