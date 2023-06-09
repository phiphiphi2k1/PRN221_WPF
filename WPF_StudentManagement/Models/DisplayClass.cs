using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_StudentMagement.Models
{
    public class DisplayClass
    {
        public Object Object { get; set; }
        public int ClassIdV { get; set; }
        public string SubjectNameV { get; set; }
        public int NumberOfStudentV { get; set; }
    }
}
