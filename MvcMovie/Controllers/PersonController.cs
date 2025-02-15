using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    { 
        public IActionResult Index3()
        {
            return View();
        } 

        public IActionResult Welcome3()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        } 
        [HttpPost]
        public IActionResult Index(Person @ps)
        {
            string strOutput = "Xin chào" + ps.PersonID + "-" + ps.Fullname + "-" + ps.Address;
            ViewBag.inforPerson = strOutput;
            return View();
        }
    }
}
