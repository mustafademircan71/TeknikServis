using Core.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.DataAccess.Concrete.EntityFramework.Contexts;
using TeknikServis.Model.Entity;

namespace TeknikServis.DataAccess.Concrete.EntityFramework.Repositories
{
    public class RoleRepositoryEntityFramework : RepositoryEntityFramework<Role, TeknikServisDbContext>, IRoleRepository
    {
    }
}
