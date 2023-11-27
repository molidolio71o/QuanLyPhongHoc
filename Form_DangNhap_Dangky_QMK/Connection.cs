using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Form_DangNhap_Dangky_QMK
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=LAPTOP-PP2SQ4N0\MSSQLSERVER01;Initial Catalog=QL_PH;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
