using LINQdotNET.Model;

namespace LINQdotNET.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    private static List<Employee> employees;

    static EmployeeRepository()
    {
        employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Age = 28 },
            new Employee { Id = 2, Name = "Bob", Age = 35 },
            new Employee { Id = 3, Name = "Charlie", Age = 32 },
            new Employee { Id = 4, Name = "Diana", Age = 25 }
        };
    }

    public List<Employee> FetchEmployees()
    {
        return employees;
    }
}