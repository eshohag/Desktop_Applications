using System;
using System.Data.SqlClient;

namespace Taslim.DAL.Gateway
{
    class CommonGateway
    {
        String connectionString = @"server=DESKTOP-AI4OE3P\SQLEXPRESS;database=StudentAttendenceAndPerformanceDb;Integrated Security=True";
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
