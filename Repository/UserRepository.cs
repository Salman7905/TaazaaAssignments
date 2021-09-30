using WebAPITest.Model;
using WebAPITest.Context;
using System.Linq;

namespace WebAPITest.Repository
{
    public class UserRepository : IUserRepository
    {
        UserDbContext context;
        public UserRepository(UserDbContext _context)
        {
            context = _context;
        }
        void IUserRepository.AddUser(User user)
        {
            context.Add(user);
            context.SaveChanges();
        }

        User IUserRepository.ValidateUser(string usr, int pass)
        {
            var record = context.users.FirstOrDefault(e=>e.username==usr && e.password == pass);
            if(record==null)
            {
                return null;            
            }
            return record;
                
           
        }
    }
}