using System.Collections.Generic;
using TeknikServis.Business.Abstract;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Concrete
{
    public class AdminBs : IAdminBs
    {
        private readonly IAdminRepository _repo;

        public AdminBs(IAdminRepository repo)
        {
            _repo = repo;
        }
        public Admin AdminByEmail(string email,params string[] includeList)
        {
            return _repo.Get(x => x.Email == email, includeList);
        }

        public Admin AdminById(int id,params string[] includeList)
        {
            return _repo.GetById(id, includeList);
        }

        public List<Admin> AdminList(params string[] includeList)
        {
            // iş
            return _repo.GetAll(includeList);
            // iş
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public void DeleteNoActive(int id)
        {
            _repo.DeleteNoActive(id);
        }

        public void Insert(Admin admin)
        {
            _repo.Insert(admin);
        }

        

        public Admin LogIn(string email, string password,params string[] includeList)
        {
            return _repo.LogIn(email,password, includeList);
        }

        public void Update(Admin admin)
        {
            _repo.Update(admin);
        }
    }
}
