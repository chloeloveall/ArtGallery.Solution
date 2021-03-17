using Microsoft.AspNetCore.Mvc;

namespace ArtGallery.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}