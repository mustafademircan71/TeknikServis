using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServis.Model.ViewModels.AdminPanel
{
    public class ServiceDetailsVm
    {
        public int Id { get; set; }
        public string ServiceCode { get; set; }
        public string FullName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int FaultId { get; set; }
        public int DeviceStatusId { get; set; }
        public int CustomerTypeId { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
