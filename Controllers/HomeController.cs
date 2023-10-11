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
   
    public IActionResult Requests(){

        var requests = Repository.GetAll();
        return View("RequestList",requests);
        
    }


 [HttpGet]
    public IActionResult AllEquipmentList(){

        var elist = Repository.GetAllEquipments();
        return View("AllEquipmentListing",elist);
        
    }

   [HttpGet]
    public IActionResult AllAvailableEquipmentList(){

        var alist = Repository.GetAvailableEquipments();
        return View("AllEquipmentListing",alist);
        
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
