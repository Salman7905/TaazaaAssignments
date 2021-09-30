using System.ComponentModel.DataAnnotations;

namespace WebAPITest.Model
{
    public class User
    {
        [Key]
        public string username{get;set;}
        public int password{get;set;}
    }
}