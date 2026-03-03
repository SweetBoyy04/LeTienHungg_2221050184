using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models.Entities
{
    public class Student
    {
        [Key]
        public String StudentCore { get; set; } = default!;
        public String FullName { get; set; } = default!;

        public int Age { get; set; } = default!;
    }
}