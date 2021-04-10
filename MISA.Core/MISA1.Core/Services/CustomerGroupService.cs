using MISA.Core.Entities;
using MISA.Core.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Services
{
    public class CustomerGroupService:BaseService<CustomerGroup> , ICustomerGroupService
    {
        public CustomerGroupService(ICustomerGroupRepository customerGroupRepository):base(customerGroupRepository)
        {

        }
    }
}
