using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Entity
{
    public class BaseEntity
    {
        /// <summary>
        /// NGay tao ban ghi
        /// </summary>
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// người tạo bản ghi
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// ngày sửa bàn ghi
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// NGười sửa bản ghi
        /// </summary>
        public string ModifiedBy { get; set; }
    }
}
