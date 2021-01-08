namespace Task3___ReCaptcha.Controllers
{
    using Task3___ReCaptcha.Models;
    using System.Web.Mvc;

    /// <summary>
    /// Defines the <see cref="HomeController" />.
    /// </summary>
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        [HttpPost]
        public JsonResult Submit(RegisterBindingModel model)
        {
            // Form Submission logic
            return this.Json(new { Success = true });
        }
        
    }
}
