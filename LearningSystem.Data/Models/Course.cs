using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LearningSystem.Data.Models
{
    public class Course
    {
        public Course()
        {
            this.Students = new List<StudentCourse>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.CourseMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DataConstants.DescriptionMaxLngth)]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string TrainerId { get; set; }

        public User Trainer { get; set; }

        public List<StudentCourse> Students { get; set; }
    }
}
