using Core.DataAccess.Abstract;
using TeknikServis.Model.Entity;

namespace TeknikServis.DataAccess.Abstract
{
    public interface IAdminRepository:IRepository<Admin>
    {
        Admin LogIn(string email, string password, params string[] includeList);
    }

   
}
