using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Business.Abstract;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Concrete
{
    public class ServiceBs : IServiceBs
    {
        private readonly IServiceRepository _repo;
        public ServiceBs(IServiceRepository repo)
        {
            _repo = repo;
        }

        public void Delete(int id)
        {
            _repo.DeleteNoActive(id);
        }

        public void Insert(Service service)
        {
            _repo.Insert(service);
        }

        public Service ServiceByCode(string serviceCode, params string[] includeList)
        {
            return _repo.Get(x => x.ServiceCode == serviceCode,includeList);
        }

        public Service ServiceById(int id, params string[] includeList)
        {
            return _repo.GetById(id);
        }

        public List<Service> ServiceList(params string[] includeList)
        {
            return _repo.GetAll(includeList);
        }

        public void Update(Service service)
        {
            _repo.Update(service);
        }
    }
}
