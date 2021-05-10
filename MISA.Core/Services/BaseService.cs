using MISA.Core.Interfaces.Responsitories;
using MISA.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Services
{
    class BaseService<T> : IBaseService<T>
    {

        IBaseResponsitory<T> _baseRepository;
        public BaseService(IBaseResponsitory<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }
    }
}
