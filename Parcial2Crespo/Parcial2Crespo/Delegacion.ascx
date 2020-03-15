<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Delegacion.ascx.cs" Inherits="Parcial2Crespo.Delegacion" %>
 <asp:RadioButtonList ID="RadioButtonListDelega" runat="server">
            <asp:ListItem Value="central" Text="Sede Central"></asp:ListItem>
            <asp:ListItem Value="norte" Text="Oasis Norte"></asp:ListItem>
            <asp:ListItem Value="sur" Text="Oasis Sur"></asp:ListItem>

        </asp:RadioButtonList><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="RadioButtonListDelega"></asp:RequiredFieldValidator>