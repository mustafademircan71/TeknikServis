using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServis.Model.Entity
{
    public class Service:BaseEntity
    {
        public string ServiceCode { get; set; }
        public string FullName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int FaultId { get; set; }
        public int DeviceStatusId { get; set; }
        public int CustomerTypeId { get; set; }
        public decimal UnitPrice { get; set; }

        public virtual DeviceStatus DeviceStatus { get; set; }
        public virtual Fault Fault { get; set; }
        public virtual CustomerType CustomerType { get; set; }


    }
}
