using MISA.Core.Entities;
using MISA.Core.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Infrastructure.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public string GetCustomerCodeById(Guid customerId)
        {
            throw new NotImplementedException();
        }
    }
}
