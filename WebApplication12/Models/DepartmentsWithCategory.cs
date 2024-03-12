using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class DepartmentsWithCategory
    {
        [Key]
        public int Id { get; set; }
        public string? DepartmentName { get; set; }
        public string? CategoryName { get; set; }
        public int? deptId { get; set; }
        public int? roleId { get; set; }
    }
}
