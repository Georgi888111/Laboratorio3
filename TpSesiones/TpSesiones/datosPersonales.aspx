<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datosPersonales.aspx.cs" Inherits="TpSesiones.datosPersonales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Datos personales</h2>
        Nombre
        <div id="div1">
        <asp:TextBox ID="nombre" runat="server" Width="188px"></asp:TextBox>
        </div>
        Apellido
        <div id="div2">
        <asp:TextBox ID="apellido" runat="server" Width="188px"></asp:TextBox>
        </div>
        DNI
         <div id="div3">
        <asp:TextBox ID="dni" runat="server" Width="188px" TextMode="Number"></asp:TextBox>
        </div>
        Domicilio
        <div id="div4">
        <asp:TextBox ID="domicilio" runat="server" Width="188px"></asp:TextBox>
        </div>
        Nacionalidad
        <div id="div5">
        <asp:TextBox ID="nacionalidad" runat="server" Width="188px"></asp:TextBox>
        </div>
        Sexo
        <div id="div6">
        <asp:RadioButtonList ID="sexo" runat="server">
        <asp:ListItem Text="Femenino" Value="Femenino" />
        <asp:ListItem Text="Masculino" Value="Masculino" />
        <asp:ListItem Text="Otro" Value="Otro" />
</asp:RadioButtonList>
        </div>
         Fecha de Nacimiento
        <div id="div7">
        <asp:TextBox runat="server" ID="fechaNac" TextMode="Date"></asp:TextBox>
        </div>
       <div id="div8">
        <p>
            <asp:Button ID="Button1" runat="server" Text="Siguiente" OnClick="Button1_Click" />
        </p>
       </div>
    </form>
</body>
</html>
