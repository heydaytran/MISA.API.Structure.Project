using MISA.Core.Entities;
using MISA.Core.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Services
{
    // service này dùng để thực thi các công việc riêng của Customer, ngoài những cviec kế thừa từ baseService
    public class CustomerService :BaseService<Customer>, ICustomerService
    {
        IUnitOfWork _unitOfWork;
        public CustomerService(IUnitOfWork unitOfWork, IBaseRepository<Customer> baseRepository) : base(baseRepository)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
