using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Intefaces
{
    /// interface này dùng để khai báo các thằng interface repository, 
    /// tập hợp all các thông tin....
    public interface IUnitOfWork
    {
        ICustomerRepository Customer { get; }
        ICustomerGroupRepository CustomerGroup { get; }
    }
}
