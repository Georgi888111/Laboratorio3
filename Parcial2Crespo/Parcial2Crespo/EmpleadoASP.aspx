<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpleadoASP.aspx.cs" Inherits="Parcial2Crespo.EmpleadoASP" %>

<%@ Register Src="~/Dni.ascx" TagPrefix="uc1" TagName="Dni" %>
<%@ Register Src="~/TipoDeContrato.ascx" TagPrefix="uc1" TagName="TipoDeContrato" %>
<%@ Register Src="~/Delegacion.ascx" TagPrefix="uc1" TagName="Delegacion" %>
<%@ Register Src="~/Estudios.ascx" TagPrefix="uc1" TagName="Estudios" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <h2>Administrar Empleado</h2>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="apellido" runat="server" Text="Apellido" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="ape" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ape" ErrorMessage="Campo obligatorio"></asp:RequiredFieldValidator>
        <p>
            <asp:Label ID="nombre" runat="server" Text="Nombre" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="nom" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="nom" ErrorMessage="Campo obligatorio"></asp:RequiredFieldValidator>
        </p>
        <asp:Label ID="dni" runat="server" Text="Dni" Font-Bold="True"></asp:Label>
        <uc1:Dni runat="server" id="Dni1"/>
        <br />
        <asp:Label ID="tipoCon" runat="server" Text="Tipo de contrato" Font-Bold="True"></asp:Label>
        <uc1:TipoDeContrato runat="server" id="TipoDeContrato" />
        <p>
            <asp:Label ID="horarios" runat="server" Text="Regimen laboral" Font-Bold="True"></asp:Label>
            <asp:DropDownList ID="DropDownListRegimen" runat="server">
                <asp:ListItem Text="8-13" Value="primero"></asp:ListItem>
                <asp:ListItem Text="8-16" Value="segundo"></asp:ListItem>
                <asp:ListItem Text="12-20" Value="tercero"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownListRegimen" ErrorMessage="Campo obligatorio"></asp:RequiredFieldValidator>
        </p>
        <asp:Label ID="delegacion" runat="server" Text="Delegacion" Font-Bold="True"></asp:Label>
        <uc1:Delegacion runat="server" id="Delegacion1" />
        <asp:Label ID="estu" runat="server" Text="Estudios" Font-Bold="True"></asp:Label>
        <uc1:Estudios runat="server" id="Estudios" />
        <br />
        <asp:Label ID="Desc" runat="server" Text="Descripcion" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="Descripcion" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Descripcion" ErrorMessage="Este campo es obligatorio"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Session" OnClick="Button2_Click" />
        <br />
        <asp:Table ID="Table1" runat="server">
        <asp:TableRow ID="linea1"></asp:TableRow>
        </asp:Table>
        <br />
        <br />
    </form>
</body>
</html>
