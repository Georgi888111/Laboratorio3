<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="validaContraseña.ascx.cs" Inherits="PracticaParcialFinal.validaContraseña" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas no coinciden" ControlToCompare="TextBox1" ControlToValidate="TextBox2"></asp:CompareValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Debe completar los campos"></asp:RequiredFieldValidator>
