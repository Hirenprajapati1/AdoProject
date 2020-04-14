using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdoProject.Models;
using Microsoft.Data.SqlClient;

namespace AdoProject.Repository
{
    //public class AddEmployee
    //{
    //    public bool Addemp(EmployeeModel st)
    //    {
    //        try
    //        {
    //            SqlConnection sc = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = database1; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

    //            SqlCommand cd = new SqlCommand("AddEmployee1", sc);
    //            cd.CommandType = System.Data.CommandType.StoredProcedure;
    //            cd.Parameters.AddWithValue("@Name", st.Name);
    //            cd.Parameters.AddWithValue("@Designation", st.Designation);
    //            cd.Parameters.AddWithValue("@EmpCode", st.EmpCode);
    //            cd.Parameters.AddWithValue("@Salary", st.Salary);
    //            sc.Open();
    //            bool isExecute = Convert.ToBoolean(cd.ExecuteNonQuery());
    //            sc.Close();
    //            return isExecute;
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //        return true;
    //    }

    //}
}
