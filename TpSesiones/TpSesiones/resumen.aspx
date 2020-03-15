<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resumen.aspx.cs" Inherits="TpSesiones.resumen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h2>Curriculum Vitae</h2>
        
         <asp:Label ID="datosPerso" runat="server" Text="Datos Personales"></asp:Label>
        
        <div>
            <asp:BulletedList ID="datos" runat="server">
            </asp:BulletedList>
        </div>
         <asp:Label ID="estu" runat="server" Text="Estudios"></asp:Label> 
         <div>
         <asp:BulletedList ID="estudio" runat="server">
         </asp:BulletedList>
        </div>
         <asp:Label runat="server" Text="Trabajos"></asp:Label> 
         <div>
         <asp:BulletedList ID="trabajo" runat="server">
         </asp:BulletedList>
        </div>
         <asp:Label ID="Label1" runat="server" Text="Idiomas"></asp:Label>
         <asp:BulletedList ID="idioma" runat="server">
         </asp:BulletedList>
    </form>
</body>
</html>
