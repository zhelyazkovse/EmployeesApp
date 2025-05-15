using EmployeesApp.Web.Services;
using EmployeesApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.Web.Controllers
{
    public class EmployeesController : Controller
    {
        static EmployeeService service = new EmployeeService();

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(service.GetAll());
        }

        [HttpGet("/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Create")]
        public IActionResult Create( Employee employee)
        {
            if (!ModelState.IsValid)
                return View();

            service.AddEmployee(employee);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/Details/{id}")]
        [Route("/Details/{id:int}")]
        public IActionResult Details(int id)
        {
            var model = service.GetById(id);
            return View(model);
        }
    }
}
