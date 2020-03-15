<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServiceCliente.aspx.cs" Inherits="PracticaFinal6.WebServiceCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
         </div><div>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
         </div><div>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
         </div><div>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
         </div>
        <asp:Button ID="btnXml" runat="server" Text="Xml" OnClick="btnXml_Click" />
        <asp:Button ID="btnJson" runat="server" Text="Json" OnClick="btnJson_Click" />
    </form>
</body>
</html>
