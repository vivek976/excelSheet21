using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class Departments
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
