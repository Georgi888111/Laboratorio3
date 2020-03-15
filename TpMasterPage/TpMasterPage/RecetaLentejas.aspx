<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RecetaLentejas.aspx.cs" Inherits="TpMasterPage.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="optionLentejas" ContentPlaceHolderID="options" runat="server">
    <form runat="server">
        <div style="margin-left: 10px; margin-bottom:5px">
            <p>Secci&oacute;n Men&uacute</p>
            <asp:Menu runat="server">
                <Items>
                    <asp:MenuItem Text="Receta Tortilla de papas" Value="tortilla" NavigateUrl="~/RecetaTortilla.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Receta guiso de Lentejas" Value="lentejas"></asp:MenuItem>
                    <asp:MenuItem Text="Receta pollo a la portuguesa" Value="pollo" NavigateUrl="~/RecetaPollo.aspx"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </form>
    </asp:Content>
 <asp:Content ID="instruccionesGuisoLente" ContentPlaceHolderID="content" runat="server">
     <div style="margin-left: 10px">
        <br />
<h2>Ingredientes</h2>
<p>4 Cucharada de Aceite de Oliva Extra Virgen Essen (Saborizado Con Albahaca)</p>
<p>1/2 Kilo de Carne Rosbif</p>
<p>150 gr. de Panceta</p>
<p>2 Unidad de Chorizo Colorado (pelados y cortados en rodajas)</p>
<p>1 Cucharada de Pimentón Dulce</p>
<p>1 Cucharadita de Ají Molido</p>
<p>2 Unidad de Cebolla (cortadas en cubitos)</p>
<p>2 Unidad de Cebolla de Verdeo (cortadas en rueditas)</p>
<p>2 Diente de Ajo (fileteados)</p>
<p>2 Unidad de Zanahoria</p>
<p>3 Unidad de Papas chicas</p>
<p>1 Unidad de Pimiento Rojo</p>
<p>1 Unidad de Pimiento Verde</p>
<p>400 gr. de Lentejas (remojadas toda la noche)</p>
<p>250 cc. de Puré de Tomate</p>
<p>500 cc. de Caldo de Verduras</p>
<p>2 Unidad de Hoja de Laurel</p>
<p>1 Cucharadita de Sal Fina</p>
<p>1 Cucharadita de Pimienta</p>
 
<h2>Preparación</h2>
<p>Cortamos la carne y la panceta en cubos.</p>
<p>Calentamos la Cacerola tapada, 3' a fuego fuerte.  Agregamos el aceite y luego la carne, la panceta y el chorizo; cocinamos a fuego medio hasta que doren y suelten la grasa.</p>
<p>Agregamos el pimentón, el ají molido, las cebollas, el ajo y el resto de las verduras cortadas en cubitos; mezclamos y rehogamos unos minutos.</p>
<p>Incorporamos las lentejas (sin el agua de remojo), los tomates, el caldo, el laurel y los condimentos.  Tapamos y continuamos a fuego mínimo hasta que las lentejas estén a punto.</p>
<p>Servimos con perejil picado.</p>



    </div>
</asp:Content>
