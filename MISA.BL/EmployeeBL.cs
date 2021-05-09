using MISA.BL.Exceptions;
using MISA.Common.Entities;
using MISA.DL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MISA.BL
{
    public class EmployeeBL:BaseBL
    {
        ///// <summary>
        ///// Láy toàn bộ danh sách khách hàng
        ///// </summary>
        ///// <returns>Danh sách khách hàng</returns>
        ///// CreatedBy: NVMANH (16/04/2021)
        //public IEnumerable<Customer> GetAll()
        //{
        //    CustomerDL customerDL = new CustomerDL();
        //    var customers = customerDL.GetAll<Customer>();
        //    return customers;
        //}

        //public Customer GetCustomerById(Guid Id) {
        //    CustomerDL customerDL = new CustomerDL();
        //    var customer = customerDL.GetById<Customer>(Id);
        //    return customer;
        //}


        //public int InsertCustomer(Customer customer)
        //{
        //    CustomerDL customerDL = new CustomerDL();
        //    // Validate dữ liệu:
        //    // 1. Đã nhập mã hay chưa? nếu chưa nhập thì đưa ra cảnh báo lỗi:
        //    if (string.IsNullOrEmpty(customer.CustomerCode))
        //    {
        //        throw new GuardException("Mã khách hàng không được phép để trống.", customer);
        //    }
        //    // 2. Check mã khách hàng đã tồn tại hay chưa?
        //    var isExists = customerDL.CheckCustomerCodeExist(customer.CustomerCode);
        //    if (isExists== true)
        //    {
        //        throw new GuardException("Mã khách hàng đã tồn tạo trong hệ thống, vui lòng kiểm tra lại", null);
        //    }

        //    // 3. Kiểm tra Email có đúng định dạng hay không?
        //    var emailTemplate = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
        //    if (!Regex.IsMatch(customer.Email,emailTemplate))
        //    {
        //        throw new GuardException("Email không đúng định dạng, vui lòng kiểm tra lại", null);
        //    }
        //    // Thực hiện lấy dữ liệu:

        //    return customerDL.Insert<Customer>(customer);
        //}

        //public int UpdateCustomer(Customer customer, Guid customerId)
        //{
        //    CustomerDL customerDL = new CustomerDL();
        //    return customerDL.Update<Customer>(customer,customerId);
        //}

        //public int DeleteCustomer(Guid customerId)
        //{
        //    return 0;
        //}

        protected override void Validate<MISAEntity>(MISAEntity entity)
        {
            if (entity is Employee)
            {
                var employee = entity as Employee;
                EmployeeDL employeeDL = new EmployeeDL();
                // Validate dữ liệu:
                // 1. Đã nhập mã hay chưa? nếu chưa nhập thì đưa ra cảnh báo lỗi:
                if (string.IsNullOrEmpty(employee.EmployeeCode))
                {
                    throw new GuardException<Employee>("Mã nhân viên không được phép để trống.", employee);
                }
                // 2. Check mã khách hàng đã tồn tại hay chưa?
                var isExists = employeeDL.CheckEmployeeCodeExist(employee.EmployeeCode);
                if (isExists == true)
                {
                    throw new GuardException<Employee>("Mã nhân viên đã tồn tạo trong hệ thống, vui lòng kiểm tra lại", null);
                }

                // 3. Kiểm tra Email có đúng định dạng hay không?
                var emailTemplate = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
                if (!Regex.IsMatch(employee.Email, emailTemplate))
                {
                    throw new GuardException<Employee>("Email không đúng định dạng, vui lòng kiểm tra lại", null);
                }
            }
        }
    }
}
