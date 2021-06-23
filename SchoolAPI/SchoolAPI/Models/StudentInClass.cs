using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SchoolAPI.Models
{
    public class StudentInClass
    {
        [Key]
        public int SCID { get; set; }
        [Required]
        public int ClassID { get; set; }
        [Required]
        public int StudentID { get; set; }
        
    }
}
