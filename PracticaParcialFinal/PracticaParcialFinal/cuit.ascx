﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="cuit.ascx.cs" Inherits="PracticaParcialFinal.cuit" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Cuit invalido" ControlToValidate="TextBox1" OnServerValidate="valida"></asp:CustomValidator>