using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recipe.Models
{
    public class Save
    {
        [Key]
        public int SaveId { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int RecipeId { get; set; }
        public Recipes Recipe { get; set; }
        public DateTime SavedAt { get; set; } = DateTime.Now;
    }
}