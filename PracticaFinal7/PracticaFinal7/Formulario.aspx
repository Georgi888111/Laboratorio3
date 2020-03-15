<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" MasterPageFile="~/PaginaMaestra.Master" Inherits="PracticaFinal7.Formulario" %>

<%@ Register Src="~/textFecha.ascx" TagPrefix="uc1" TagName="textFecha" %>
<%@ Register Src="~/unidadMedida.ascx" TagPrefix="uc1" TagName="unidadMedida" %>
<%@ Register Src="~/tipoBarra.ascx" TagPrefix="uc1" TagName="tipoBarra" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
 <asp:Content runat="server" ID="contenido1" ContentPlaceHolderID="ContentPlaceHolder2">
     
<table style="font-family:Verdana;font-size:12px" id="formularioCarga">
           <tr><td style="font-size:20px">Alta Articulo Inventario</td></tr>
           <tr>
               <td>
                   <asp:Label ID="Label1" runat="server" Text="Código Articulo"></asp:Label></td>
                <td>
                    <asp:TextBox ID="codigo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe ingresar el codigo" ControlToValidate="codigo"></asp:RequiredFieldValidator>
               </td>
           </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Denominacion"></asp:Label></td>
                <td>
                    <asp:TextBox ID="denominacion" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe ingresar la denominación" ControlToValidate="denominacion"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Tiene Vencimiento"></asp:Label></td>
                <td>
                    <asp:CheckBox runat="server" ID="checkVenci" OnCheckedChanged="checkVenci_CheckedChanged"/></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label4" runat="server" Text="Fecha Vencimiento"></asp:Label></td>
                <td>
                    <uc1:textFecha runat="server" id="textFecha" />
                    <asp:CustomValidator ID="valida1" runat="server" ErrorMessage="CustomValidator"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="Label5" runat="server" Text="Unidad de Medida"></asp:Label></td>
                <td>
                   <uc1:unidadMedida runat="server" id="unidadMedida" />
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="Label6" runat="server" Text="Tipo Codigo Barra"></asp:Label></td>
                <td>
                    <uc1:tipoBarra runat="server" id="tipoBarra" />
                </td>
            </tr>
            <tr>
                <td>
                   
                </td>
                <td>
                    <asp:Button ID="btnGuarda" runat="server" Text="Guardar" OnClick="btnGuarda_Click"/>
                    <asp:Button ID="btnSesion" runat="server" Text="Session" OnClick="btnSesion_Click" />
                </td>
            </tr>
       </table>
     </asp:Content>
 <asp:Content runat="server" ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3">
        <asp:Table ID="tabla" runat="server">
            <asp:TableRow>
                <asp:TableHeaderCell Text="Datos Cargados"></asp:TableHeaderCell>
                <asp:TableCell Text=""></asp:TableCell>
            </asp:TableRow>
             <asp:TableRow>
                  <asp:TableCell Text="Codigo Articulo"></asp:TableCell>
                 <asp:TableCell Text="" ID="celdaCodigo"></asp:TableCell>
             </asp:TableRow>
             <asp:TableRow>
                   <asp:TableCell Text="Denominacion"></asp:TableCell>
                 <asp:TableCell Text="" ID="celdaDenominacion"></asp:TableCell>
             </asp:TableRow>
             <asp:TableRow>
                   <asp:TableCell Text="Tiene Vencimiento"></asp:TableCell>
                 <asp:TableCell Text="" ID="CeldaTieneVenci"></asp:TableCell>
             </asp:TableRow>
             <asp:TableRow>
                   <asp:TableCell Text="Fecha Vencimiento"></asp:TableCell>
                 <asp:TableCell ID="celdaVencimiento"></asp:TableCell>
             </asp:TableRow>
             <asp:TableRow>
                   <asp:TableCell Text="Unidad de Medida"></asp:TableCell>
                 <asp:TableCell Text="" ID="celdaUnidad"></asp:TableCell>
             </asp:TableRow>
             <asp:TableRow>
                   <asp:TableCell Text="Tipo Codigo de Barra"></asp:TableCell>
                 <asp:TableCell Text="" ID="celdaCodigoBarra"></asp:TableCell>
             </asp:TableRow>
        </asp:Table>
        <asp:BulletedList ID="lista" runat="server">
            
        </asp:BulletedList>
    </asp:Content>


