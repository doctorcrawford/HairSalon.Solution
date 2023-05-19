using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients
                            .Include(client => client.Stylist)
                            .ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      if (client.ClientId == 0)
      {
        return RedirectToAction("Create");
      }
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // public ActionResult Details(int id)
    // {
    //   // Item thisItem = _db.Items
    //   //                     .Include(item => item.Category)
    //   //                     .FirstOrDefault(item => item.ItemId == id);
    //   return View(thisItem);
    // }

    // public ActionResult Edit(int id)
    // {
    //   // Item thisItem = _db.Items.FirstOrDefault(item => item.ItemId == id);
    //   // ViewBag.CategoryId = new SelectList(_db.Categories, "CategoryId", "Name");
    //   return View(thisItem);
    // }

    // [HttpPost]
    // public ActionResult Edit(Item item)
    // {
    //   // _db.Items.Update(item);
    //   // _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   // Item thisItem = _db.Items.FirstOrDefault(item => item.ItemId == id);
    //   return View(thisItem);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   // Item thisItem = _db.Items.FirstOrDefault(item => item.ItemId == id);
    //   // _db.Items.Remove(thisItem);
    //   // _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}