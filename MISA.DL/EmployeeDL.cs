using MISA.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dapper;
using MySqlConnector;
using System.Linq;

namespace MISA.DL
{
    public class EmployeeDL:BaseDL
    {
      

        //public Customer GetCustomerById(Guid customerId)
        //{

        //    using (_dbConnection = new MySqlConnection(_connectionString))
        //    {
        //        // 3. Thực thi lệnh lấy dữ liệu trong Database:
        //        var sqlCommand = $"SELECT * FROM Customer WHERE CustomerId = '{customerId.ToString()}'";
        //        var customer = _dbConnection.QueryFirstOrDefault<Customer>(sqlCommand);
        //        return customer;
        //    }
           
        //}

        //public int InsertCustomer(Customer customer)
        //{
        //    using (_dbConnection = new MySqlConnection(_connectionString))
        //    {
        //        // 3. Thực thi lệnh lấy dữ liệu trong Database:
        //        var sqlCommand = $"Proc_InsertCustomer";
        //        var rowAffects = _dbConnection.Execute(sqlCommand, param: customer, commandType: CommandType.StoredProcedure);
        //        return rowAffects;
        //    }

        //}

        //public int UpdateCustomer(Customer customer)
        //{
        //    return 0;
        //}

        //public int DeleteCustomer(Customer customer)
        //{
        //    return 0;
        //}

        public bool CheckEmployeeCodeExist(string employeeCode)
        {
            using (_dbConnection = new MySqlConnection(_connectionString))
            {
                // 3. Thực thi lệnh lấy dữ liệu trong Database:
                var sqlCommand = $"Proc_CheckEmployeeCodeExists";
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@m_EmployeeCode", employeeCode);
                var res = _dbConnection.ExecuteScalar<bool>(sqlCommand, dynamicParameters, commandType: CommandType.StoredProcedure);
                return res;
            }
        }
    }
}
