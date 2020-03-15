<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Formulario web1.aspx.cs" Inherits="FinalDiciembre.Formulario_web1" %>

<%@ Register Src="~/CodigoBarra.ascx" TagPrefix="uc1" TagName="CodigoBarra" %>
<%@ Register Src="~/Rubro.ascx" TagPrefix="uc1" TagName="Rubro" %>
<%@ Register Src="~/Vencimiento.ascx" TagPrefix="uc1" TagName="Vencimiento" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Button ID="verForm" runat="server" Text="Ver Solo Formulario" OnClick="verForm_Click"  />
               <asp:Button ID="verTabla" runat="server" Text="Ver Solo Tabla" OnClick="verTabla_Click"/>  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
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
                         <uc1:CodigoBarra runat="server" ID="CodigoBarra" />
                     </asp:TableCell>  
                 </asp:TableRow>    
                 <asp:TableRow>
                      <asp:TableCell Text="Porcentaje Descuento"></asp:TableCell>
                     <asp:TableCell>
                         <asp:TextBox ID="textPorcentaje" runat="server"></asp:TextBox></asp:TableCell>
                 </asp:TableRow>    
                 <asp:TableRow>
                      <asp:TableCell Text="Rubro"></asp:TableCell>
                     <asp:TableCell>
                         <uc1:Rubro runat="server" ID="Rubro" />
                     </asp:TableCell>
                 </asp:TableRow>    
                 <asp:TableRow>
                      <asp:TableCell Text="Vencimiento"></asp:TableCell>
                     <asp:TableCell>
                         <uc1:Vencimiento runat="server" ID="Vencimiento" />
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
                         <asp:CheckBox ID="checkPromo" runat="server" OnCheckedChanged="checkVenci_CheckedChanged"/></asp:TableCell>
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
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
