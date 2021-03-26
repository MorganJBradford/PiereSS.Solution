using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Linq;

namespace Pierre.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierreContext _db;

    public HomeController(PierreContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.allTreats = _db.Treats.ToList();
      ViewBag.allFlavors = _db.Flavors.ToList();
      return View();
    }
  }
}