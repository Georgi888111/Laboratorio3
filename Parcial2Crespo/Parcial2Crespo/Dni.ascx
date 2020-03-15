<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Dni.ascx.cs" Inherits="Parcial2Crespo.Dni" %>
<asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Este campo es obligatorio" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="La cantidad de numeros es mayor a lo solicitado" MaximumValue="8" MinimumValue="1" Type="Integer"></asp:RangeValidator>
