using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.LibraryName  = "Erbil Library";
        ViewBag.TotalBooks = 150;

        return View();
    }

    public IActionResult About()
    {
        return Content("This is the About Page");
    }

}