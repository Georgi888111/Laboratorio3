<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Estudios.ascx.cs" Inherits="PracticaFinal1.Estudios" %>
<asp:CheckBoxList ID="estudioCheck" runat="server" OnSelectedIndexChanged="selecSecuIncompleto" AutoPostBack="true">
    <asp:ListItem Value="Secundario incompleto"></asp:ListItem>
    <asp:ListItem Value="Secundario completo"></asp:ListItem>
    <asp:ListItem Value="Terciario completo"></asp:ListItem>
    <asp:ListItem Value="Universitario completo"></asp:ListItem>
</asp:CheckBoxList><asp:CustomValidator ID="validaEstudio" runat="server" ErrorMessage="El campo estudios es requerido" OnServerValidate="validaCheck" Text="*"></asp:CustomValidator>