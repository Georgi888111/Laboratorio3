﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CodigoBarra.ascx.cs" Inherits="FinalDiciembre.CodigoBarra" %>
<asp:TextBox ID="textCodigo" runat="server" MaxLength="7"></asp:TextBox><asp:RequiredFieldValidator ID="validaCodigo" runat="server" ErrorMessage="Este campo es requerido" ControlToValidate="textCodigo"></asp:RequiredFieldValidator>