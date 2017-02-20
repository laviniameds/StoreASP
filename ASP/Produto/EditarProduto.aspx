<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditarProduto.aspx.cs" Inherits="ASP.Produto.EditarProduto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Editar Produto"></asp:Label>
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="155px" AutoGenerateRows="False" DataSourceID="ObjectDataSource1">
        <Fields>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Descricao" HeaderText="Descricao" SortExpression="Descricao" />
            <asp:CommandField CancelText="Cancelar" DeleteText="Deletar" EditText="Editar" InsertText="Inserir" NewText="Novo" ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="ASP.Modelo.Produto" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="Select" TypeName="ASP.DAL.ProdutoDAL" UpdateMethod="Update">
        <SelectParameters>
            <asp:SessionParameter Name="Id" SessionField="Id" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
</asp:Content>
