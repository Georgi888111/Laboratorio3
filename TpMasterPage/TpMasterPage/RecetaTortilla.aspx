<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RecetaTortilla.aspx.cs" Inherits="TpMasterPage.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="optionTortilla" ContentPlaceHolderID="options" runat="server">
    <form runat="server">
        <div style="margin-left: 10px; margin-bottom:5px">
            <p>Secci&oacute;n Men&uacute</p>
            <asp:Menu runat="server">
                <Items>
                    <asp:MenuItem Text="Receta Tortilla de papas" Value="tortilla"></asp:MenuItem>
                    <asp:MenuItem Text="Receta guiso de Lentejas" Value="lentejas" NavigateUrl="~/RecetaLentejas.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Receta pollo a la portuguesa" Value="pollo" NavigateUrl="~/RecetaPollo.aspx"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </form>
    </asp:Content>
 <asp:Content ID="instruccionesTortilla" ContentPlaceHolderID="content" runat="server">
     <div style="margin-left: 10px">
        <br />
<h2>Ingredientes</h2>
<p>Papa 2 unidades (400 g)</p>
<p>Aceite 30 cc.</p>
<p>Huevos 3 unidades</p>
<p>Cebolla 1 unidad</p>
<p>Sal y pimienta a gusto</p>
 
<h2>Preparación</h2>
<p>Pelá las papas y cortalas en cubos (intentá que queden parejos). Freílos en abundante aceite caliente por 5 minutos y reservalos en una fuente con papel absorvente.</p> 

<p>En un bol colocá los huevos batidos, las papas, la cebolla y la pimienta y la sal</p>

<p>Calentá a fuego fuerte la sartén donde vas a cocinar la tortilla, poné un poco de aceite y luego vertí la preparación.</p>

<p>Cociná 10 minutos hasta que el huevo se cocine bien, dala vuelta y cocinala el mismo tiempo del otro lado.</p>

<p>Colocala en una fuente y servila.</p>



    </div>
</asp:Content>
