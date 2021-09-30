using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebAPITest.Model;
namespace WebAPITest.Context
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<User> users{get;set;}
        
    }
}