<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Formulario web1.aspx.cs" Inherits="PracticaFinal8.Formulario_web1" %>

<%@ Register Src="~/DropCurso2.ascx" TagPrefix="uc1" TagName="DropCurso2" %>
<%@ Register Src="~/DropDownAlumno.ascx" TagPrefix="uc1" TagName="DropDownAlumno" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" Text="Ver formulario" ID="verForm" OnClick="verForm_Click"/>
  <asp:Button runat="server" Text="Ver tabla" ID="verTabla" OnClick="verTabla_Click"/>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <uc1:DropCurso2 runat="server" ID="DropCurso2" />
    <uc1:DropDownAlumno runat="server" ID="DropDownAlumno" />
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
      
</asp:Content>
