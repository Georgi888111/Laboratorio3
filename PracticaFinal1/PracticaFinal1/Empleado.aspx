<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" MasterPageFile="~/MasterPageParcial.Master" Inherits="PracticaFinal1.Empleado" %>

<%@ Register Src="~/Dni.ascx" TagPrefix="uc1" TagName="Dni" %>
<%@ Register Src="~/TipoContrato.ascx" TagPrefix="uc1" TagName="TipoContrato" %>
<%@ Register Src="~/Delegacion.ascx" TagPrefix="uc1" TagName="Delegacion" %>
<%@ Register Src="~/Estudios.ascx" TagPrefix="uc1" TagName="Estudios" %>





<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
   <asp:Content runat="server" ID="contenido1" ContentPlaceHolderID="ContentPlaceHolder2">
   <table style="font-family:Verdana; font-size:12px;border-collapse:collapse" border="1">
       <tr>
        <td></td>
           <td style="color:red; font-size:20px">Administrar Empleado</td>
       </tr>
       <tr>
            <td><b>Apellido</b></td>
             <td>
                 <asp:TextBox ID="apellido" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="validaApellido" runat="server" ErrorMessage="El campo apellido es requerido" ControlToValidate="apellido" Text="*"></asp:RequiredFieldValidator>
            </td>
       </tr>
       <tr>
            <td><b>Nombre</b></td>
             <td>
                 <asp:TextBox ID="nombre" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="validaNombre" runat="server" ErrorMessage="El campo nombre es requerido" ControlToValidate="nombre" Text="*"></asp:RequiredFieldValidator>
            </td>
       </tr>
       <tr>
            <td><b>DNI</b></td>
             <td>
                 <uc1:Dni runat="server" id="Dni" />
             </td>
       </tr>
       <tr>
            <td><b>Tipo de contrato</b></td>
             <td>
                 <uc1:TipoContrato runat="server" id="TipoContrato" />
             </td>
       </tr>
       <tr>
            <td><b>Régimen laboral</b></td>
             <td>
                 <asp:DropDownList ID="contrato" runat="server">
                    <asp:ListItem Selected="True" Text="8 a 13" Value="8 a 13"></asp:ListItem>
                    <asp:ListItem Text="8 a 16" Value="8 a 16"></asp:ListItem>
                    <asp:ListItem Text="12 a 20" Value="12 a 20"></asp:ListItem>
                 </asp:DropDownList>
            </td>
       </tr>
       <tr>
            <td><b>Delegacion</b></td>
             <td>
                 <uc1:Delegacion runat="server" id="Delegacion" />
             </td>
       </tr>
       <tr>
            <td><b>Estudios</b></td>
             <td>
                 <uc1:Estudios runat="server" id="Estudios" />
             </td>
       </tr>
       <tr>
            <td><b>Descripcion</b></td>
             <td>
                 <asp:TextBox ID="descripcion" runat="server" TextMode="MultiLine"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="validaDescripcion" runat="server" ErrorMessage="El campo descripcion es requerido" ControlToValidate="descripcion" Text="*"></asp:RequiredFieldValidator>
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
        <asp:ValidationSummary ID="validacionLista" runat="server" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
       </asp:Content>
  
