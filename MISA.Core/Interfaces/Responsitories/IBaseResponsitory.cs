using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Interfaces.Responsitories
{
    public interface IBaseResponsitory<T>
    {
        public IEnumerable<T> Get();
    }
}
