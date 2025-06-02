using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using crudApp.Models;

namespace crudApp.Controllers;

public class HomeController : Controller
{
    // get hello world
    public IActionResult Index()
    {
        return Content("Hello World!");
    }
    
}