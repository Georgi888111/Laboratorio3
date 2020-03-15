<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="estudios.aspx.cs" Inherits="TpSesiones.estudios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Antecedentes educacionales</h2>
        Nivel educativo
        <div id="div1">
            <p>
            <asp:DropDownList runat="server" ID="nivelEstu">
                <asp:ListItem Selected="True" Value="Primario">Primario</asp:ListItem>
                <asp:ListItem Value="Secundario">Secundario</asp:ListItem>
                <asp:ListItem Value="Terciario">Terciario</asp:ListItem>
                <asp:ListItem Value="Universitario">Universitario</asp:ListItem>
            </asp:DropDownList>
            </p>
        </div>
        
        Titulo universitario
        <div id="div2">
          <asp:TextBox ID="titulo" runat="server" Width="188px"></asp:TextBox>
        </div>
        Establecimiento
        <div id="div3">
          <asp:TextBox ID="establecimiento" runat="server" Width="188px"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Siguiente" />
    </form>
</body>
</html>
