﻿using PassAppDev.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PassAppDev.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be null ...")]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public CategoryStatus Status { get; set; } = CategoryStatus.Pending;

        public List<Book> Books { get; set; }
    }
}