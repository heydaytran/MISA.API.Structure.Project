using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Entities
{
    /// <summary>
    /// Thông tin khách hàng
    /// createBy: TVTHINH
    /// </summary>
    public class Customer:BaseEntity
    {
        /// <summary>
        /// khóa chính(Key) - ID khách hàng 
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Mã khách hàng
        /// </summary>
        public string CustomerCode { get; set; }

        /// <summary>
        /// Họ tên khách hàng
        /// </summary>
        public string FullName{ get; set; }

        /// <summary>
        /// ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Giới tính
        /// </summary>
        public int? Gender { get; set; }

        /// <summary>
        /// Mã thẻ thành viên
        /// </summary>
        public string MemberCardCode { get; set; }

        /// <summary>
        /// Khóa ngoại(FK) -Nhóm khách hàng 
        /// </summary>
        public Guid? CustomerGroupId { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Tên công ty
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Mã số thuế công ty
        /// </summary>
        public string CompanyTaxCode { get; set; }

        /// <summary>
        /// Email khách hàng
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Địa chỉ khách hàng
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        public string Note { get; set; }



    }
}
