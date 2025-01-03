using LINQdotNET.Model;
using LINQdotNET.Repository;

namespace LINQdotNET.Service;

public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
{
    public List<Employee> GetAllEmployees()
    {
        return employeeRepository.FetchEmployees();
    }
}