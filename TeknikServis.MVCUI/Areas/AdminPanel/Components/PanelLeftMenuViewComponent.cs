using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using TeknikServis.Model.Entity;
using TeknikServis.MVCUI.Extensions;

namespace TeknikServis.MVCUI.Areas.AdminPanel.Components
{
    public class PanelLeftMenuViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            Admin activeAdmin = HttpContext.Session.GetObject<Admin>("ActiveAdmin");

            return View(activeAdmin);
        }
    }
}
