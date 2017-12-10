<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeFile="Edit.aspx.cs" 
    Inherits="Post_Edit"
    MasterPageFile="~/MasterPage.master"
    Title="Editar anuncio" %>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <div class="row">
        <div class="col-md-offset-3 col-md-6">
            <form id="createPost" runat="server">
                <h2>Editar anuncio</h2>
                <input type="hidden" runat="server" id="inputId" />
                <div class="form-group">
                    <asp:Label Text="Nombre" runat="server"/>
                    <input type="text" id="txtName" runat="server"
                        class="form-control" required="" />
                </div>
                <div class="form-group">
                    <asp:Label Text="Detalles" runat="server"/>
                    <textarea id="txtDetails" 
                        runat="server" 
                        required=""
                        class="form-control"></textarea>
                </div>
                <div class="form-group">
                    <asp:Label Text="Características" runat="server"/>
                    <textarea id="txtCharacteristics" 
                        runat="server" 
                        required=""
                        class="form-control"></textarea>
                </div>
                <div class="form-group">
                    <asp:Label Text="Precio" runat="server"/>
                    <input type="number" id="txtPrice" runat="server"
                        class="form-control" required="" />
                </div>
                <div class="form-group text-right">
                    <asp:Button runat="server"
                        Text="Guardar"
                        class="btn btn-submit"
                        OnClick="Submit"/>
                </div>
            </form>
        </div>
    </div>
</asp:Content>