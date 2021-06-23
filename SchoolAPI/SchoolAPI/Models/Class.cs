using System.ComponentModel.DataAnnotations;

namespace SchoolAPI.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }
        [Required]
        [MaxLength(255)]
        public string ClassName { get; set; }
    }
}
