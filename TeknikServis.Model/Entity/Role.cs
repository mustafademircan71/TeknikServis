using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServis.Model.Entity
{
    public class Role:BaseEntity
    {
        //public Role()
        //{
        //    Admins = new HashSet<Admin>();
        //}
        public string RoleName { get; set; }

        //public virtual ICollection<Admin> Admins { get; set; }
    }
}
