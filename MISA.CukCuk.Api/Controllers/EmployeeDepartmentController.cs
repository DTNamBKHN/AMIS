using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.BL;
using MISA.BL.Exceptions;
using MISA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.Api.Controllers
{
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class EmployeeDepartmentController : ControllerBase
    {
        // GET: api/<CustomerController>
        [HttpGet]
        public IActionResult Get()
        {
            EmployeeDepartmentBL employeeDepartmentBL =  new EmployeeDepartmentBL();
            var employeeDepartments = employeeDepartmentBL.GetAll<EmployeeDepartment>();
            // 4. Kiểm tra dữ liệu và trả về cho Client
            // - Nếu có dữ liệu thì trả về 200 kèm theo dữ liệu
            // - Không có dữ liệu thì trả về 204:
            if (employeeDepartments.Count() > 0)
            {
                return Ok(employeeDepartments);
            }
            else
            {
                return NoContent();
            }

        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            EmployeeDepartmentBL employeeDepartmentBL = new EmployeeDepartmentBL();
            var employeeDepartment = employeeDepartmentBL.GetById<EmployeeDepartment>(id);
            // 4. Trả về cho Client:
            if (employeeDepartment != null)
            {
                return Ok(employeeDepartment);
            }
            else
            {
                return NoContent();
            }
        }


        // POST api/<CustomerController>
        [HttpPost]
        public IActionResult Post([FromBody] EmployeeDepartment employeeDepartment)
        {
            try
            {

                EmployeeDepartmentBL employeeDepartmentBL = new EmployeeDepartmentBL();
                var rowAffects = employeeDepartmentBL.Insert(employeeDepartment);
                // 4. Trả về cho Client:
                if (rowAffects > 0)
                {
                    return Ok();
                }
                else
                {
                    return NoContent();
                }
            }
            catch (GuardException<EmployeeDepartment> ex)
            {
                var mes = new
                {
                    devMsg = ex.Message,
                    userMsg = "Dữ liệu không hợp lệ, vui lòng kiểm tra lại!",
                    field = "EmployeeDepartmentCode",
                    data = ex.Data
                };
                return StatusCode(400, mes);
            }
            catch (Exception ex)
            {

                var mes = new
                {
                    devMsg = ex.Message,
                    userMsg = "Có lỗi xảy ra, vui lòng liên hệ MISA để được trợ giúp",
                    field = "EmployeeDepartmentCode"
                };
                return StatusCode(500, mes);
            }

        }
    }
}
