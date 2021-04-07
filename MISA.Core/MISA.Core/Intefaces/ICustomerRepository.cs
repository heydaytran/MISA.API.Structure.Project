using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Intefaces
{

    // Interface này dành riêng cho Customer ( những công việc đặc thù : ví dụ check trùng mã)
   
    /// <summary>
    /// 
    /// </summary>
    public interface ICustomerRepository:IBaseRepository<Customer>
    {
        string GetCustomerCodeById(Guid customerId);
    }
}
