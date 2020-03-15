<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DropCurso.ascx.cs" Inherits="PracticaFinal8.DropCurso" %>
<asp:DropDownList ID="DropDownCurso" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="division" DataValueField="id"></asp:DropDownList>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Curso]"></asp:SqlDataSource>
<asp:DropDownList ID="DropDownAlumno" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="dni" DataValueField="dni"></asp:DropDownList>
<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Alumno] WHERE ([fkCurso] = ?)">
    <SelectParameters>
        <asp:ControlParameter ControlID="DropDownCurso" Name="fkCurso" PropertyName="SelectedValue" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>
