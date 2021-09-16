using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using UserManagementService.Service;
using UserManagementService.Models;

namespace UserManagementService.Controllers
{ 
    [ApiController]
    [Route("Controller")]
    public class UserController:ControllerBase
    {
        IUserRepository iuser;
        public UserController(IUserRepository _iuser)
        {
             iuser = _iuser;        
        }
        [HttpPost]
       // [Route("CreateRecords")]
        public IActionResult postUser(User user)
        {
            int res = iuser.addUser(user);
            if(res!=0)
            {
                return Ok("Record saved successfully!!");
            }
            return Forbid();
        }
        [HttpPut("{id}")]
       // [Route("Update")]
        public IActionResult updateUser(int id ,User user)
        {
            int userToUpdate = iuser.updateUser(id,user);
            if(userToUpdate!=0)
            {
               return Ok("Record updated successfully!!");
            }
            return NotFound("Please enter valid record");
        }
        [HttpGet]
        public IActionResult searchUser(int id)
        {
            var user = iuser.searchUser(id);
            if(user==null)
            {
                return NotFound();
            }
            return Ok("Found ! "+user.UserName+" "+user.UserAge);
        }
        [HttpDelete]
       // [Route("Delete")]
        public IActionResult deleteUser(int id)
        {
            var user = iuser.deleteUser(id);
            if(user!=0)
            {
                return Ok("Record deleted successfully");
            }
            return NotFound("Please enter valid record");
        }
        [HttpGet("All User Records")]
       // [Route("All User Records")]
        public IEnumerable<User> alluserRecord()
        {
            var users = iuser.getUsers();
            return users;
        }
    }
}