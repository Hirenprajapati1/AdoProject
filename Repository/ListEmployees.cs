using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AdoProject.Models;
using Microsoft.Data.SqlClient;

namespace AdoProject.Repository
{
    //public class ListEmployees
    //{

    //    public List<EmployeeModel> Getemp()
    //    {
    //        SqlConnection sc = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = database1; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
    //        List<EmployeeModel> s2 = new List<EmployeeModel>();

    //        SqlDataAdapter sa = new SqlDataAdapter("GetEmployee", sc);
    //        DataTable dt = new DataTable();
    //        sa.SelectCommand.CommandType = CommandType.StoredProcedure;
    //        sc.Open();
    //        sa.Fill(dt);
    //        sc.Close();
    //        foreach (DataRow dr in dt.Rows)
    //        {
    //            s2.Add(
    //                new EmployeeModel
    //                {
    //                    ID = Convert.ToInt32(dr["ID"]),
    //                    Name = Convert.ToString(dr["Name"]),
    //                    Designation = Convert.ToString(dr["Designation"]),
    //                    EmpCode = Convert.ToString(dr["EmpCode"]),
    //                    Salary = Convert.ToString(dr["Salary"]),
    //                }
    //                );
    //        }
    //        return s2;
    //    }

    //}
}
