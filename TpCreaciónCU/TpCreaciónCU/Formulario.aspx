<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="TpCreaciónCU.Formulario" %>
<%@ Register Src="TextBoxNoEmpty.ascx" TagName="textBoxG" TagPrefix="tg"%>
<%@ Register Src="TextBoxCuit.ascx" TagName="textCuitG" TagPrefix="tg"%>
<%@ Register Src="TextBoxMayorEdad.ascx" TagName="textEdadG" TagPrefix="tg"%>
<%@ Register Src="RadioButtonSex.ascx" TagName="radioSexG" TagPrefix="tg"%>
<%@ Register Src="ComboPaises.ascx" TagName="comboPG" TagPrefix="tg"%>
<%@ Register Src="RangoHijosMenores.ascx" TagName="textHijosG" TagPrefix="tg"%>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h2>Registración de ayuda social por hijos</h2>
    <form id="form1" runat="server">
        Apellido
        <div>
         <tg:textBoxG ID="apellido" runat="server" OnNoText="Button1_Click"/>
            
            <asp:Label ID="labelApellido" runat="server" Text=""></asp:Label>
            
        </div>
        Nombre
        <div>
       <tg:textBoxG ID="nombre" runat="server" OnNoText="Button1_Click"/>
            
       <asp:Label ID="labelNombre" runat="server" Text=""></asp:Label>
            
        
        </div> 
        N° de CUIT
        <div>
        <tg:textCuitG ID="cuit" runat="server" OnVerifCuit="Button1_Click"/>
        <asp:Label ID="labelCuit" runat="server" Text=""></asp:Label>
        </div>
        Edad del solicitante
        <div>
        <tg:textEdadG ID="edad" runat="server" OnverifEdad="Button1_Click"/>
        <asp:Label ID="labelEdad" runat="server" Text=""></asp:Label>
        </div>
        Sexo
        <div style="height: 27px">
        <tg:radioSexG ID="sexo" runat="server" />    
        </div>
        Nacionalidad
       <div>
       <tg:comboPG ID="paises" runat="server" />
      </div>
        N° de hijos menores de edad
        <div>
            <tg:textHijosG ID="hijos" runat="server" OnCantidadHijos="Button1_Click" />
            <asp:Label ID="labelHijos" runat="server" Text=""></asp:Label>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
