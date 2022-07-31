using System.ComponentModel.DataAnnotations;
using System;

namespace PassAppDev.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Decision { get; set; }
        public string Action { get; set; }
        public DateTime NotifiedAt { get; set; } = DateTime.Now;
    }
}
