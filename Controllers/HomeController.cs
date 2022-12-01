using Microsoft.AspNetCore.Mvc;

namespace LawForumAssessment.Controllers;

    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("/result")]
        public IActionResult Result()
        {
            return View("Result");
        }
    }