using Asp.Net_Core_MVC__CRUD_Operation.Db;
using Asp.Net_Core_MVC__CRUD_Operation.Models;
using Asp.Net_Core_MVC__CRUD_Operation.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel;

namespace Asp.Net_Core_MVC__CRUD_Operation.Repository
{
    public class EmployeeService: IEmloyeeService
    {
        private readonly EmployeeDbContext _dbContext;
        public EmployeeService(EmployeeDbContext employeeDbContext)
        {
            this._dbContext = employeeDbContext;
        }
        public async Task<List<Employee>> GetEmployees()
        {
            var response = await _dbContext.Employees.ToListAsync();
            return response;
        }
        public async Task<bool> AddEmployee(Employee employee)
        {
            await _dbContext.Employees.AddAsync(employee);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
