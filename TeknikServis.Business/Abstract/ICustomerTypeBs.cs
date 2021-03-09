using System;
using System.Collections.Generic;
using System.Text;
using TeknikServis.Model.Entity;

namespace TeknikServis.Business.Abstract
{
    public interface ICustomerTypeBs
    {
        List<CustomerType> CustomerTypeList();

        void Insert(CustomerType customerType);
    }
}
