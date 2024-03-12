using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class Categorie
    {
        public required String Name { get; set; }
        [Key]
        public int Id { get; set; }
        public int Cid {  get; set; }
    }
}
