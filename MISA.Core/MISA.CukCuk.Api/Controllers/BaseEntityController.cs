using Microsoft.AspNetCore.Mvc;
using MISA.Core.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.CukCuk.Api.Controllers
{
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class BaseEntityController<MISAEntity> : ControllerBase
    {
        IBaseService<MISAEntity> _baseService;

        // hàm khởi tạo

        public BaseEntityController(IBaseService<MISAEntity> baseService)
        {
            _baseService = baseService;
        }

        // GET: api/<BaseEntityController>
        [HttpGet]
        public IEnumerable<MISAEntity> Get()
        {
            var entities = _baseService.GetEntities();
            return entities;
        }

        // GET api/<BaseEntityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BaseEntityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BaseEntityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BaseEntityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
