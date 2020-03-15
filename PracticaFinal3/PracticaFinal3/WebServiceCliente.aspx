<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServiceCliente.aspx.cs" Inherits="PracticaFinal3.WebServiceCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
       <asp:Button ID="botonWeb" runat="server" Text="Boton" OnClick="botonWeb_Click" />
            </div>
        <div>

            <asp:Label ID="apellido" runat="server" Text="Apellido"></asp:Label>
            <asp:TextBox ID="textApe" runat="server"></asp:TextBox>
        </div>
        <div>
           
            <asp:Label ID="nombre" runat="server" Text="Nombre"></asp:Label>
              <asp:TextBox ID="textNomb" runat="server"></asp:TextBox>
             </div>
        <div>
            <asp:Label ID="edad" runat="server" Text="Edad"></asp:Label>
              <asp:TextBox ID="textEdad" runat="server"></asp:TextBox>
              </div>
        <div>
            <asp:Label ID="nacionalidad" runat="server" Text="Nacionalidad"></asp:Label>
              <asp:TextBox ID="textNacio" runat="server"></asp:TextBox>
       
         </div>
         <div>
            <asp:Label ID="antecedentes" runat="server" Text="Antecedentes"></asp:Label>
               <asp:TextBox ID="textAntec" runat="server"></asp:TextBox>
       
         </div>
    </form>
    
</body>
</html>
