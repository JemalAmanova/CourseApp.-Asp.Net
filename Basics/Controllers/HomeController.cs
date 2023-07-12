using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Basics.Models;

namespace Basics.Controllers;

public class HomeController : Controller
{

    //bir view döndüren metod tanımladık. 
    public IActionResult Index()
    {
        //home klasörü altındaki index.cshtml sayfasını bize döndürecek
        return View();
    }

    public IActionResult Contact()
    {
        //home klasörü altındaki Contact.cshtml sayfasını bize döndürecek
        return View();
    }

    
}
