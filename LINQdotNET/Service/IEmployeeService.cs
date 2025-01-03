using LINQdotNET.Model;

namespace LINQdotNET.Service;

public interface IEmployeeService
{
    public List<Employee> GetAllEmployees();
}