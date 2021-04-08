using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.API.CukCuk.Controllers
{
    public class CustomerController : BaseEntityController<Customer>
    {
        public CustomerController(IBaseService<Customer> baseService) : base(baseService)
        {

        }
    }
}
