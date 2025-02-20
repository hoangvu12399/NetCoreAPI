using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class BMIController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        } 
    
        [HttpPost]
        public IActionResult Index(string height, string weight, string value)
        {
            string strOutput = "Chiều cao: " + height + " Cân nặng: " + weight + " BMI: " + value;
            ViewBag.Message = strOutput;
            return View();
        }
    }
}