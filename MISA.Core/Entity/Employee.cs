using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Entity
{
    public class Employee:BaseEntity
    {
        /// <summary>
        /// Id nhân viên
        /// </summary>
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// ngày sinh nhân viên
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// giới tính: 0-nam; 1-nữ; 2-khác
        /// </summary>
        public int? Gender { get; set; }
        /// <summary>
        /// Id của đơn vị nhân viên
        /// </summary>
        public string DepartmentId { get; set; }
        /// <summary>
        /// số chứng minh thư nhân dân/ thẻ căn cước công dân
        /// </summary>
        public string IdentityNumber { get; set; }
        /// <summary>
        /// ngày cấp CMTND/ thẻ căn cước công dân
        /// </summary>
        public DateTime? IdentityDate { get; set; }
        /// <summary>
        /// nơi cấp CMTND/ thẻ căn cước công dân
        /// </summary>
        public string IdentityPlace { get; set; }

        /// <summary>
        /// chức danh nhân viên
        /// </summary>
        public string EmployeePosition { get; set; }

        /// <summary>
        /// địa chỉ nhân viên
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// số tài khoản ngân hàng
        /// </summary>
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// tên ngân hàng
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Tên chi nhánh  ngân hàng
        /// </summary>
        public string BankBranchName { get; set; }
        /// <summary>
        /// Tên tỉnh ngân hàng
        /// </summary>
        public string BankProvinceName { get; set; }
        /// <summary>
        /// số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// số điện thoại cố định
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// email nhân viên
        /// </summary>
        public string Email { get; set; }
    }
}
