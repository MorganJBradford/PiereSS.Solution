using Microsoft.AspNetCore.Mvc;

namespace Pierre.Controllers
{
  public class TreatsController : Controller
  {

    private readonly PierreContext _db;

    public TreatsController(PierreContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View();
    }
  }
}