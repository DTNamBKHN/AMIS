using MISA.BL.Exceptions;
using MISA.Common.Entities;
using MISA.DL;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BL
{
    public class EmployeeDepartmentBL : BaseBL
    {
        protected override void Validate<MISAEntity>(MISAEntity entity)
        {
            throw new GuardException<EmployeeDepartment>("O zê", entity as EmployeeDepartment);
        }


    }
}
