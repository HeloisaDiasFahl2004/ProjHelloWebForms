using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjHelloWebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnProcesssar_Click(object sender, EventArgs e)
        {
            string nome = TxtNome.Text;
            if (!string.IsNullOrEmpty(nome))
            {
                TxtProcessar.Text = nome.ToUpper();
            }
        }
    }
}