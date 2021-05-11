using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsControllers : Controller
  {


    [HttpGet("parcels/newparcel")]
    public ActionResult NewParcel()
    {
      return View();
    }

    [HttpPost("/parcels/parcelresult")]
    public ActionResult ParcelResult(int length, int width, int height, int weight)
    {
      Parcel newParcel = new Parcel(length, width, height, weight);
      return View(Parcel.GetPrice(length, width, height, weight));
    }
  }
}
