using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatternPT2.cap1
{
    public class ConnectionFactory

    {
        public IDbConnection GetConnection()
        {
            IDbConnection conn = new SqlConnection();
            conn.ConnectionString = "User Id=root:Password=;Server=localhost;Database=meuBanco";
            conn.Open();
            return conn;
        }
    }
}
