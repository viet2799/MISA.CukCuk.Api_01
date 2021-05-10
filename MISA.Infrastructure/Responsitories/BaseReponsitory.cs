using Dapper;
using MISA.Core.Interfaces.Responsitories;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MISA.Infrastructure.Responsitories
{
    public class BaseReponsitory<T> : IBaseResponsitory<T>
    {
        #region Properties
        protected string _tableName;
        protected string _connectionString;
        protected IDbConnection _dbConnection;
        #endregion

        #region Constructors
        public BaseReponsitory()
        {
            _tableName = typeof(T).Name;
            _connectionString = "" +
                "Host = 47.241.69.179;" +
                "Port = 3306;" +
                "Database = TEST.MISA.AMIS;" +
                "User Id = dev;" +
                "Password = 12345678";
            _dbConnection = new MySqlConnection(_connectionString);
        }
        #endregion
        public IEnumerable<T> Get()
        {
            string storeName = $"Proc_Get{_tableName}s";
            var entities = _dbConnection.Query<T>(storeName, commandType: CommandType.StoredProcedure);
            return entities;
        }
    }
}
