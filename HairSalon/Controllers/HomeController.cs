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
      return View();
    }

    [HttpPost]
    public ActionResult SearchStylists(Stylist stylistSearch)
    {
      List<Stylist> results = _db.Stylists
        .Where(stylist => stylist.Name.Contains(stylistSearch.Name))
        .ToList();
      return View("ResultsStylists", results);
    }

    public ActionResult Results(List<Stylist> result)
    {
      return View(result);
    }
  }
}