using Microsoft.EntityFrameworkCore.Metadata.Builders; // fluent API
namespace UserManagementService.Models
{
    public class UserMapper
    {
        public UserMapper(EntityTypeBuilder<User> users)  //EntityTypeBuilder is a generic class which,comes under " Microsoft.EntityFrameworkCore.Metadata.Builders" namespace 
                                                         // contains funstions like haskey ,property etc
        {
            users.HasKey(e=>e.UserId);
            users.Property(e =>e.UserName).IsRequired().HasMaxLength(50);
            users.Property(e =>e.UserAge).IsRequired().HasMaxLength(2);
        }
    }
}