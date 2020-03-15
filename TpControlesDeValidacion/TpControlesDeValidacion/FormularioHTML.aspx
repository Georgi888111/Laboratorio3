<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioHTML.aspx.cs" Inherits="TpControlesDeValidacion.FormularioHTML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <%--<link href="Estilo.css" rel="stylesheet" />--%>
    <style type="text/css">
        #boton {
            width: 161px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        Nombre
        <div id="div1">
        <input type="text" id="nomb" placeholder="nombre" runat="server" /><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="nomb" EnableTheming="True" ErrorMessage="RequiredFieldValidator">Ningún campo debe estar vacío.</asp:RequiredFieldValidator>
&nbsp;<input type="text" id="ape" placeholder="apellido" runat="server"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ape" ErrorMessage="RequiredFieldValidator">Ningún campo debe estar vacío</asp:RequiredFieldValidator>
           
            </div>
        Nombre de usuario
        <div id="div2">
        <input type="email" id="usu" size="46" placeholder="@gmail.com" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="usu" ErrorMessage="RequiredFieldValidator">Ningún campo debe estar vacío</asp:RequiredFieldValidator>
        </div>
        Contraseña
        <div id="div3">
        <input type="password" id="pass" size="46" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="pass" ErrorMessage="RequiredFieldValidator">Ningún campo debe estar vacío</asp:RequiredFieldValidator>
        </div>
        Confirma tu contraseña
        <div id="div4">
        <input type="password" id="passConf" size="46" runat="server"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="passConf" ErrorMessage="RequiredFieldValidator">Ningún campo debe estar vacío</asp:RequiredFieldValidator>
        </div>
        Fecha de nacimiento
        <div id="div5">
        <input type="number" id="dia" placeholder="día" runat="server"/>&nbsp;<select name="select" id="selectMeses">
          <option value="Enero">Enero</option> 
          <option value="Febrero">Febrero</option>
          <option value="Marzo">Marzo</option>
          <option value="Abril">Abril</option>
          <option value="Mayo">Mayo</option>
          <option value="Junio">Junio</option>
          <option value="Julio">Julio</option>
          <option value="Agosto">Agosto</option>
          <option value="Septiembre">Septiembre</option>
          <option value="Octubre">Octubre</option>
          <option value="Noviembre">Noviembre</option>
          <option value="Diciembre">Diciembre</option>

             
        </select>
        <input type="number" id="año" placeholder="año" size="13" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="año" ErrorMessage="RequiredFieldValidator">Ningún campo debe estar vacío</asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="dia" ErrorMessage="RequiredFieldValidator">Ningún campo debe estar vacío</asp:RequiredFieldValidator>
        </div>
        <div id="div6">
        Sexo
        <select name="select" id="selectSexo">
          <option value="Femenino">Femenino</option> 
          <option value="Masculino">Masculino</option>
          <option value="Otro">Otro</option>
             </select>
        </div>
        <div id="div7">
        Teléfono móvil  
          
        <input type="number" id="tel" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="tel" ErrorMessage="RequiredFieldValidator">Ningún campo debe estar vacío</asp:RequiredFieldValidator>
        
        </div>
         <div id="div8">
         Dirección de correo alternativa 
        <input type="email" id="mailAlter" runat="server"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="mailAlter" ErrorMessage="RequiredFieldValidator">Ningún campo debe estar vacío</asp:RequiredFieldValidator>
        </div>
        <div id="div9">
         Demuéstranos que no eres un robot
        <p>
        <img src="C:\Users\Georgi\Desktop\Programacion UTN\Segundo Año\Laboratorio de Computacion 3\clase6\450_1000.jpg" alt="La imagen no se cargó correctamente" width="175" height="100">
        </p>
        Escribe la palabra
        <input type="text" id="confRobot" runat="server"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="confRobot" ErrorMessage="RequiredFieldValidator">Ningún campo debe estar vacío</asp:RequiredFieldValidator>
        </div>
        <div id="div10">
        Ubicacion
            <p>
        <select name="select" id="selectUbic">
          <option value="Argentina">Argentina</option> 
          <option value="Brasi">Brasil</option>
          <option value="Bolivia">Bolivia</option>
        </select>
                </p>
            </div>
        <div id="div11">
        <label><input type="checkbox" id="cbox1" value="checkbox1">Acepto las Condiciones del servicio y la Politica de Privacidad de Google</label><br>

         <input type="checkbox" id="cbox2" value="checkbox2"> <label for="cbox2">Google puede utilizar la informacion de mi cuenta para la personalizacion de 1+ en contenido y anuncios de sitios web que no pertenecen a Google. Mas informacion sobre la personalizacion</label>

        
        </div>
        <div>
           <asp:Button runat="server" Text="Siguiente paso" ID="botonValida" type="submit" OnClick="boton_Click"></asp:Button>
        </div>
    </form>
  
    <script>

    </script>
</body>
</html>
