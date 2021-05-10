using MISA.Core.Entity;
using MISA.Core.Interfaces.Responsitories;
using MISA.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Services
{
    public class DepartmentService : BaseService<Department>, IDepartmentRespository
    {
        IDepartmentResponsitory<Department> _baseDepartmentService;
        public DepartmentService(IBaseResponsitory<Department> baseRepository) : base(baseRepository)
        {
        }
    }
}
