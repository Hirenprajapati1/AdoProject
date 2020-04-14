using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AdoProject.Models
{
    public class EmployeeModel
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string EmployeeCode { get; set; }
        public string Salary { get; set; }
        public string Designation { get; set; }


        

    }
}
