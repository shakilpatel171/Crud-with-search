using Microsoft.AspNetCore.Mvc;
using Sdaemon.Models;

namespace Sdaemon.Controllers
{
    public class EmployeeController : Controller
    {
        AppDbContext _db;

        public EmployeeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
           // var employees = _db.Employees.ToList();
            var employees = _db.Employees.OrderByDescending(x=>x.Id).ToList();

            return View(employees);
        }

        [HttpPost]

        public IActionResult Search(Employee emp)
        {
            List<Employee> list = new List<Employee>();

            var employee = _db.Employees.FirstOrDefault(x => x.Id == emp.Id );

            list.Add(employee);

            return View("Index", list);

        }

        [HttpGet]
        public IActionResult Create() 
        {
        return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp) 
        { 
            if(ModelState.IsValid)
            {
                _db.Employees.Add(emp); 
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

        return View();
        }
    }
}
