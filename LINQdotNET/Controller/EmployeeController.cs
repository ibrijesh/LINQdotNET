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

        [HttpGet("/linq/query")]
        public ActionResult<List<Employee>> GetEmployeesLinqQuery()
        {
            var employees = employeeService.GetAllEmployees();

            // LINQ query syntax
            var query = from employee in employees
                where employee.Age > 30
                orderby employee.Name
                select employee;
            
            // query is executed 
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            return Ok(query);
        }
    }
}