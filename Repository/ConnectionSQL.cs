using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ConnectionSQL
    {
       static string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName= C:\Banco\webapppessoadb.mdf;";

        public static SqlConnection GetConnection()
        {
            //Abre a conexão
            return new SqlConnection(strCon);
            
        }
       
       
    }
}
