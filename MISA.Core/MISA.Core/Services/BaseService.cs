using MISA.Core.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Services
{
    // service là nơi thực thi những công việc của interface giao
    // BaseService thực hiện những công việc chung của base interface(IBaseService)
    public class BaseService<MISAEntity> : IBaseService<MISAEntity>
    {
        IBaseRepository<MISAEntity> _baseRepository;
        public BaseService(IBaseRepository<MISAEntity> baseRepository)
        {
            _baseRepository = baseRepository; 
        }

        public int Delete(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public MISAEntity GetById(Guid entityId)
        {
            return _baseRepository.GetById(entityId);
            
        }

        public IEnumerable<MISAEntity> GetEntities()
        {
            var entities = _baseRepository.GetEntities();
            return entities;

        }

        public int Insert(MISAEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(MISAEntity entity, Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}
