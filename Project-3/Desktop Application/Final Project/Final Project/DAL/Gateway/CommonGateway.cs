

using System;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    public class CommonGateway
    {
        String connectionString = @"server=DESKTOP-AI4OE3P\SQLEXPRESS;database=DiagnosesCenterDB;Integrated Security=True";
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
