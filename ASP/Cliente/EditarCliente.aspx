<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditarCliente.aspx.cs" Inherits="ASP.Cliente.EditarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Editar Cliente"></asp:Label>
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="155px" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" DataKeyNames="Id">
        <Fields>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Telefone" HeaderText="Telefone" SortExpression="Telefone" />
            <asp:BoundField DataField="Cidade" HeaderText="Cidade" SortExpression="Cidade" />
            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
            <asp:BoundField DataField="Endereco" HeaderText="Endereco" SortExpression="Endereco" />
            <asp:BoundField DataField="CpfCnpj" HeaderText="CPF/CNPJ" SortExpression="CpfCnpj" />
            <asp:CheckBoxField DataField="Pessoa" HeaderText="Pessoa Física" SortExpression="Pessoa" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" CancelText="Cancelar" DeleteText="Deletar" EditText="Editar" InsertText="Inserir" NewText="Novo" />
        </Fields>
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="ASP.Modelo.Cliente" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="Select" TypeName="ASP.DAL.ClienteDAL" UpdateMethod="Update">
        <SelectParameters>
            <asp:SessionParameter Name="Id" SessionField="Id" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
</asp:Content>
