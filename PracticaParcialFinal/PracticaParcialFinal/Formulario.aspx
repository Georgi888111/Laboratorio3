<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="PracticaParcialFinal.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <script type="text/javascript" src="validaciones.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Formulario carga</h2>
        
        <div>
         Nombre&nbsp;&nbsp;   
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Este campo debe estar completo">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox1" ErrorMessage="Los campos nombre y apellido no concuerdan">*</asp:CompareValidator>
            <br />
        </div>
        <div>
            Apellido&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div>
            Teléfono
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Este campo debe estar completo">*</asp:RequiredFieldValidator>
            <br />
</div>
        Sexo
        <div>
            <asp:RadioButtonList ID="radioBtnSexo" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                <asp:ListItem Text="Femenino" Value="F"></asp:ListItem>
                <asp:ListItem Text="Otro" Value="O"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="radioBtnSexo" ErrorMessage="Debe marcar algunas de las opciones">*</asp:RequiredFieldValidator>
        </div>
        Hijos
        <div>
         <asp:CheckBoxList ID="tieneHijos" runat="server" RepeatDirection="Horizontal">
             <asp:ListItem Text="Si" Value="Si"></asp:ListItem>
             <asp:ListItem Text="No" Value="No"></asp:ListItem>
            </asp:CheckBoxList>

        </div>
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="www.google.com">Google</asp:HyperLink>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Boton" OnClick="Button1_Click" OnClientClick="ValidateForm()"/>
        <asp:Button ID="Button2" runat="server" Text="Mostrar" OnClick="Button2_Click" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </div>
        <div>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
         </div>
    </form>
</body>
</html>
