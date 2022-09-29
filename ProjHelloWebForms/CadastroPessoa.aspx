<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroPessoa.aspx.cs" Inherits="ProjHelloWebForms.CadastroPessoa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
            margin-left: 80px;
        }
        .auto-style2 {
            height: 30px;
        }
    </style>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
        <p>
            <table style="width:100%;">
                <tr>
                    <td>
                        <asp:Label ID="LblId" runat="server" Text="Id"></asp:Label>
                        <asp:TextBox ID="TxtId" runat="server" OnTextChanged="TxtNome_TextChanged"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="LblNome" runat="server" Text="Nome"></asp:Label>
                        <asp:TextBox ID="TxtNome" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="margin-left: 200px">&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LblTelefone" runat="server" Text="Telefone"></asp:Label>
                        <asp:TextBox ID="TxtTelefone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" style="margin-bottom: 0px" Text="Salvar" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LblMSG" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </p>
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <div style="margin-left: 80px">
        </div>
    </form>
</body>
</html>
