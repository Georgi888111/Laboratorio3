<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formXML.aspx.cs" Inherits="FinalDiciembre.formXML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Filas"></asp:Label>
        <asp:TextBox ID="textFilas" runat="server"></asp:TextBox>
            </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Columnas"></asp:Label>
        <asp:TextBox ID="textColumnas" runat="server"></asp:TextBox>
            </div>
        <asp:Button ID="btnXml" runat="server" Text="XML" OnClick="btnXml_Click" />
    </form>
</body>
</html>
