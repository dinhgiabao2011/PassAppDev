using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassAppDev.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public DateTime OrderedAt { get; set; } = DateTime.Now;
        [NotMapped]
        public List<OrderedBook> OrderedBooks { get; set; }
    }
}
