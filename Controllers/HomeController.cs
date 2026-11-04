using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return Content("This is the About Page");
    }

    public IActionResult FindBook(int id)
    {
        if(id <= 0)
        {
            return NotFound();
        }

        return Content($"This is Book Id: {id}");
    }
}