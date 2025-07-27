using BL.Interfaces;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class ShipmentTypeController : Controller
    {
        private readonly IBaseService<TbShippingType> _shipmentTypeService;

        public ShipmentTypeController(IBaseService<TbShippingType> shipmentTypeService)
        {
            _shipmentTypeService = shipmentTypeService;
        }
        public IActionResult Index()
        {
            var types = _shipmentTypeService.GetAll();

            return View();
        }
    }
}
