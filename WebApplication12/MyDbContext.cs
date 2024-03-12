using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using WebApplication12.Models;
namespace WebApplication12
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<User2120> Users500 { get; set;}
        public DbSet<Categorie> Categories {  get; set;}
        public DbSet<Skill> Skills { get; set;}
        public DbSet<Departments> Department { get; set;}  
        public DbSet<DepartmentsWithCategory>DepartmentsWithCategories { get; set;}
    }

}
