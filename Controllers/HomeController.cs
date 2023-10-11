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

       if(ModelState.IsValid)
        {


        Repository.AddRequest(request);

        return View("Reply",request);       

        }
        else{

            return View("RequestForm");
        }
       

    }
    [HttpGet]
    public IActionResult RequestList(){

        var list = Repository.GetAll();
        return View(list);
        
    }


 [HttpGet]
    public IActionResult AllEquipmentList(){

        var elist = Repository.GetAllEquipments();
        return View("AllEquipmentListing",elist);
        
    }
  

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
