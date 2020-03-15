<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="TpAsp.Formulario" %>

<!DOCTYPE html>
<script runat="server">
    void Page_Load(Object sender, EventArgs e)
    {
        boton.Click += new EventHandler(this.onClickSender);
    }
    void onClickSender(object Source, EventArgs e)
    {
        Image foto = new Image();
        
           f.SaveAs(Server.MapPath("Imágenes") + "/tmp.png");
           //foto.ImageUrl = ("Imágenes/tmp.png");
       
        string check;

        if (cbSi.Checked && cbNo.Checked)
        {
            check = "Se han seleccionado las dos checkBox";
        }
        else if (cbSi.Checked)
        {
            check = "Se ha seleccionado el checkBox 'Si'";
        }
        else if (cbNo.Checked)
        {
            check = "Se ha seleccionado el checkBox 'No'";
        }
        else
        {
            check = "No se ha seleccionado ningún checkBox";
        }
        recibirTxt.InnerText = txtBox.Text;
        recibirCmb.InnerText = ddList.SelectedValue;
        recibirImg = foto;
        recibirChkB.InnerText = check;
        recibirHVinculo.InnerText = hVinc.InnerHtml;
        recibirRB.InnerText = rBtn.SelectedValue;
        recibirHdn.InnerText = "Campo oculto!!";
    }
    

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Estilo.css" rel="stylesheet" />
</head>
<body>
    <h3 id="header">COMPONENTES</h3>
    <form id="form1" runat="server" method="get">
           
            <div id="div1">
              
              <p><label>Caja de Texto</label></p>
                 
            <p><label>Combo</label></p>
                
            <p><label>Imagen</label></p>
                
            <p><label>CheckBox</label></p>
                 
            <p><label>HiperVinculo</label></p>
                
            <p><label>Radio Button</label></p>
                 
            <p><label>Campo Oculto</label></p>
                
             <p><label>Botón</label></p>
             <p id="subtitulo">Datos ingresados</p>
            </div> 
           
            <div id="div2">
                 
         
           
            <p>
            <asp:TextBox runat="server" ID="txtBox"></asp:TextBox>
            </p> 
            <p>
            <asp:DropDownList runat="server" ID="ddList">
                <asp:ListItem Selected="True" Value="AR">Argentina</asp:ListItem>
                <asp:ListItem Value="IT">Italia</asp:ListItem>
                <asp:ListItem Value="DE">Alemania</asp:ListItem>
                <asp:ListItem Value="PT">Portugal</asp:ListItem>
            </asp:DropDownList>
            </p>   
       
            <p>
            <asp:FileUpload runat="server" ID="f"  />
             </p>
            <p>
            <asp:CheckBox runat="server" ID="cbSi" Text="SI"></asp:CheckBox>
          
            <asp:CheckBox runat="server" ID="cbNo" Text="NO"></asp:CheckBox>
            </p>

       
           <p>
            <a runat="server" id="hVinc" href="http://www.google.com.ar">Google</a>
       </p>
  
        <p runat="server">
           
            <asp:RadioButtonList runat="server" ID="rBtn" RepeatDirection="Horizontal">
                <asp:ListItem Text="Alta" Value="Alta" />
                <asp:ListItem Text="Media" Value="Media" />
                <asp:ListItem Text="Baja" Value="Baja" />
            </asp:RadioButtonList>
     </p>
           <p>
            <input runat="server" type="hidden" id="hdn" />
   </p>
            <p>
            <asp:Button runat="server" Text="Boton" ID="boton" type="submit"></asp:Button>
       
        </p>

        </div>
     
      <div id="div3">

          
            
            <p><label runat="server">Caja de Texto</label></p>
          
            <p><label>Combo</label></p>
          
    
            <p><label>Imagen</label></p>
          
      
            <p><label>CheckBox</label></p>
           
      
            <p><label>Hiper Vínculo</label></p>
        
     
            <p><label>Radio Button</label></p>
           
      

       
            <p><label>Campo Oculto</label></p>
          </div>
          
       <div id="div4">
       <p runat="server" id="recibirTxt"></p>
       <p runat="server" id="recibirCmb"></p>
       <asp:Image runat="server" ID="recibirImg" ImageUrl ="C:\Users\Georgi\Pictures"></asp:Image>
       <p runat="server" id="recibirChkB"></p>
       <p runat="server" id="recibirHVinculo"></p>
       <p runat="server" id="recibirRB"></p>
       <p runat="server" id="recibirHdn"></p>
     </div>

       
              
        
    </form>

</body>
</html>
