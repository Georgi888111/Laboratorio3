<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Equipamiento.ascx.cs" Inherits="PracticaFinal2.Equipamiento" %>
<asp:CheckBoxList ID="checkEquipamiento" runat="server" AutoPostBack="true">
    <asp:ListItem Value="Aire acondicionado" Text="Aire acondicionado"></asp:ListItem>
     <asp:ListItem Value="Direccion asistida" Text="Direccion asistida"></asp:ListItem>
     <asp:ListItem Value="Alarma" Text="Alarma"></asp:ListItem>
     <asp:ListItem Value="Frenos ABS" Text="Frenos ABS"></asp:ListItem>
</asp:CheckBoxList><asp:CustomValidator ID="validaEquipamiento" runat="server" ErrorMessage="El equipamiento es requerido" OnServerValidate="validaCheck">*</asp:CustomValidator>