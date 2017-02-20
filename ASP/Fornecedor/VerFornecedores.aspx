<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="VerFornecedores.aspx.cs" Inherits="ASP.Fornecedor.VerFornecedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ver Fornecedores"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
            <asp:BoundField DataField="Telefone" HeaderText="Telefone" SortExpression="Telefone" />
            <asp:BoundField DataField="Endereco" HeaderText="Endereco" SortExpression="Endereco" />
            <asp:CheckBoxField DataField="Pessoa" HeaderText="Pessoa" SortExpression="Pessoa" />
            <asp:BoundField DataField="CpfCnpj" HeaderText="CpfCnpj" SortExpression="CpfCnpj" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Cidade" HeaderText="Cidade" SortExpression="Cidade" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:ButtonField CommandName="Editar" Text="Editar" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="ASP.Modelo.Fornecedor" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="SelectAll" TypeName="ASP.DAL.FornecedorDAL" UpdateMethod="Update"></asp:ObjectDataSource>
    <br />  
</asp:Content>
