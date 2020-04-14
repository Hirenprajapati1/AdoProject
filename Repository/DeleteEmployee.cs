using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AdoProject.Models;
using Microsoft.Data.SqlClient;

namespace AdoProject.Repository
{
    public class DeleteEmployee
    {
        //public bool DeleteEmployee(int ID)
        //{
        //    SqlConnection sc = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = database1; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        //    SqlCommand cd = new SqlCommand("DeleteEmployee", sc);
        //    cd.CommandType = CommandType.StoredProcedure;
        //    cd.Parameters.AddWithValue("@ID", ID);
        //    sc.Open();
        //    int isExecute = cd.ExecuteNonQuery();
        //    sc.Close();
        //    if (isExecute > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }


        //}


    }
}
