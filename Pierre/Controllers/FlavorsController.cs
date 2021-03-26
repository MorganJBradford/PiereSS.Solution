using Microsoft.AspNetCore.Mvc;

namespace Pierre.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly PierreContext _db;

    public FlavorsController(PierreContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "Name");
      return View();
    }
  }
}