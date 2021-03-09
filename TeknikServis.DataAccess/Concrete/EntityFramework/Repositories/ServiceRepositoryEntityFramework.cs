using Core.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.DataAccess.Concrete.EntityFramework.Contexts;
using TeknikServis.Model.Entity;

namespace TeknikServis.DataAccess.Concrete.EntityFramework.Repositories
{
    public class ServiceRepositoryEntityFramework : RepositoryEntityFramework<Service, TeknikServisDbContext>, IServiceRepository
    {
        public Service ServiceByCode(string serviceCode, params string[] includeList)
        {
            return Get(x => x.ServiceCode == serviceCode);
        }
    }
}
