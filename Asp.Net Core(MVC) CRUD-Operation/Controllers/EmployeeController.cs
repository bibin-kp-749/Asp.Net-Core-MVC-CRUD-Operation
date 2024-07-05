using Asp.Net_Core_MVC__CRUD_Operation.Models;
using Asp.Net_Core_MVC__CRUD_Operation.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_MVC__CRUD_Operation.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmloyeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(IEmloyeeService emloyeeService,ILogger<EmployeeController> logger)
        {
            this._employeeService = emloyeeService;
            this._logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            var res=await _employeeService.GetEmployees();
            return View(res);
        }
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            await _employeeService.AddEmployee(new Employee {EmployeeName=employee.EmployeeName,EmployeeAge=employee.EmployeeAge,Department=employee.Department});
            return RedirectToAction("Index");
        }
    }
}
