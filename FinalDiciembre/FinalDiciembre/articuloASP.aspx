<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="articuloASP.aspx.cs" Inherits="FinalDiciembre.articuloASP" %>

<%@ Register Src="~/CodigoBarra.ascx" TagPrefix="uc1" TagName="CodigoBarra" %>
<%@ Register Src="~/Rubro.ascx" TagPrefix="uc1" TagName="Rubro" %>
<%@ Register Src="~/Vencimiento.ascx" TagPrefix="uc1" TagName="Vencimiento" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div style="font-family:Verdana;font-size:12px">
            <asp:Table ID="Table1" runat="server" Height="439px" Width="751px" BorderStyle="Double">
              <asp:TableRow>
                <asp:TableHeaderCell Text="Administrar Articulo" Font-Bold="true" Font-Size="Medium"></asp:TableHeaderCell>
                <asp:TableCell Text=""></asp:TableCell>
              </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Text="Articulo"></asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="textArt" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Este campo es requerido" ControlToValidate="textArt"></asp:RequiredFieldValidator></asp:TableCell>
                </asp:TableRow>  
                 <asp:TableRow>
                    <asp:TableCell Text="Codigo de Barra"></asp:TableCell>
                     <asp:TableCell>
                         <uc1:CodigoBarra runat="server" id="CodigoBarra" />
                     </asp:TableCell>  
                 </asp:TableRow>    
                 <asp:TableRow>
                      <asp:TableCell Text="Porcentaje Descuento"></asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="textPorcentaje" runat="server" AutoPostBack="true"></asp:TextBox></asp:TableCell>
                 </asp:TableRow>    
                 <asp:TableRow>
                      <asp:TableCell Text="Rubro"></asp:TableCell>
                     <asp:TableCell>
                         <uc1:Rubro runat="server" id="Rubro" />
                     </asp:TableCell>
                 </asp:TableRow>    
                 <asp:TableRow>
                      <asp:TableCell Text="Vencimiento"></asp:TableCell>
                     <asp:TableCell>
                         <uc1:Vencimiento runat="server" id="Vencimiento" />
                     </asp:TableCell>
                 </asp:TableRow>    
                 <asp:TableRow>
                      <asp:TableCell Text="Precio"></asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="textPrecio" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Este campo es requerido" ControlToValidate="textPrecio"></asp:RequiredFieldValidator></asp:TableCell>
                 </asp:TableRow>    
                 <asp:TableRow>
                      <asp:TableCell Text="En Promocion"></asp:TableCell>
                     <asp:TableCell>
                         <asp:CheckBox ID="checkPromo" runat="server" OnCheckedChanged="checkVenci_CheckedChanged" AutoPostBack="true"/></asp:TableCell>
                 </asp:TableRow>    
                 <asp:TableRow>
                      <asp:TableCell  Text=""></asp:TableCell>
                     <asp:TableCell>
                         <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="guardaDatos" /></asp:TableCell>
                 </asp:TableRow>    
                
            </asp:Table>
                </div>
        <div style="font-family:Verdana;font-size:12px">
          <asp:Table ID="Table2" runat="server" Height="439px" Width="751px" BorderStyle="Double">
              <asp:TableRow>
                <asp:TableHeaderCell Text="Administrar Articulo" Font-Bold="true" Font-Size="Medium"></asp:TableHeaderCell>
                <asp:TableCell Text=""></asp:TableCell>
           </asp:TableRow>
              <asp:TableRow>
                  <asp:TableCell Text="Articulo"></asp:TableCell>
                   <asp:TableCell ID="celdaArt"></asp:TableCell>
              </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Text="Codigo Barra"></asp:TableCell>
                   <asp:TableCell ID="celdaBarra"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Text="Porcentaje Descuento"></asp:TableCell>
                   <asp:TableCell ID="celdaDescuento"></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell Text="Rubro"></asp:TableCell>
                   <asp:TableCell ID="celdaRubro"></asp:TableCell>
                </asp:TableRow>
              <asp:TableRow>
                  <asp:TableCell Text="Vencimiento"></asp:TableCell>
                   <asp:TableCell ID="celdaVencimiento"></asp:TableCell>
              </asp:TableRow>
              <asp:TableRow>
                  <asp:TableCell Text="Precio"></asp:TableCell>
                   <asp:TableCell ID="celdaPrecio"></asp:TableCell>
              </asp:TableRow>
              <asp:TableRow>
                  <asp:TableCell Text="En promocion"></asp:TableCell>
                   <asp:TableCell ID="celdaPromo"></asp:TableCell>
              </asp:TableRow>


        </asp:Table>
            </div>
    </form>
</body>
</html>
