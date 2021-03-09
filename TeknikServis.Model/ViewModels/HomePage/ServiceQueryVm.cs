using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.Model.ViewModels.HomePage
{
    public class ServiceQueryVm
    {
        public string ServiceCode { get; set; }
        public string FullName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int FaultId { get; set; }
        public int DeviceStatusId { get; set; }
        public decimal UnitPrice { get; set; }
        public Fault Fault { get; set; }
        public DeviceStatus DeviceStatus { get; set; }
        public List<SelectListItem> DeviceStatuses { get; set; }
        public List<SelectListItem> Faults { get; set; }

    }
}
