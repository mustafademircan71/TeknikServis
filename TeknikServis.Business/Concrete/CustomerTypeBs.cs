using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Business.Abstract;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Concrete
{
    public class CustomerTypeBs : ICustomerTypeBs
    {
        private readonly ICustomerTypeRepository _repo;

        public CustomerTypeBs(ICustomerTypeRepository repo)
        {
            _repo = repo;
        }
        public List<CustomerType> CustomerTypeList()
        {
            return _repo.GetAll();
        }

        public void Insert(CustomerType customerType)
        {
            _repo.Insert(customerType);
        }
    }
}
