using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PessoaRepository
    {
        SqlConnection conn;
        public PessoaRepository()
        {
            conn = ConnectionSQL.GetConnection();
            conn.Open();

        }

        public bool Insert(Pessoa pessoa)
        {
            //Implementação da inclusão dos dados
            string strInsert = "insert into dbo.tb_pessoa (Id, Nome, Telefone) values (@Id, @Nome, @Telefone)";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Id", pessoa.Id));
            commandInsert.Parameters.Add(new SqlParameter("@Nome", pessoa.Nome));
            commandInsert.Parameters.Add(new SqlParameter("@Telefone", pessoa.Telefone));

            //Insere no Banco!
            commandInsert.ExecuteNonQuery();
            return true;
        }
    }
}
