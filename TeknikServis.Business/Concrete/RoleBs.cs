using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Business.Abstract;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Concrete
{
    public class RoleBs : IRoleBs
    {
        private readonly IRoleRepository _repo;

        public RoleBs(IRoleRepository repo)
        {
            _repo = repo;
        }

        public List<Role> RoleList()
        {
            return _repo.GetAll();
        }
    }
}
