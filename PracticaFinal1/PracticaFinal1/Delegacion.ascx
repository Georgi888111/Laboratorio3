<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Delegacion.ascx.cs" Inherits="PracticaFinal1.Delegacion" %>
<asp:RadioButtonList ID="radioDelega" runat="server">
    <asp:ListItem Value="Sede central" Text="Sede central" Selected="True"></asp:ListItem>
     <asp:ListItem Value="Oasis sur" Text="Oasis sur"></asp:ListItem>
     <asp:ListItem Value="Oasis norte" Text="Oasis norte"></asp:ListItem>
</asp:RadioButtonList><asp:RequiredFieldValidator ID="validaDelegacion" runat="server" ErrorMessage="El campo delegacion es requerido" ControlToValidate="radioDelega" Text="*"></asp:RequiredFieldValidator>