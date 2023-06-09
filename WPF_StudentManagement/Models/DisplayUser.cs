using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_StudentManagement.Models
{
    public class DisplayUser
    {
        public Object Object { get; set; }
        public int IdV { get; set; }
        public string FullNameV { get; set; }
        public string GenderV { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DOBV { get; set; }
        public string StudentNumberV { get; set; }
        public string RoleV { get; set; }
        public string ClassV { get; set; }

    }
}
