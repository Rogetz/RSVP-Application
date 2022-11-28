using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RSVPApplication.Models;

namespace RSVPApplication.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public ViewResult HomePage()
    {
        return View();
    }

    public ViewResult FormPage()
    {
        return View();
    }
    public ViewResult ThankYouPage()
    {
        return View();
    }
    public ViewResult SummaryPage()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
