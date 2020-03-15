<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargaSession.aspx.cs" Inherits="TpControlesAD.CargaSession" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Ingrese el id de la categoría que desea filtrar
        <asp:TextBox ID="tbox" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="EnviarId" OnClick="Button1_Click" />
    </form>
</body>
</html>
