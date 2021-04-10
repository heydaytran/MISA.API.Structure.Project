using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Core.Entities
{
    public class BaseEntity
    {
        public DateTime? CreateDate { set; get; }
        public string CreateBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
