using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var list = new List<StudentVm>(){
            new StudentVm(){Id =1 , Name="One",Address="add1"},
            new StudentVm(){Id =2, Name="Two",Address="add2"},
        };
        return View(list);
    }

    public IActionResult Test(){
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult New(){
        return View(new TestVm());
    }
    [HttpPost]

    public IActionResult New(TestVm vm){
        return Ok(vm);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
   
}
