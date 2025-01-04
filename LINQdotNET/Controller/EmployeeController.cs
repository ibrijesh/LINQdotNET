using LINQdotNET.Model;
using LINQdotNET.Service;
using Microsoft.AspNetCore.Mvc;

namespace LINQdotNET.Controller
{
    [Route("api/v2/employee")]
    [ApiController]
    public class EmployeeController(IEmployeeService employeeService) : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Employee>> GetAllEmployees()
        {
            var employees = employeeService.GetAllEmployees();
            return Ok(employees);
        }

        [HttpGet("/linq/immediate")]
        public ActionResult<List<Employee>> GetEmployeesLinqQuery()
        {
            var employees = employeeService.GetAllEmployees();

            // LINQ method syntax
            var query = (employees
                .Where(employee => employee.Age > 30)
                .OrderBy(employee => employee.Name)).Count(); // query executes here

            Console.WriteLine(query);
            return Ok(query);
        }
    }
}