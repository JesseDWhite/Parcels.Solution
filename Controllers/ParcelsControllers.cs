using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class ParcelsControllers : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/parcels/newparcel")]
    public ActionResult NewParcel()
    {
      return View("~/Views/Parcels/NewParcel.cshtml");
    }

    [HttpPost("/parcels/parcelresult")]
    public ActionResult ParcelResult(int length, int width, int height, int weight)
    {
      Parcel newParcel = new Parcel(length, width, height, weight);
      newParcel.GetPrice(length, width, height, weight);
      return View("~/Views/Parcels/ParcelResult.cshtml", newParcel);
    }
    private readonly ILogger<ParcelsControllers> _logger;

    public ParcelsControllers(ILogger<ParcelsControllers> logger)
    {
      _logger = logger;
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
}
