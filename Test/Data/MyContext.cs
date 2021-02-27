using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=data.db;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}