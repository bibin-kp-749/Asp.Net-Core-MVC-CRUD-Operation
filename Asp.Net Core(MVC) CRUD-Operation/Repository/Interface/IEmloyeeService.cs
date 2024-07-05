using Asp.Net_Core_MVC__CRUD_Operation.Models;

namespace Asp.Net_Core_MVC__CRUD_Operation.Repository.Interface
{
    public interface IEmloyeeService
    {
        Task<bool> AddEmployee(Employee employee);
        Task<List<Employee>> GetEmployees();
    }
}
