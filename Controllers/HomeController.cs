using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment_1.Models;

namespace Assignment_1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    //GET /home/RsvpForm

    public IActionResult RequestForm()
    {
        return View();

    }


 [HttpPost]
    public IActionResult SaveRequest(EquipmentRequest request){


        return View("RequestForm");
       
       

    }

  

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
