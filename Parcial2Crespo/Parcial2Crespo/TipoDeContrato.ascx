<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TipoDeContrato.ascx.cs" Inherits="Parcial2Crespo.TipoDeContrato" %>
 <asp:DropDownList ID="DropDownListContrato" runat="server">
            <asp:ListItem Text="Planta permanente" Value="permanente"></asp:ListItem>
            <asp:ListItem Text="Contratado" Value="contratado"></asp:ListItem>
            <asp:ListItem Text="Pasante" Value="pasante"></asp:ListItem>
        </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo obligatorio" ControlToValidate="DropDownListContrato"></asp:RequiredFieldValidator>