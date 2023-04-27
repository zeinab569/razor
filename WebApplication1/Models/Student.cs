using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        public int Id {  get; set; }
        [Required]
        public string Name { get; set; }
        [Range(20,30)]
        public int Age { get; set; }

    }
}
