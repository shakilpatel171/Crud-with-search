using Microsoft.AspNetCore.Mvc;
using Sdaemon.Models;

namespace Sdaemon.Controllers
{
    public class HrController : Controller
    {
        AppDbContext _db;
        public HrController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
           var hr = _db.HrModels.ToList();
           
            return View(hr);
        }
    }
}
