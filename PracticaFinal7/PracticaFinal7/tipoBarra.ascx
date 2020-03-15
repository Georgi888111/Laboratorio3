<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tipoBarra.ascx.cs" Inherits="PracticaFinal7.tipoBarra" %>
<asp:RadioButtonList ID="tipoCodBarra" runat="server">
    <asp:ListItem Value="EAN" Text="EAN"></asp:ListItem>
    <asp:ListItem Value="PDF417" Text="PDF417"></asp:ListItem>
    <asp:ListItem Value="QR" Text="QR"></asp:ListItem>
</asp:RadioButtonList><asp:RequiredFieldValidator ID="validaRadio" runat="server" ErrorMessage="Debe marcar alguna de las opciones para el tipo de barra" ControlToValidate="tipoCodBarra"></asp:RequiredFieldValidator>