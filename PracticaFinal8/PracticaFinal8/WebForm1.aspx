<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PracticaFinal8.WebForm1" %>

<%@ Register Src="~/DropCurso.ascx" TagPrefix="uc1" TagName="DropCurso" %>
<%@ Register Src="~/DropCurso2.ascx" TagPrefix="uc1" TagName="DropCurso2" %>
<%@ Register Src="~/DropDownAlumno.ascx" TagPrefix="uc1" TagName="DropDownAlumno" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:DropCurso runat="server" ID="DropCurso"/>
        <uc1:DropCurso2 runat="server" id="DropCurso2"/>
        <uc1:DropDownAlumno runat="server" id="DropDownAlumno" />
      
        <asp:Table ID="Table1" runat="server" BorderStyle="Dotted" Font-Names="Verdana" Font-Size="20px">
            <asp:TableRow>
                <asp:TableCell ID="celda1"><label>Madre</label></asp:TableCell>
                 <asp:TableCell ID="celda2"><label>Madre</label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                  <asp:TableCell ID="celda3"><label>Madre</label></asp:TableCell>
                 <asp:TableCell ID="celda4"><label>Madre</label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                  <asp:TableCell ID="celda5"><label>Madre</label></asp:TableCell>
                 <asp:TableCell ID="celda6"><label>Madre</label></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/imagen.jpg"/>
    </form>
</body>
</html>
