<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="trabajos.aspx.cs" Inherits="TpSesiones.trabajos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Experiencia Laboral</h2>
        Periodo de ocupación
        <div id="div1">
         <asp:TextBox ID="periodo" runat="server" Width="188px"></asp:TextBox>
        </div>
        Lugar de trabajo
        <div id="div2">
         <asp:TextBox ID="lugar" runat="server" Width="188px"></asp:TextBox>
        </div>
         Tarea desempeñada
         <div id="div3">
         <asp:TextBox ID="tarea" runat="server" Width="188px"></asp:TextBox>
        </div>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Siguiente" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
