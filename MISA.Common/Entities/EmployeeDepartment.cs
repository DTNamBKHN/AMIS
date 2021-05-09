using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Entities
{
    public class EmployeeDepartment
    {
        public Guid EmployeeDepartmentId { get; set; }
        public string EmployeeDepartmentCode { get; set; }
        public string EmployeeDepartmentName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
