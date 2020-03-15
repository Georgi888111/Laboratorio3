<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormProfesor.aspx.cs" Inherits="PracticaFinal6.FormProfesor" %>

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
             <tr><td>Formulario profesor</td></tr>
           <tr>
               <td>
                   <asp:Label ID="Label1" runat="server" Text="Dni"></asp:Label></td>
               <td>
                   <uc1:textDni runat="server" ID="textDni" />
               </td>
           </tr>
           <tr>
              <td> <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label></td>
               <td>
                   <uc1:textNombre runat="server" ID="textNombre" />
               </td>

           </tr>
           <tr>
               <td> <asp:Label ID="Label3" runat="server" Text="Materia"></asp:Label></td>
               <td>
                   <asp:TextBox ID="idMateria" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El campo materia es requerido" Text="*" ControlToValidate="idMateria"></asp:RequiredFieldValidator>
               </td>
           </tr>
         
       </table>
          <asp:Button ID="btnAgregarProf" runat="server" Text="Agregar" OnClick="btnAgregarProf_Click" /><asp:Button ID="btnVolver" runat="server" Text="Volver" />
     
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
