using Core.DataAccess;
using Core.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.DataAccess.Concrete.EntityFramework.Contexts;
using TeknikServis.Model.Entity;

namespace TeknikServis.DataAccess.Concrete.EntityFramework.Repositories
{
    public class AdminRepositoryEntityFramework : RepositoryEntityFramework<Admin, TeknikServisDbContext>, IAdminRepository
    {
        public Admin LogIn(string email, string password, params string[] includeList)
        {
            return Get(x => x.Email == email && x.Password == password,includeList);
        }
    }
}
