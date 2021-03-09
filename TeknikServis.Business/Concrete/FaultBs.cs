using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Business.Abstract;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Concrete
{
    public class FaultBs : IFaultBs
    {
        private readonly IFaultRepository _repo;
        public FaultBs(IFaultRepository repo)
        {
            _repo = repo;
        }
        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public List<Fault> FaultList(params string[] includeList)
        {
            return _repo.GetAll(includeList);
        }

        public Fault GetByFault(int id)
        {
            return _repo.GetById(id);
        }

        public void Insert(Fault fault)
        {
            _repo.Insert(fault);
        }

        public void Update(Fault fault)
        {
            _repo.Update(fault);
        }
    }
}
