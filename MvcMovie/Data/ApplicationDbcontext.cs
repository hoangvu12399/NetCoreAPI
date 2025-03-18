using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        private DbSet<Person> persons;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Persons { get => persons; set => persons = value; }
        public DbSet<Person> Student { get => persons; set => persons = value; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Daily> Dailies { get; set; }
        public DbSet<HeThongPhanPhoi> HeThongPhanPhois { get; set; }
    }
}