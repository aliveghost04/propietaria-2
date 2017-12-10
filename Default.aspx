<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeFile="Default.aspx.cs" 
    Inherits="_Default" 
    MasterPageFile="~/MasterPage.master"
    Title="Inicio" %>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <div class="alert alert-danger" runat="server" id="errorPanel">
        <asp:Literal runat="server" ID="errorMessage" />
    </div>

    <div class="alert alert-success" runat="server" id="successPanel">
        <asp:Literal runat="server" ID="successMessage" />
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
        </HeaderTemplate>
        <ItemTemplate>
            <div class="col-md-3">
                <div class="thumbnail">
                    <img src="/image">
                    <div class="caption">
                        <h3><%# Eval("name")  %></h3>
                        <p><%# Eval("details") %></p>
                        <a href="#" class="btn btn-info" onclick="alert('Función a implementar luego');">Comprar</a>
                    </div>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>