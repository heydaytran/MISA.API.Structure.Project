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
        public int Delete(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public MISAEntity GetById(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<MISAEntity> GetEntities()
        {
            throw new NotImplementedException();
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
