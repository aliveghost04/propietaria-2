<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeFile="Delete.aspx.cs" 
    Inherits="Post_Delete" 
    MasterPageFile="~/MasterPage.master"
    Title="Eliminar anuncio"%>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <div class="alert alert-warning">
        ¿Está seguro que desea eliminar este anuncio? <br />
        Esta opción no se puede deshacer
        <div class="form-inline">
            <asp:HyperLink runat="server"
                NavigateUrl="~/Post/Default.aspx"
                CssClass="btn btn-default" 
                Text="Cancelar" />
            <form runat="server" style="display: inline-block">
                <asp:Button runat="server"
                    Text="Sí"
                    CssClass="btn btn-danger"
                    OnClick="Submit"/>
            </form>
        </div>
    </div>
</asp:Content>