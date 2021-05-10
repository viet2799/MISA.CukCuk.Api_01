using MISA.Core.Entity;
using MISA.Core.Interfaces.Responsitories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Infrastructure.Responsitories
{
    class DepartmentResponsitory : BaseReponsitory<Department>, IDepartmentReponsitory
    {
        IEnumerable<Department> IBaseResponsitory<Department>.Get()
        {
            throw new NotImplementedException();
        }
    }
}
