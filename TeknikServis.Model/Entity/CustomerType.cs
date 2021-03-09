using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServis.Model.Entity
{
    public class CustomerType:BaseEntity
    {
        public string CustomerTypeName { get; set; }
        public ICollection<Service> Services { get; set; } = new HashSet<Service>();
    }
}
