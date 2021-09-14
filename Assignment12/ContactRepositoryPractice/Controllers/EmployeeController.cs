
using ContactRepositoryPractice.Models;
using ContactRepositoryPractice.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ContactRepositoryPractice.Controllers
{
    [ApiController]
    [Route("controller")]
    public class EmployeeController:ControllerBase
    {
        IEmployee iemployee;
        public EmployeeController(IEmployee _iemployee)
        {
             iemployee = _iemployee;
        }
        [HttpPost]
        public IActionResult addEmployee(Employee employee)
        {
                  iemployee.Add(employee);
                  return Ok("Record added successfully!");
        }
        [HttpPut]
        public IActionResult updateEmployee(Employee employee)
        {
            iemployee.Update(employee);
            return Ok("Record update successfully!");
        }
        [HttpDelete("{id:int}")]
        public IActionResult deleteEmployee(int id)
        {
            iemployee.Remove(id);
            return Ok("Record deleted successfully!");
        }
        [HttpGet("{id:int}")]
        public IActionResult seachEmployee(int id)
        {
            var employeeRecord = iemployee.Find(id);
            return Ok(employeeRecord);
        }
        [HttpGet("EmployeeList")]
        public IActionResult displayEmployees()
        {
           var employeesList = iemployee.GetAll();
           return Ok(employeesList);
        }

    }
}