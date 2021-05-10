using MISA.Core.Entity;
using MISA.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Services
{
    class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        public string CheckEmployeeCodeExist(string EmployeeCode)
        {
            throw new NotImplementedException();
        }

        public int Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmloyeeById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string GetMaxEmployeeCode()
        {
            throw new NotImplementedException();
        }

        public int Insert(Employee entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Guid id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
