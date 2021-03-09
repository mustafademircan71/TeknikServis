using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.Model.ViewModels.AdminPanel
{
    public class AdminListVm
    {
        public List<Admin> Admins { get; set; }
        public List<SelectListItem> Roles { get; set; }
    }
}
