<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmASP.aspx.cs" MasterPageFile="~/masterPage.Master" Inherits="PracticaFinal3.frmASP" %>

<%@ Register Src="~/TextNombre.ascx" TagPrefix="uc1" TagName="TextNombre" %>
<%@ Register Src="~/Nacionalidad.ascx" TagPrefix="uc1" TagName="Nacionalidad" %>
<%@ Register Src="~/Edad.ascx" TagPrefix="uc1" TagName="Edad" %>







<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
   <asp:Content runat="server" ID="contenido1" ContentPlaceHolderID="ContentPlaceHolder2">
    <table border="1" style="font-family:Verdana;font-size:12px" >
        <tr>
            <td>Apellido</td>
             <td>
                 <uc1:TextNombre runat="server" id="apellido" />
             </td>
        </tr>
         <tr>
              <td>Nombre</td>
             <td>
                 <uc1:TextNombre runat="server" id="nombre" />
             </td>
         </tr>
         <tr>
              <td>Sexo</td>
             <td>
                 <asp:RadioButtonList ID="radioSexo" runat="server" RepeatDirection="Horizontal">
                     <asp:ListItem Value="Femenino" Text="Femenino"></asp:ListItem>
                     <asp:ListItem Value="Masculino" Text="Masculino"></asp:ListItem>
                 </asp:RadioButtonList>
                 <asp:RequiredFieldValidator ID="validaSexo" runat="server" ControlToValidate="radioSexo" ErrorMessage="Este campo es requerido">*</asp:RequiredFieldValidator>
              </td>
         </tr>
         <tr>
              <td>Nacionalidad</td>
             <td>
                 <uc1:Nacionalidad runat="server" id="Nacionalidad" />
             </td>
         </tr>
         <tr>
              <td>Bloqueado</td>
             <td>
                 <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Este campo es requerido" OnServerValidate="validaCheck">*</asp:CustomValidator>
                <asp:CheckBox runat="server" ID="checkBloquea"></asp:CheckBox>
              </td>
         </tr>
         <tr>
              <td>Edad</td>
             <td>
                 <uc1:Edad runat="server" id="Edad" />
             </td>
         </tr>
         <tr>
             <td>Antecedentes</td>
             <td>
                 <asp:TextBox ID="textAntecedente" runat="server" TextMode="MultiLine"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textAntecedente" ErrorMessage="Este campo es requerido">*</asp:RequiredFieldValidator>
             </td>
         </tr>
        <tr>
            <td></td>
             <td>
                 <asp:Button ID="boton" runat="server" Text="Guardar" OnClick="boton_Click" />
                 <asp:Button ID="botonSesion" runat="server" Text="Session" OnClick="botonSesion_Click" />
            </td>
        </tr>
    </table>
        <asp:ValidationSummary ID="validaciones" runat="server" />
        <asp:GridView ID="tablaResultados" runat="server">
        </asp:GridView>
       </asp:Content>