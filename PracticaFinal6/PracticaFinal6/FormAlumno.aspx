<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormAlumno.aspx.cs" Inherits="PracticaFinal6.FormAlumno" %>

<%@ Register Src="~/textDni.ascx" TagPrefix="uc1" TagName="textDni" %>
<%@ Register Src="~/textNombre.ascx" TagPrefix="uc1" TagName="textNombre" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <table>
         <tr><td>Formulario alumno</td></tr>
         <tr>
             <td>  <asp:Label ID="Label1" runat="server" Text="Dni"></asp:Label></td>
           
             <td>
                 <uc1:textDni runat="server" id="textDni" />
             </td>
         </tr>
         <tr>
             <td><asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label></td>
             <td>
                 <uc1:textNombre runat="server" id="textNombre" />
             </td>
         </tr>
         <tr>
             <td><asp:Label ID="Label3" runat="server" Text="Año"></asp:Label></td>
             <td><asp:TextBox TextMode="Number" runat="server" ID="idAño"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El campo año es requerido" ControlToValidate="idAño" Text="*"></asp:RequiredFieldValidator>
             </td>
         </tr>
       
       
    </table>
         <asp:Button ID="btnAgregarAlu" runat="server" Text="Agregar" OnClick="btnAgregarAlu_Click" /><asp:Button ID="btnVolver" runat="server" Text="Volver" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
