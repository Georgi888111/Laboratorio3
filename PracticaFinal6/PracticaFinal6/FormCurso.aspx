<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormCurso.aspx.cs" Inherits="PracticaFinal6.FormCurso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <table>
         <tr><td>Formulario curso</td></tr>
          <tr><td><asp:Label ID="Label1" runat="server" Text="Id"></asp:Label></td>
              <td>
                  <asp:TextBox ID="id" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El campo id es obligatorio" Text="*" ControlToValidate="id"></asp:RequiredFieldValidator>
              </td>
          </tr>
         
          <tr><td><asp:Label ID="Label2" runat="server" Text="Division"></asp:Label></td>
              <td>
                  <asp:TextBox ID="idDivision" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="El campo division es obligatorio" Text="*" ControlToValidate="idDivision"></asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr><td><asp:Label ID="Label3" runat="server" Text="Horas"></asp:Label></td>
              <td>
                  <asp:TextBox ID="idHoras" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="El campo horas es obligatorio" Text="*" ControlToValidate="idHoras"></asp:RequiredFieldValidator>
              </td></tr>
     </table>
        <asp:Button ID="idAgregar" runat="server" Text="Agregar" OnClick="idAgregar_Click" />
        <asp:Button ID="idProfesor" runat="server" Text="Agregar Profesor" OnClick="idProfesor_Click" />
        <asp:Button ID="idAlumno" runat="server" Text="Agregar Alumno" OnClick="idAlumno_Click" />
        <asp:Button ID="btnXml" runat="server" Text="Xml" OnClick="btnXml_Click" />
        <asp:Button ID="btnJson" runat="server" Text="Json" OnClick="btnJson_Click" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
