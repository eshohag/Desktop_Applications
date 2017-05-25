using System;
using System.Data.SqlClient;

namespace BloodGroupFinderWPF.DAL
{
    public class CommonGateway
    {
        String connectionString = @"server=DESKTOP-H5N8VAJ\SQLEXPRESS;database=BloodGroupFinderDB;Integrated Security=True";
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }
        public string Query { get; set; }


        public CommonGateway()
        {
            Connection = new SqlConnection(connectionString);
            Command = new SqlCommand();
        }
    }
}
