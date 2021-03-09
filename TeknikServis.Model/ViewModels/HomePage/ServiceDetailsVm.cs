using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.Model.ViewModels.HomePage
{
    public class ServiceDetailsVm
    {

        public string ServiceCode { get; set; }
        public string FullName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int FaultId { get; set; }
        public int DeviceStatusId { get; set; }
        public decimal UnitPrice { get; set; }

        public List<SelectListItem> DeviceStatus { get; set; }
        public List<SelectListItem> Fault { get; set; }

    }
}
