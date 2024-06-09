using FeverCheckApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeverCheckApp.Controllers
{
    public class DoctorController : Controller
    {

        [HttpGet]                               // GET FeverCheck empty
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]                              // POST FeverCheck with data
        public IActionResult FeverCheck(double? temperature, string unit)
        {
            if (temperature.HasValue)
            {
                string result = TemperatureChecker.CheckTemperature(temperature.Value, unit);
                ViewBag.Result = result;
            }
            return View();
        }
    }
}
