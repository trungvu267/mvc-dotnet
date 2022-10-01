using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc_dotnet.Models;

namespace mvc_dotnet.Controllers;

public class GiaiPhuongTrinhController : Controller
{

    public IActionResult Index()
    {
        // ViewBag.firstName = firstName;
        return View();
    }
    // [HttpPost]   
    // public IActionResult Index(float a=1, float b=1)
    // {        
    //     ViewBag.heSoA= a.ToString();
    //     ViewBag.heSoB = b.ToString();
    //     ViewBag.result = -b/a;
    //     return View();
    // }
    [HttpPost]   
    public IActionResult Index(float a = 2, float b = 3, float c = 1)
    {
        ViewData["message"] = "h";
        ViewData["he_so_a"] = a;
        ViewData["he_so_b"] = b;
        ViewData["he_so_c"] = c;
           // kiem tra cac he so
        if (a == 0)
        {
            if (b == 0)
            {
                ViewData["message"] = "Phuong trinh vo nghiem!";
            }
            else
            {
            ViewData["message"] = ("Phuong trinh co mot nghiem: x =" +(-c / b));
            }
            // return
            
        }
            // tinh delta
            float delta = b * b - 4 * a * c;
            float x1;
            float x2;
            // // tinh nghiem
            if (delta > 0)
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                ViewData["message"] ="Phuong trinh co 2 nghiem la:" + x1 +", "+ x2;
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                ViewData["message"] ="Phong trinh co nghiem kep: x1 = x2 = " + x1;
            }
            else
            {
                ViewData["message"] =("Phuong trinh vo nghiem!");
            }
        
        
        return View();
        }
}
