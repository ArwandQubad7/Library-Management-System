using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return Content("WelCome to the Home Page");
    }

    public IActionResult About()
    {
        return Content("This is the About Page");
    }
}