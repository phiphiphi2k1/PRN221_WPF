using System;
using System.Collections.Generic;

#nullable disable

namespace WPF_StudentManagement.Models
{
    public partial class Class
    {
        public Class()
        {
            Users = new HashSet<User>();
        }

        public int ClassId { get; set; }
        public string Subject { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
