using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.Model.ViewModels.AdminPanel
{
    public class ServiceListVm
    {
      public List<Service> Services { get; set; }
       public List<SelectListItem> Faults { get; set; }

        public List<SelectListItem> DeviceStatus { get; set; }
        public List<SelectListItem> CustomerTypes { get; set; }
    }
}
