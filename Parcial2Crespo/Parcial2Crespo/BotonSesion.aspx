<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageParcial.Master" AutoEventWireup="true" CodeBehind="BotonSesion.aspx.cs" Inherits="Parcial2Crespo.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="btonSesion" ContentPlaceHolderID="botones" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Sesion" OnClick="Button1_Click" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="resultado" runat="server">
</asp:Content>

