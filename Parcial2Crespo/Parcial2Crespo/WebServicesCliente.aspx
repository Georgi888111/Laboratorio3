<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServicesCliente.aspx.cs" Inherits="Parcial2Crespo.WebServicesCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Valor1<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
        Valor 2<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Calcular" OnClick="Button1_Click" />
        </p>
        <asp:Label ID="resultado" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
