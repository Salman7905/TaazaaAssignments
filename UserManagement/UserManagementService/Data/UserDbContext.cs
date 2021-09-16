//using Microsoft.EntityFrameworkCore.Mode;
using Microsoft.EntityFrameworkCore;
using UserManagementService.Models;
namespace UserManagementService.Data
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions options):base(options)
        {
      
          
        }
        public DbSet<User> users{get;set;}   // (it works like select Query) it has two feature  1.)to pass model   2)for table  
        protected override void OnModelCreating(ModelBuilder modelBuilder)  // takes parameter modelbuilder
        {
          // linking between user and usermapper 
          new UserMapper(modelBuilder.Entity<User>());  
        }
    }
}