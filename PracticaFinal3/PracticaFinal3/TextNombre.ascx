<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TextNombre.ascx.cs" Inherits="PracticaFinal3.TextNombre" %>
<asp:TextBox ID="textBoxPersonal" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Este campo es requerido" Text="*" ControlToValidate="textBoxPersonal"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="validaSoloText" runat="server" ErrorMessage="Debe ingresar solo letras" ValidationExpression='^[a-z &amp; A-Z]*$' ControlToValidate="textBoxPersonal">*</asp:RegularExpressionValidator>
