using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchoolWASM.Models
{
    public class Class
    {
        public int ClassID { get; set; }
        [Required]
        public string ClassName { get; set; }
    }
}
