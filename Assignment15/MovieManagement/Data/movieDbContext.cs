using Microsoft.EntityFrameworkCore;
using MovieManagement.Models;
namespace MovieManagement.Data
{
    public class movieDbContext:DbContext
    {
        public movieDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Movie> movies{get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder) //linking between Movie and MovieMapper
        {
            new MovieMapper(modelBuilder.Entity<Movie>());
        }   
    }
}