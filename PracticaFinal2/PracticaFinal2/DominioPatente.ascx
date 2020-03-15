<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DominioPatente.ascx.cs" Inherits="PracticaFinal2.DominioPatente" %>
<asp:TextBox ID="textDomPate" MaxLength="7" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="validaDominio" runat="server" ErrorMessage="El campo patente es requerido" ControlToValidate="textDomPate">*</asp:RequiredFieldValidator>
<asp:CustomValidator ID="validaPatente" runat="server" ErrorMessage="Verifique el formato de su patente" Text="*" OnServerValidate="validaFormatoPatente" ></asp:CustomValidator>
