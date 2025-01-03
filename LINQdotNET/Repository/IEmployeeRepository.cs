using LINQdotNET.Model;

namespace LINQdotNET.Repository;

public interface IEmployeeRepository
{
    public List<Employee> FetchEmployees();
}