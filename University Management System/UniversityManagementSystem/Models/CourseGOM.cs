﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.Models
{
    public class CourseGOM
    {

        public int CourseId { get; set; }
        [Required(ErrorMessage = "Please enter a Course Code")]
        [DisplayName("Code")]
        public string CourseCode { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Please enter Course Name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Please Enter a Valid Credit")]
        [Range(0.5, 5.0, ErrorMessage = "Sorry, Credit must be between 0.5 and 5.0 to register.")]
        public double Credit { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Please Enter a Department Name")]
        [DisplayName("Department")]
        public string DeptId { get; set; }

        [Required(ErrorMessage = "Please Enter a Semester")]
        [DisplayName("Semester")]
        public string SemesterId { get; set; }


        

    }
}