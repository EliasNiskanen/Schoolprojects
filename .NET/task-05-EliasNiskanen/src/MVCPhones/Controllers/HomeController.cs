using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCPhones.Data;
using MVCPhones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MVCPhones.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public IList<Phone> phones { get; set; }

    private readonly PhonesContext _phonesContext;

    public HomeController(PhonesContext phonesContext)
    {
        this._phonesContext = phonesContext;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var phones = await _phonesContext.Phones.OrderByDescending(p=> p.Modified).Take(3).ToListAsync();
        return View(phones);    
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
