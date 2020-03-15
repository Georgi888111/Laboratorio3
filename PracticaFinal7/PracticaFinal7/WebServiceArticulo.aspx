<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServiceArticulo.aspx.cs" Inherits="PracticaFinal7.WebServiceArticulo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <table>
           <tr>
               <td><label>Codigo</label></td>
               <td>
                   <asp:TextBox ID="textCodigo" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
                <td><label>Denominacion</label></td>
               <td> <asp:TextBox ID="textDenom" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><label>Tiene Vencimiento</label></td>
               <td> <asp:TextBox ID="textTieneVenc" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><label>Fecha Vencimiento</label></td>
               <td> <asp:TextBox ID="textVenci" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><label>Unidad de Medida</label></td>
               <td> <asp:TextBox ID="textMedida" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><label>Tipo Codigo</label></td>
               <td> <asp:TextBox ID="textTipoCod" runat="server"></asp:TextBox></td>
            </tr>
       </table>
        <asp:Button ID="Button1" runat="server" Text="Mostrar" OnClick="Button1_Click" />
    </form>
</body>
</html>
