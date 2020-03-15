<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Combustible.ascx.cs" Inherits="PracticaFinal2.Combustible" %>
<asp:DropDownList ID="combus" runat="server" OnSelectedIndexChanged="bloqueaEquipamientos" AutoPostBack ="true">
    <asp:ListItem Value="Nafta" Text="Nafta"></asp:ListItem>
     <asp:ListItem Value="Diesel" Text="Diesel"></asp:ListItem>
     <asp:ListItem Value="GNC" Text="GNC"></asp:ListItem>
</asp:DropDownList>