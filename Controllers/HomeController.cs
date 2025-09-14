using Microsoft.AspNetCore.Mvc;

namespace MetricSystem.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Privacy() => View();
}
