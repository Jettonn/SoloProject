using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Recipe.Models;


namespace Recipe.Models
{
    public class Follow
    {
        [Key]
        public int FollowId { get; set; }
        public string UserId { get; set; }
        public string FollowerId { get; set; }
        public DateTime DateFollowed { get; set; } = DateTime.Now;
    }
}