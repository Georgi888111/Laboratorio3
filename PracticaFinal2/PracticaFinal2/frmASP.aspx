<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmASP.aspx.cs" Inherits="PracticaFinal2.frmASP" %>

<%@ Register Src="~/DominioPatente.ascx" TagPrefix="uc1" TagName="DominioPatente" %>
<%@ Register Src="~/Combustible.ascx" TagPrefix="uc1" TagName="Combustible" %>
<%@ Register Src="~/Equipamiento.ascx" TagPrefix="uc1" TagName="Equipamiento" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <table style="font-family:Verdana;font-size:12px">
        
            <tr>
                <td></td>
                 <td style="font-size:20px">Administrar vehiculo</td>
            </tr>
            <tr>
                 <td><b>Tipo de vehiculo</b></td>
                 <td>
                     <asp:DropDownList ID="tipoVehiculo" runat="server">
                         <asp:ListItem Value="Auto" Text="Auto"></asp:ListItem>
                          <asp:ListItem Value="Moto" Text="Moto"></asp:ListItem>
                     </asp:DropDownList>
                 </td>
            </tr>
            <tr>
                 <td><b>Marca</b></td>
                 <td>
                     <asp:TextBox ID="textMarca" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="textMarca" ErrorMessage="La marca es requerida">*</asp:RequiredFieldValidator>
                 </td>
            </tr>
            <tr>
                 <td><b>Modelo</b></td>
                 <td>
                     <asp:TextBox ID="textModelo" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textModelo" ErrorMessage="El modelo es requerido">*</asp:RequiredFieldValidator>
                 </td>
            </tr>
            <tr>
                 <td><b>Modelo/Patente</b></td>
                 <td>
                     <uc1:DominioPatente runat="server" id="DominioPatente" />
                 </td>
            </tr>
            <tr>
                 <td><b>Combustible</b></td>
                 <td><uc1:Combustible runat="server" id="Combustible"/>
                </td>
            </tr>
            <tr>
                 <td><b>Nuevo/Usado</b></td>
                 <td>
               
                     
                     <asp:RadioButtonList ID="radioUso" runat="server" AutoPostBack="true">
                         <asp:ListItem Value="Usado" Text="Usado" Selected="True"></asp:ListItem>
                          <asp:ListItem Value="Nuevo" Text="Nuevo"></asp:ListItem>
                     </asp:RadioButtonList>
               </td>
            </tr>
            <tr>
                 <td><b>Equipamiento</b></td>
                 <td>
                    
                     <uc1:Equipamiento ID="Equipamiento1" runat="server" />
                    
                 </td>
            </tr>
            <tr> <td><b>Descripcion</b></td>
                 <td><asp:TextBox ID ="textDescrip" TextMode="MultiLine" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textDescrip" ErrorMessage="La descripcion es requerida">*</asp:RequiredFieldValidator>
                </td></tr>
          <tr>

              <td></td>
              <td>
                  <asp:Button ID="btnGuarda" runat="server" Text="Guardar" OnClick="btnGuarda_Click" />
              </td>
          </tr>          
       </table>
        <asp:ValidationSummary ID="validaLista" runat="server" />
        <asp:Table ID="tabla" runat="server" BorderWidth="2">
            <asp:TableHeaderRow>
                <asp:TableHeaderCell>Campos</asp:TableHeaderCell>
                <asp:TableHeaderCell>Informacion</asp:TableHeaderCell>
            </asp:TableHeaderRow>
             
        </asp:Table>
    </form>
</body>
</html>
