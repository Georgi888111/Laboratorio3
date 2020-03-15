<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RecetaPollo.aspx.cs" Inherits="TpMasterPage.Formulario_web1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="optionPollo" ContentPlaceHolderID="options" runat="server">
    <form runat="server">
        <div style="margin-left: 10px; margin-bottom:5px">
            <p>Secci&oacute;n Men&uacute</p>
            <asp:Menu runat="server">
                <Items>
                    <asp:MenuItem Text="Receta Tortilla de papas" Value="tortilla" NavigateUrl="~/RecetaTortilla.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Receta guiso de Lentejas" Value="lentejas" NavigateUrl="~/RecetaLentejas.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Receta pollo a la portuguesa" Value="pollo"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </form>
    </asp:Content>
 <asp:Content ID="instruccionesPollo" ContentPlaceHolderID="content" runat="server">
    <div style="margin-left: 10px">
        <br />
<h2>Ingredientes</h2>
<p>1 pollo de 1,500 kg</p>
<p>1/2 taza de aceite</p>
<p>70 grs de manteca</p>
<p>1 cebolla</p>
<p>2 ajíes rojos</p>
<p>4 tomates</p>
<p>1 vaso de vino blanco</p>
<p>1 ramito de hierbas</p>
<p>sal y pimienta, a gusto</p>
<p>1 kg de papas</p>
<p>200 grs de arvejas</p>
 
<h2>Preparación</h2>
<p>Cortar el pollo en 8 presas y en una olla profunda calentar el aceite con la manteca y allí dorarlas por todos sus lados, haciéndolo por tandas si fuera necesario</p>
<p>Una vez hecho, volver todas las presas a la olla y agregar la cebolla y los ajíes cortados en Juliana, los tomates sin piel ni semillas cubeteados y dejar cocinar por 5 minutos</p>
<p>Incorporar el vino, el ramo de hierbas, salpimentar a gusto y cocinar tapado a fuego mediano hasta que el pollo esté bien tierno</p>
<p>Por otro lado, hervir las papas cortadas en rodajas en abundante agua con sal y servir en una fuente grande junto con las arvejas y el pollo</p>



    </div>
</asp:Content>
