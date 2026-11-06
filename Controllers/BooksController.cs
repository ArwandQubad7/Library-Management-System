using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers;

public class BooksController : Controller
{
    public IActionResult Index()
    {
                List<Book> books = new List<Book>
        {
             new Book
        {
            Id = 1,
            Title = "Clean Code",
            Author = "Robert C. Martin",
            Price = 25,
            IsAvailable = true
        },

        new Book
        {
            Id = 2,
            Title = "C# in Depth",
            Author = "Jon Skeet",
            Price = 40,
            IsAvailable = false
        },

        new Book
        {
            Id = 3,
            Title = "Design Patterns",
            Author = "Erich Gamma and others",
            Price = 35,
            IsAvailable = true
        }
        };

        return View(books);

    }

    public IActionResult Details()
    {
        Book book = new Book
        {
            Id = 1,
            Title = "Electronics",
            Author = "Arwand",
            Price = 25,
            IsAvailable = true
        };

        return View(book);
    }

}