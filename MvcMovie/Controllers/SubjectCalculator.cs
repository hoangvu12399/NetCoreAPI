using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class SubjectCalculatorController : Controller
    {
        [HttpPost]
        public IActionResult Index(string subjectName, string subjectScore, string scoreA, string scoreB, string scoreC)
        {
            var SubjectCalculator = new SubjectCalculator();
            SubjectCalculator.SubjectName = Request.Form["SubjectName"];
            SubjectCalculator.ScoreA = Request.Form["ScoreA"];
            SubjectCalculator.ScoreB = Request.Form["ScoreB"];
            SubjectCalculator.ScoreC = Request.Form["ScoreC"];
            
            double scoreAValue = Convert.ToDouble(SubjectCalculator.ScoreA);
            double scoreBValue = Convert.ToDouble(SubjectCalculator.ScoreB);
            double scoreCValue = Convert.ToDouble(SubjectCalculator.ScoreC);
            SubjectCalculator.SubjectScore = (scoreAValue * 0.6 + scoreBValue * 0.3 + scoreCValue * 0.1).ToString("F2");
            
            ViewBag.Message = " Tên môn học: " + SubjectCalculator.SubjectName + " Điểm môn học: " + SubjectCalculator.SubjectScore;
            return View();
        } 
        
        public IActionResult Index()
        {
            return View();
        }
    }
}