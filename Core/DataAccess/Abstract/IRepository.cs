using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Abstract
{
    public interface IRepository<TEntity> 
    {
        List<TEntity> GetAll(params string[] includeList);
        TEntity GetById(int id, params string[] includeList);
        TEntity Get(Func<TEntity, bool> filter, params string[] includeList);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int id);
        void DeleteNoActive(TEntity entity);
        void DeleteNoActive(int id);


    }
}
