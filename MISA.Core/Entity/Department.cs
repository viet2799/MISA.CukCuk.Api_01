using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Entity
{
    public class Department:BaseEntity
    {
        /// <summary>
        /// id của phòng ban
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// tên phòng ban
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// mô tả bộ phận
        /// </summary>
        public string Description { get; set; }

    }
}
