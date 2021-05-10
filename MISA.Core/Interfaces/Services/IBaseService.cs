using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Interfaces.Services
{
    public interface IBaseService<T>
    {
        public IEnumerable<T> Get();
    }
}
