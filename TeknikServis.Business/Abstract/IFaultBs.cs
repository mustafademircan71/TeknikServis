using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Abstract
{
    public interface IFaultBs
    {
        List<Fault> FaultList(params string[] includeList);
        Fault GetByFault(int id);
        void Insert(Fault fault);
        void Update(Fault fault);
        void Delete(int id);
    }
}
