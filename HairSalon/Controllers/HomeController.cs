using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    private readonly HairSalonContext _db;

    public HomeController(HairSalonContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    public ActionResult Search()
    {
      // ViewBag.Name = new SelectList(Stylist.Name, "Value", "Value");
      return View();
    }

    [HttpPost]
    public ActionResult Search(Stylist stylistSearch)
    {
      List<Stylist> results = _db.Stylists
        .Where(stylist => stylist.Name.Contains(stylistSearch.Name))
        .ToList();
      return View("Results", results);
    }

    public ActionResult Results(List<Stylist> result)
    {
      return View(result);
    }
  }
}