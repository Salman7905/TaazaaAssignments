using WebAPITest.Model;
namespace WebAPITest.Repository
{
    public interface IUserRepository
    {
         void AddUser(User user);
         User ValidateUser(string usr,int pass);
    }
}