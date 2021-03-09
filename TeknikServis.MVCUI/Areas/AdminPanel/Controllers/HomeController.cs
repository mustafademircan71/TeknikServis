using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeknikServis.Model.Entity;

using TeknikServis.MVCUI.Extensions;
using TeknikServis.MVCUI.Aspects;

namespace TeknikServis.MVCUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [SessionAspect]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
