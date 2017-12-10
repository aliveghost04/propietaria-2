<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeFile="Create.aspx.cs" 
    MasterPageFile="~/MasterPage.master"
    Inherits="Post_Create" 
    Title="Crear anuncio"%>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <div class="row">
        <div class="col-md-offset-3 col-md-6">
            <form id="createPost" runat="server">
                <h2>Crear un anuncio</h2>
                <div class="form-group">
                    <asp:Label Text="Nombre" runat="server"/>
                    <asp:TextBox ID="txtName" runat="server"
                        class="form-control"
                        required=""/>
                </div>
                <div class="form-group">
                    <asp:Label Text="Detalles" runat="server"/>
                    <asp:TextBox ID="txtDetails" 
                        runat="server"
                        TextMode="MultiLine"
                        class="form-control"
                        required=""/>
                </div>
                <div class="form-group">
                    <asp:Label Text="Características" runat="server"/>
                    <asp:TextBox ID="txtCharacteristics" 
                        runat="server"
                        TextMode="MultiLine"
                        class="form-control"
                        required=""/>
                </div>
                <div class="form-group">
                    <asp:Label Text="Precio" runat="server"/>
                    <asp:TextBox ID="txtPrice" 
                        runat="server"
                        TextMode="Number"
                        class="form-control"
                        required=""/>
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