using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjHelloWebForms
{
    public partial class CadastroPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            string statusRetorno = "";
            Pessoa p = new Pessoa()
            {
                Id = int.Parse(TxtId.Text),
                Nome = TxtNome.Text,
                Telefone = TxtTelefone.Text
            };
            if (new PessoaService().Insert(p))
            {
                statusRetorno = "Registro Inserido Com Sucesso!";
            }
            else
                statusRetorno = "Erro ao inserir Registro!";
            LblMSG.Text = statusRetorno;
        }

        protected void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}