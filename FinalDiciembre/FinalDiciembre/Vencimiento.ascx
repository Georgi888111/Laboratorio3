<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Vencimiento.ascx.cs" Inherits="FinalDiciembre.Vencimiento" %>
<asp:RadioButtonList ID="radioVenci" runat="server" RepeatDirection="Horizontal">
    <asp:ListItem Text="Corto plazo" Value="Corto plazo" Selected="True"></asp:ListItem>
    <asp:ListItem Text="Largo plazo" Value="Largo plazo"></asp:ListItem>
</asp:RadioButtonList><asp:CustomValidator ID="CustomValidator1" runat="server"></asp:CustomValidator>