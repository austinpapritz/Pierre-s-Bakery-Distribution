using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PierresDistribution.Controllers;

public class OrderController : Controller
{
    [HttpGet("/vendors/order")]
    public ActionResult Index()
    { 
        return View(); 
    }
}
