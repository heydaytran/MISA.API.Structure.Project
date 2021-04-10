using MISA.Core.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        // Mục đích : muốn không phải giống entity: muốn lấy dữ liệu phải entity.tableName
        public UnitOfWork(ICustomerRepository customerRepository, ICustomerGroupRepository customerGroupRepository)
        {
            Customer = customerRepository;
            CustomerGroup = customerGroupRepository;
        }
        public ICustomerRepository Customer { get; }
        public ICustomerGroupRepository CustomerGroup { get; }
    }
}
