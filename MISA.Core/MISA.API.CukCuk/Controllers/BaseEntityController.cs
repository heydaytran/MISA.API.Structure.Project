using Microsoft.AspNetCore.Mvc;
using MISA.Core.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.API.CukCuk.Controllers
{
    /*  [Route("api/v1/[controller]s")]
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
          public IActionResult   Get()
          {
              var entities = _baseService.GetEntities();
              return Ok(entities);
          }

          // GET api/<BaseEntityController>/5
          [HttpGet("{id}")]
          public IActionResult Get(Guid id)
          {
              var entities = _baseService.GetById(id);
              return Ok(entities);
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
      }*/

    [Route("api/v1/[controller]s")]
    [ApiController]
    public abstract class BaseEntityController<MISAEntity> : ControllerBase
    {
        IBaseService<MISAEntity> _baseService;

        public BaseEntityController(IBaseService<MISAEntity> baseService)
        {
            _baseService = baseService;
        }

        // GET: api/<BaseEntityController>
        [HttpGet]
        public IActionResult Get()
        {
            var entities = _baseService.GetEntities();
            if (entities.Count() == 0)
                return NoContent();
            else
                return Ok(entities);
        }

        // GET api/<BaseEntityController>/5
        [HttpGet("{entityId}")]
        public IActionResult Get(Guid entityId)
        {
            var entity = _baseService.GetById(entityId);
            if (entity == null)
                return NoContent();
            else
                return Ok(entity);
        }

        // POST api/<BaseEntityController>
        [HttpPost]
        public IActionResult Post([FromBody] MISAEntity entity)
        {
            var rowAffects = _baseService.Insert(entity);
            if (rowAffects == 0)
                return NoContent();
            else
                return Ok(rowAffects);
        }

        // PUT api/<BaseEntityController>/5
        [HttpPut("{entityId}")]
        public IActionResult Put(Guid entityId, [FromBody] MISAEntity entity)
        {
            var rowAffects = _baseService.Update(entity, entityId);
            if (rowAffects == 0)
            {
                return NoContent();
            }
            else
                return Ok(rowAffects);
        }

        // DELETE api/<BaseEntityController>/5
        [HttpDelete("{entityId}")]
        public IActionResult Delete(Guid entityId)
        {
            var rowAffects = _baseService.Delete(entityId);
            if (rowAffects == 0)
            {
                return NoContent();
            }
            else
                return Ok(rowAffects);
        }
    }
}
