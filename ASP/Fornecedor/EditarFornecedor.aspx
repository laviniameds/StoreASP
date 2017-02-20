<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditarFornecedor.aspx.cs" Inherits="ASP.Fornecedor.EditarFornecedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Editar Fornecedor"></asp:Label>
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="155px" AutoGenerateRows="False" DataSourceID="ObjectDataSource1">
        <Fields>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
            <asp:BoundField DataField="Telefone" HeaderText="Telefone" SortExpression="Telefone" />
            <asp:BoundField DataField="Endereco" HeaderText="Endereco" SortExpression="Endereco" />
            <asp:CheckBoxField DataField="Pessoa" HeaderText="Pessoa" SortExpression="Pessoa" />
            <asp:BoundField DataField="CpfCnpj" HeaderText="CpfCnpj" SortExpression="CpfCnpj" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Cidade" HeaderText="Cidade" SortExpression="Cidade" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:CommandField CancelText="Cancelar" DeleteText="Deletar" EditText="Editar" InsertText="Inserir" NewText="Novo" ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="ASP.Modelo.Fornecedor" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="Select" TypeName="ASP.DAL.FornecedorDAL" UpdateMethod="Update">
        <SelectParameters>
            <asp:SessionParameter Name="Id" SessionField="Id" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
</asp:Content>
