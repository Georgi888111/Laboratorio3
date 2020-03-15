<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="TpWebServices.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:Label ID="Label1" runat="server" Text="Longitud"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Quiero convertir:"></asp:Label>
            <br />
            <asp:TextBox ID="q" runat="server"></asp:TextBox>
               
            
          
            
            <br />
            <asp:DropDownList ID="ddl1" runat="server">
                <asp:ListItem Text="Kilómetro (Km)" Value="km"></asp:ListItem>
                <asp:ListItem Text="Metro (m)" Value="m"></asp:ListItem>
                <asp:ListItem Text="Decímetro (dm)" Value="dm"></asp:ListItem>
                <asp:ListItem Text="Centímetro (cm)" Value="cm"></asp:ListItem>
                <asp:ListItem Text="Milímetro (mm)" Value="mm"></asp:ListItem>
                <asp:ListItem Text="Micrómetro (µm)" Value="µm"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="A:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddl2" runat="server">
                <asp:ListItem Text="Kilómetro (Km)" Value="km"></asp:ListItem>
                <asp:ListItem Text="Metro (m)" Value="m"></asp:ListItem>
                <asp:ListItem Text="Decímetro (dm)" Value="dm"></asp:ListItem>
                <asp:ListItem Text="Centímetro (cm)" Value="cm"></asp:ListItem>
                <asp:ListItem Text="Milímetro (mm)" Value="mm"></asp:ListItem>
                <asp:ListItem Text="Micrómetro (µm)" Value="µm"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="23px" Text="Calcular" OnClick="Button1_Click" Width="71px" />
            <asp:TextBox ID="TextBox3" runat="server" Enabled="False" Style="margin-left: 0px"></asp:TextBox>
           
        </div>
       
    
    </form>
</body>
</html>
