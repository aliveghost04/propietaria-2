<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeFile="Default.aspx.cs" 
    Inherits="Post_Default"
    MasterPageFile="~/MasterPage.master"
    Title="Listado de anuncios" %>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <div class="alert alert-danger" runat="server" id="errorPanel">
        <asp:Literal runat="server" ID="errorMessage" />
    </div>

    <div class="alert alert-success" runat="server" id="successPanel">
        <asp:Literal runat="server" ID="successMessage" />
    </div>
    <h2>Listado de productos</h2>
    <div class="text-right">
        <a href="/Post/Create.aspx" class="btn btn-info">Agregar</a>
    </div>
    <h3 runat="server" id="searchResult">
        Resultado de la búsqueda de 
        "<asp:Literal runat="server"
            id="searchTerm"
        />"
    </h3>
    <asp:Repeater runat="server" ID="items">
        <HeaderTemplate>
            <div class="row">
                <div class="table-responsive">
                    <table class="table">
                        <thead>
                            <tr>
                                <th>Nombre</th>
                                <th>Precio</th>
                                <th>Acciones</th>
                            </tr>
                        </thead>
                        <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("name")  %></td>
                <td><%# Eval("unit_price")  %></td>
                <td>
                    <a class="btn btn-warning" 
                        runat="server"
                        href='<%# Eval("id", "/Post/Edit.aspx?id={0}") %>'>
                        
                        <i class="glyphicon glyphicon-pencil"></i>
                    </a>
                    <a class="btn btn-danger" 
                        runat="server"
                        href='<%# Eval("id", "/Post/Delete.aspx?id={0}") %>'>
                        
                        <i class="glyphicon glyphicon-trash"></i>
                    </a>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
                        </tbody>
                    </table>
                </div>
            </div>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>