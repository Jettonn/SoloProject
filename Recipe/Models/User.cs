using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Recipe.Models
{
    public class User:IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public List<Save> Saves { get; set; }
        public List<Review> Reviews { get; set; }
        public User()
        {
            Saves = new List<Save>();
            Reviews = new List<Review>();
        }
    }
}