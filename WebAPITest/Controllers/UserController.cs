using System;
using Microsoft.EntityFrameworkCore;
using WebAPITest.Model;
using WebAPITest.Repository;
using Microsoft.AspNetCore.Mvc;
namespace WebAPITest.Controllers
{
    [ApiController]
    [Route("Taazaa/[controller]")]
    public class UserController:ControllerBase
    {
        IUserRepository iuser;
        public UserController(IUserRepository _iuser)
        {
            iuser = _iuser;
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult createUser(User user)
        {
            iuser.AddUser(user);
            return Ok("Account created successfully");
        }
        [HttpGet]
        [Route("Validate/{pass:int}")]
        public IActionResult validateUser(string usr, int pass)
        {
            var record = iuser.ValidateUser(usr,pass);
            if(record == null)
            {
                return Ok("Please enter valid username and password!");
            }
    
            return Ok("Logged in successfully");
            
           
        }
    }
}