<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="VerClientes.aspx.cs" Inherits="ASP.Cliente.VerClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ver Clientes"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Telefone" HeaderText="Telefone" SortExpression="Telefone" />
            <asp:BoundField DataField="Cidade" HeaderText="Cidade" SortExpression="Cidade" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:BoundField DataField="Endereco" HeaderText="Endereco" SortExpression="Endereco" />
            <asp:BoundField DataField="CpfCnpj" HeaderText="CPF/CNPJ" SortExpression="CpfCnpj" />
            <asp:CheckBoxField DataField="Pessoa" HeaderText="Pessoa Física" SortExpression="Pessoa" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:ButtonField CommandName="Editar" Text="Editar" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StoreAppConnectionString %>" SelectCommand="SELECT * FROM [Cliente]"></asp:SqlDataSource>
    <br />  
    </asp:Content>
