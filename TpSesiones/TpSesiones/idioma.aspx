<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="idioma.aspx.cs" Inherits="TpSesiones.idioma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Idiomas</h2>
                <div id="div1">
            <p>
            <asp:DropDownList runat="server" ID="idiomas">
                <asp:ListItem Selected="True" Value="Inglés">Inglés</asp:ListItem>
                <asp:ListItem Value="Alemán">Alemán</asp:ListItem>
                <asp:ListItem Value="Francés">Francés</asp:ListItem>
                <asp:ListItem Value="Portugués">Portugués</asp:ListItem>
            </asp:DropDownList>
            </p>
        </div>
        Nivel
        <div id="div2">
            <p>
        <asp:RadioButtonList ID="nivelIdio" runat="server" RepeatDirection="Horizontal">
        <asp:ListItem Text="Básico" Value="Básico" />
        <asp:ListItem Text="Intermedio" Value="Intermedio" />
        <asp:ListItem Text="Avanzado" Value="Avanzado" />
            
</asp:RadioButtonList>
                </p>
        </div>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Finalizar" OnClick="Button1_Click" />
            </p>
    </form>
</body>
</html>
