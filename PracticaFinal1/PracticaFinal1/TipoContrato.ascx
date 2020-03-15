<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TipoContrato.ascx.cs" Inherits="PracticaFinal1.TipoContrato" %>
<asp:DropDownList ID="contrato" runat="server">
      <asp:ListItem Value="Planta Permanente" Text="Planta Permanente"></asp:ListItem>
      <asp:ListItem Value="Contratado" Text="Contratado"></asp:ListItem>
      <asp:ListItem Value="Pasante" Text="Pasante"></asp:ListItem>
</asp:DropDownList><asp:RequiredFieldValidator ID="validaContrato" runat="server" ErrorMessage="El tipo de contratación es requerido" ControlToValidate="contrato" Text="*"></asp:RequiredFieldValidator>