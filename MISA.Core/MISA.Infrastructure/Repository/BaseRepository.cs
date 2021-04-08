using Dapper;
using MISA.Core.Intefaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MISA.Infrastructure.Repository
{
    public class BaseRepository<MISAEntity> : IBaseRepository<MISAEntity>
    {
        protected string _tableName = string.Empty;
        protected string _connectionString = "" + "Host=47.241.69.179;" +
            "Port=3306;" +
            "User Id=dev;" +
            "Password=12345678;" +
            "Database=MF0_NVManh_CukCuk02; convert zero datetime=True;";
        protected IDbConnection _dbConnection;

        //  khởi tạo đối tượng đồng thời khởi tạo kết nối tới database
        public BaseRepository()
        {
            _tableName = typeof(MISAEntity).Name;
            _dbConnection = new MySqlConnection(_connectionString);
        }

        public int Delete(Guid entityId)
        {
            throw new NotImplementedException();
        }

        public MISAEntity GetById(Guid entityId)
        {
            var storname = $"Proc_Get{_tableName}ById";
            int dem, dem1;
            for( int i = 0; i<100; i++)
            {
                dem = i;
                dem1 = i + 1;
            }    
            DynamicParameters dynamicParameters = new DynamicParameters();
            var storeGetByIdInputParamName = $"@{_tableName}Id";
            dynamicParameters.Add(storeGetByIdInputParamName, entityId);
            var entity = _dbConnection.Query<MISAEntity>(storname, param: dynamicParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return entity;
        }

        public IEnumerable<MISAEntity> GetEntities()
        {
            var storname = $"Proc_Get{_tableName}s";
           
            var entities = _dbConnection.Query<MISAEntity>(storname, commandType: CommandType.StoredProcedure);
            return entities;
        }
        
        public int Insert(MISAEntity entity)
        {
            var storeName = $"Proc_Insert{_tableName}";
            var storeParam = entity;
            var rowAffects = _dbConnection.Execute(storeName, param: storeParam, commandType: CommandType.StoredProcedure);
           
            return rowAffects;
        }

        public int Update(MISAEntity entity, Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}
