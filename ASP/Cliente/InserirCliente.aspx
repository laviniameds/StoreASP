<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="InserirCliente.aspx.cs" Inherits="ASP.Cliente.InserirCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="Label1" runat="server" Text="Inserir Cliente"></asp:Label>
    <br />  
    <br/>
    <asp:TextBox ID="txtNome" runat="server">Nome</asp:TextBox>
    <br/>
    <asp:TextBox ID="txtFone" runat="server">Fone</asp:TextBox>
    <br/>
    <asp:TextBox ID="txtEmail" runat="server">Email</asp:TextBox>
    <br/>
    <asp:TextBox ID="txtCPF" runat="server">CPF</asp:TextBox>
    <br/>
    <asp:TextBox ID="txtCNPJ" runat="server">CNPJ</asp:TextBox>
    <br/>
    <asp:ListBox ID="lbCidades" runat="server"></asp:ListBox>
    <br/>
    <br/>
    <asp:Button ID="btnInserirProd" runat="server" Text="Inserir" OnClick="btnInserirProd_Click" />
    
</asp:Content>
