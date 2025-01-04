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

        [HttpGet("/linq/deferred")]
        public ActionResult<List<Employee>> GetEmployeesLinqQuery()
        {
            var employees = employeeService.GetAllEmployees();

            // LINQ method syntax
            var query = from employee in employees
                where employee.Age > 30
                orderby employee.Name
                select employee; // query not executed here


            // query is executed here
            foreach (var employee in query)
            {
                Console.WriteLine(employee);
            }

            return Ok(query);
        }
    }
}