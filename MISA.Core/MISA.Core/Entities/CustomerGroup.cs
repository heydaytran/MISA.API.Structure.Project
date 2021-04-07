using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Entities
{
    /// <summary>
    /// Thông tin nhóm khách hàng
    /// Create by :TVTHINH  
    /// </summary>
    public class CustomerGroup:BaseEntity
    {
        public Guid CustomerGroupId { get; set; }

        public string CustomerGroupName { get; set; }

        public string Description { get; set; }

        public Guid? ParentId { get; set; }

    }
}
