<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageParcial.Master" AutoEventWireup="true" CodeBehind="BotonGuardar.aspx.cs" Inherits="Parcial2Crespo.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="btnGuardar" ContentPlaceHolderID="botones" runat="server">
    <form>
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click"/>
        <asp:Button ID="Button2" runat="server" Text="Sesion" OnClick="Button1_Click" />
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="resultado" runat="server">
</asp:Content>

