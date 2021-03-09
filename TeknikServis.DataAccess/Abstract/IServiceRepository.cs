using Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.DataAccess.Abstract
{
    public interface IServiceRepository: IRepository<Service>
    {
        Service ServiceByCode(string serviceCode, params string[] includeList);
    }
}
