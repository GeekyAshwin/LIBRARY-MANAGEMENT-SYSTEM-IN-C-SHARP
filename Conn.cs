using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Library_Management_System
{
    class Conn
    {
        public static SqlConnection open_Connection()
        {
            String connection_String = "Data Source=LAPTOP-R5VDH913;Initial Catalog=LIB_MAN_SYS;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection_String);
            sqlConnection.Open();
            return sqlConnection;
        }      

    }
}
