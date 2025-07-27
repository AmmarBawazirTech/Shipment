using System.Diagnostics;
using BL.Interfaces;
using DataAcessesLayer.Contract;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace TripsSystem.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IShipmentTypeService _iGenericRepository;
    public HomeController(ILogger<HomeController> logger,IShipmentTypeService genericRepository)
    {
        _logger = logger;
        _iGenericRepository = genericRepository;
    }

    public IActionResult Index()
    {
        var shippingTypes = _iGenericRepository.GetAll();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}
}
