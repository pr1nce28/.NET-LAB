using System.Web.Mvc;

namespace Practical9.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("~/Default.aspx");
        }
    }
}
