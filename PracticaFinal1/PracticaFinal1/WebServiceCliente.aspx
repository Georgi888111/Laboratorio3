<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServiceCliente.aspx.cs" Inherits="PracticaFinal1.WebServiceCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Valor 1<asp:TextBox ID="valor1" runat="server"></asp:TextBox>
        </div>
        Valor 2<asp:TextBox ID="valor2" runat="server"></asp:TextBox>
        <asp:Button ID="Resolver" runat="server" Text="Resolver" OnClick="Resolver_Click" />
        <div>
        <asp:Label ID="resultado" runat="server" Text="Label"></asp:Label>
            </div>
    </form>
</body>
</html>
