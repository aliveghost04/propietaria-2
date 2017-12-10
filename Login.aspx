<%@ Page Language="C#" 
    MasterPageFile="~/MasterPage.master" 
    AutoEventWireup="true" 
    CodeFile="Login.aspx.cs" 
    Inherits="Login" 
    UICulture="es"
    Title="Iniciar Sesión" %>

<asp:Content ID="Login" ContentPlaceHolderID="Content" runat="server">
    <div class="row">
        <div class="col-md-4 col-md-offset-4">
            <form id="LoginForm" class="form-signin" runat="server">
                <h2 class="form-signin-heading">Inicio de sesión</h2>
                <asp:TextBox id="inputEmail" 
                    class="form-control" 
                    runat="server" 
                    placeholder="Correo electrónico" 
                    required="" 
                    autofocus="" 
                    TextMode="Email"/>
                <asp:TextBox id="inputPassword" 
                    class="form-control" 
                    runat="server"
                    placeholder="Password" 
                    required=""
                    TextMode="Password"/>
                <asp:Panel runat="server"
                    id="errorLabel" 
                    Visible="False"
                    class="alert alert-danger">
                    <asp:Literal runat="server"
                        id="errorMessage" />
                </asp:Panel>
                <asp:button class="btn btn-lg btn-primary btn-block" 
                    type="submit" 
                    runat="server" 
                    OnClick="SubmitLogin" 
                    Text="Iniciar sesión"/>
            </form>
            <div class="text-center">
                <br />
                <a href="/Register.aspx">Registrarse</a>
            </div>
        </div>
    </div>
</asp:Content>