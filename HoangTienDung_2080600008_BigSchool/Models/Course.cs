﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HoangTienDung_2080600008_BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Leturer { get; set; }
        [Required]
        public string LeturerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }

}