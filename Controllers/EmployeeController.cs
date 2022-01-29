using Microsoft.AspNetCore.Mvc;
using EmployeesApp.Models;
namespace EmployeesApp.Controllers
{
    public class EmployeeController : Controller
    {
        HRDatabaseContext dbContext = new HRDatabaseContext();
        public IActionResult Index()
        {
            List<Employee> employees = dbContext.Employees.ToList();
            return View(employees);
        }
    }
}
