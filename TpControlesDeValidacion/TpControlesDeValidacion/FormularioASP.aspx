<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioASP.aspx.cs" Inherits="TpControlesDeValidacion.Formulario1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="validaciones.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       Nombre
        <div id="div1">
        <asp:TextBox ID="nombre" runat="server" Width="188px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="nombre" ErrorMessage="No debe ingresar en su nombre caracteres numéricos." ValidationExpression="^[a-z &amp; A-Z]*$">*</asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="nombre" ErrorMessage="El nombre no puede estar vacio">*</asp:RequiredFieldValidator>
        <asp:TextBox ID="apellido" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="apellido" ErrorMessage="El apellido no puede estar vacio">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="apellido" ErrorMessage="Debe ingresar solo letras" ValidationExpression="^[a-z &amp; A-Z]*$">*</asp:RegularExpressionValidator>
            </div>
        Nombre de usuario
        <div id="div2">
       <asp:TextBox ID="usuario" runat="server" TextMode="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="usuario" ErrorMessage="El campo Nombre de usuario no puede estar vacio">*</asp:RequiredFieldValidator>
        </div>
        Contraseña
        <div id="div3">
         <asp:TextBox ID="password" runat="server" TextMode="Password" Width="188px"></asp:TextBox> 
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="password" ErrorMessage="El campo Contraseña no puede estar vacio">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password" ControlToValidate="confPass" ErrorMessage="La contraseña y su confirmacion no concuerdan">*</asp:CompareValidator>
            <asp:CustomValidator ID="contraseñaValida" runat="server" ControlToValidate="password" ErrorMessage="La contraseña debe incluir alguno de los siguientes símbolos: !@#$%^&amp;*+;: " OnServerValidate="contraseñaValida_ServerValidate">*</asp:CustomValidator>
        </div>
        Confirma tu contraseña
        <div id="div4">
        <asp:TextBox ID="confPass" runat="server" TextMode="Password"></asp:TextBox>   
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="confPass" ErrorMessage="El campo confirmacion de contraseña no puede estar vacio">*</asp:RequiredFieldValidator>
        </div>
        Fecha de nacimiento
        <div id="div5">
       <asp:TextBox ID="dia" runat="server" TextMode="Number"></asp:TextBox>   
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="dia" ErrorMessage="El día no puede estar vacío">*</asp:RequiredFieldValidator>
        <asp:DropDownList runat="server" ID="mesesList">
                <asp:ListItem Selected="True" Value="Enero">Enero</asp:ListItem>
                <asp:ListItem Value="Febrero">Febrero</asp:ListItem>
                <asp:ListItem Value="Marzo">Marzo</asp:ListItem>
                <asp:ListItem Value="Abril">Abril</asp:ListItem>
                <asp:ListItem Value="Mayo">Mayo</asp:ListItem>
                <asp:ListItem Value="Junio">Junio</asp:ListItem>
            <asp:ListItem Value="Julio">Julio</asp:ListItem>
            <asp:ListItem Value="Agosto">Agosto</asp:ListItem>
            <asp:ListItem Value="Septiembre">Septiembre</asp:ListItem>
            <asp:ListItem Value="Octubre">Octubre</asp:ListItem>
            <asp:ListItem Value="Noviembre">Noviembre</asp:ListItem>
            <asp:ListItem Value="Diciembre">Diciembre</asp:ListItem>


            </asp:DropDownList>

             
   
        <asp:TextBox ID="año" runat="server" TextMode="Number"></asp:TextBox>   
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="año" ErrorMessage="El año no puede estar vacío">*</asp:RequiredFieldValidator>
            <asp:CustomValidator ID="validaFechaNac" runat="server" ControlToValidate="dia" ErrorMessage="La feha ingresada es incorrecta." OnServerValidate="validaFechaNac_ServerValidate">*</asp:CustomValidator>
        </div>
        <div id="div6">
        Sexo
           <asp:DropDownList runat="server" ID="sexoList">
                <asp:ListItem Selected="True" Value="Femenino">Femenino</asp:ListItem>
                <asp:ListItem Value="Masculino">Masculino</asp:ListItem>
               <asp:ListItem Value="Otro">Otro</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div id="div7">
        Teléfono móvil  
          
       <asp:TextBox ID="telefono" runat="server" TextMode="Number"></asp:TextBox>  
        
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="telefono" ErrorMessage="Debe ingresar un número telefónico">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="telefono" ErrorMessage="Formato de telefono incorrecto" ValidationExpression="\(?\d{3}\)?-? *\d{3}-? *-?\d{4}">*</asp:RegularExpressionValidator>
        
        </div>
         <div id="div8">
         Dirección de correo alternativa 
        <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>   
             <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="email" ErrorMessage="Debe ingresar una direccion de mail alternativa.">*</asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="email" ErrorMessage="Formato de email inválido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        </div>
        <div id="div9">
         Demuéstranos que no eres un robot
        <p>
         <asp:Image runat="server" ID="imagen" ImageUrl="C:\Users\Georgi\Desktop\Programacion UTN\Segundo Año\Laboratorio de Computacion 3\clase6\450_1000.jpg"></asp:Image>
        </p>
        Escribe la palabra
         <asp:TextBox ID="confBot" runat="server"></asp:TextBox>   
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="confBot" ErrorMessage="Debe ingresar la palabra de confirmación">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="confBot" ErrorMessage="El texto no concuerda con la imagen" ValueToCompare="qGphJD">*</asp:CompareValidator>
        </div>
        <div id="div10">
        Ubicacion
            <p>
        <asp:DropDownList runat="server" ID="ubicList">
                <asp:ListItem Selected="True" Value="Argentina">Argentina</asp:ListItem>
                <asp:ListItem Value="Brasil">Brasil</asp:ListItem>
               <asp:ListItem Value="Bolivia">Bolivia</asp:ListItem>
            </asp:DropDownList>
                </p>
            </div>
        <div id="div11">
          
          <p><asp:CheckBox runat="server" ID="cboBoxTerm1" Text="Acepto las Condiciones del servicio y la Politica de Privacidad de Google"></asp:CheckBox>
              <asp:CustomValidator ID="validaCondic" runat="server" Display="Dynamic" ErrorMessage="Debe aceptar las politicas y condiciones para continuar." OnServerValidate="validaCondic_ServerValidate">*</asp:CustomValidator>
            </p>
          <p><asp:CheckBox runat="server" ID="cboBoxTerm2" Text="Google puede utilizar la informacion de mi cuenta para la personalizacion de 1+ en contenido y anuncios de sitios web que no pertenecen a Google. Mas informacion sobre la personalizacion"></asp:CheckBox></p>
        

        
        </div>
        <div>
            <asp:Button runat="server" Text="Siguiente paso" ID="boton" type="submit" OnClick="boton_Click" OnClientClick="ValidateForm()"></asp:Button>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
