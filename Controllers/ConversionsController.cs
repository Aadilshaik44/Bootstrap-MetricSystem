using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers;

public class ConversionsController : Controller
{
    [HttpGet]
    public IActionResult Fahrenheit() => View(new TemperatureViewModel());

    [HttpPost]
    public IActionResult Fahrenheit(TemperatureViewModel model, string? clear)
    {
        if (!string.IsNullOrEmpty(clear))
        {
            ModelState.Clear();
            return View(new TemperatureViewModel());
        }

        if (!ModelState.IsValid)
            return View(model);

        double f = model.FahrenheitValue!.Value;
        double c = (f - 32.0) * 5.0 / 9.0;

        ModelState.Remove(nameof(TemperatureViewModel.CelsiusValue));
        model.CelsiusValue = c;

        return View(model);
    }
}
