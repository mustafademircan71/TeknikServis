using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServis.Model.Entity
{
    public class Fault:BaseEntity
    {
        //public Fault()
        //{
        //    Services = new HashSet<Service>();
        //}
        public string FaultName { get; set; }
        //public virtual ICollection<Service> Services { get; set; }
        
    }
}
