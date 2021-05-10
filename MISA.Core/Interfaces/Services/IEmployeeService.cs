using MISA.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Interfaces.Services
{
    interface IEmployeeService:IBaseService<Employee>
    {
        /// <summary>
        ///   
        /// </summary>
        /// <param name="EmployeeCode"></param>
        /// <returns></returns>
        /// /// created by NDViet(10/05/2021)
        public string CheckEmployeeCodeExist(string EmployeeCode);

        /// <summary>
        /// lay ra nhân viên theo id
        /// </summary>
        /// <param name="id">id của nhân viên</param>
        /// <returns>thông tin nhân viên theo id</returns>
        /// created by NDViet(10/05/2021)
        public Employee GetEmloyeeById(Guid id);

        /// <summary>
        /// xóa nhân viên theo id
        /// </summary>
        /// <param name="id">id của nhân viên</param>
        /// <returns>danh sách nhân viên sau khi xoa</returns>
        /// /// created by NDViet(10/05/2021)
        public int Delete(Guid id);
        /// <summary>
        /// lấy về mã nhân viên lơn nhất
        /// </summary>
        /// <returns>mã nhân viên lớn nhất</returns>
        /// created by NDViet(10/05/2021)
        public string GetMaxEmployeeCode();

        /// <summary>
        /// thêm mới 1 bản ghi
        /// </summary>
        /// <param name="entity">thực thể cần thêm</param>
        /// <returns>số dòng ghi bị thay đổi</returns>
        /// created by NDViet(10/05/2021)
        public int Insert(Employee entity);

        /// <summary>
        /// sửa bản ghi
        /// </summary>
        /// <param name="id">id của nhân viên cần sửa</param>
        /// <param name="entity">thông tin mới</param>
        /// <return>số dòng bị ảnh hưởng></returns>
        /// created by NDViet(10/05/2021)
        public int Update(Guid id, Employee entity);
    }
}
