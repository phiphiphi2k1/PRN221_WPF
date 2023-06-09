using System;
using System.Collections.Generic;

#nullable disable

namespace WPF_StudentManagement.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public bool? Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool? Status { get; set; }
        public int? ClassId { get; set; }

        public virtual Class Class { get; set; }
    }
}
