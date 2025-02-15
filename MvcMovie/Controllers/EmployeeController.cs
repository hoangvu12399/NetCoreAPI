using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    { 
        public IActionResult Index2()
        {
            return View();
        } 

        public IActionResult Welcome2()
        {
            return View();
        }
    }
}
