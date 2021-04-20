using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recipe.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int RecipeId { get; set; }
        public Recipes Recipe { get; set; }
        [Required]
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}