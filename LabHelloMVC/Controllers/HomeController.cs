using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LabHelloMVC.Models;

namespace LabHelloMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Person person1 = new Person()
        {
            PersonId = 1,
            FirstName = "Andrea",
            LastName = "Morshead"
        };
        return View(person1);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}