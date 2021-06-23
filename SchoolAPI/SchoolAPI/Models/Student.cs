using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SchoolAPI.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        [MaxLength(255)]
        public string StudentName { get; set; }
    }
}
