using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class User2120
    {
        public required String Name { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
