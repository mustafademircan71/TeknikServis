using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Abstract
{
    public interface IServiceBs
    {
        List<Service> ServiceList(params string[] includeList);
        Service ServiceById(int id, params string[] includeList);

        Service ServiceByCode(string serviceCode, params string[] includeList);

        void Update(Service service);
        void Insert(Service service);
        void Delete(int id);
    }
}
