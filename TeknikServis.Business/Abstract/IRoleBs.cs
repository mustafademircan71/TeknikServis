using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Abstract
{
    public interface IRoleBs
    {
        List<Role> RoleList();
        
    }
}
