
namespace LearningSystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User:IdentityUser
    {
        public User()
        {
            this.Courses = new List<StudentCourse>();
            this.Trainigns = new List<Course>();
            this.Articles = new List<Article>();
        }

        [Required]
        [MinLength(DataConstants.UsernameMinLength)]
        [MaxLength(DataConstants.UsernameMaxLength)]
        public string Name { get; set; }

        public DateTime Birtdate { get; set; }

        public List<Article> Articles { get; set; }

        public List<Course> Trainigns { get; set; }

        public List<StudentCourse> Courses { get; set; }
    }
}
