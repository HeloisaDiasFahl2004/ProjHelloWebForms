<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjHelloWebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnProcesssar" runat="server" Height="56px" OnClick="BtnProcesssar_Click" Text="Processar" Width="97px" />
        </div>
        <p>
            <asp:Label ID="LblNome" runat="server" Text="Nome"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TxtNome" runat="server" OnTextChanged="TxtNome_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="LblProcessar" runat="server" Text="Processar"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TxtProcessar" runat="server" Height="16px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
    </form>
</body>
</html>
