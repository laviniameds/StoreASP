<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditarCliente.aspx.cs" Inherits="ASP.Cliente.EditarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Editar Cliente"></asp:Label>
    <br />
    <br />
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="155px" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" DataKeyNames="Id" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <EditRowStyle BackColor="#999999" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
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
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="ASP.Modelo.Cliente" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="Select" TypeName="ASP.DAL.ClienteDAL" UpdateMethod="Update">
        <SelectParameters>
            <asp:SessionParameter Name="Id" SessionField="Id" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
</asp:Content>
