<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="PracticaParcialFinal.Ingreso" %>
<%@ Register Src="~/textBoxNoVacio.ascx" TagPrefix="uc" TagName="TextBoxNoEmpty" %>
<%@ Register Src="~/cuit.ascx" TagPrefix="uc" TagName="TextCuit" %>
<%@ Register Src="~/validaContraseña.ascx" TagPrefix="uc" TagName="validaContraseña" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ingresaste</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
 <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
       <div>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
       </div>
        <div>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <uc:TextBoxNoEmpty runat="server" ID="cajaTexto"/>
        </div>
   
        <div>
            <uc:validaContraseña runat="server" ID="TextBoxNoEmpty1"/>
        </div>
     
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
