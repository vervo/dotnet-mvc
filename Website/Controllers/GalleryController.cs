using System.Web.Mvc;
using Website.Models.Gallery;

namespace Website.Controllers
{
    public class GalleryController : Controller
    {
        [HttpGet, Route("gallery")]
        public ActionResult Index()
        {
            var viewModel = new IndexViewModel();

            return View(viewModel);
        }
    }
}