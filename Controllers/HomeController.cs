using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey_Validations.Models;

namespace DojoSurvey_Validations.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("/results")]
    public IActionResult Results()
    {
        return View("Results");
    }

    [HttpPost("/createStudent")]
    public IActionResult CreateStudent(Student newStudent)
    {
        if(!ModelState.IsValid)
        {
            return View("Index");
        }
        return View("Results", newStudent);
    }

    [HttpGet("{**path}")]
    public RedirectResult CatchAll()
    {
        Console.WriteLine("This page does not exists!");
        return Redirect("/");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
