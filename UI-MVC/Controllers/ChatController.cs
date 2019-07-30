using Microsoft.AspNetCore.Mvc;

namespace SC.UI.Web.MVC.Controllers
{
    public class ChatController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}