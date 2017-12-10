<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeFile="Contact.aspx.cs" 
    Inherits="Contact"
    MasterPageFile="~/MasterPage.master"
    Title="Contacto" %>

<asp:Content ContentPlaceHolderID="Content" runat="server">
    <div class="col-sm-12">
          <div class="row">
              <h3>Contactos</h3>
            <div class="col-sm-12 top-intro-text">
              <h4 class="text-center">Queremos escucharte, debajo todos los medios para contactarnos.</h4>
            </div>

            <div class="col-sm-6 mb-lg">
              <h4>Ubicación</h4>
                <p>
                <strong>Tienda en Linea</strong><br>
                Máximo Gómez #79<br>
                Distrito Nacional, República Dominicana<br>
              </p>
            </div>

            <div class="col-sm-6 mb-lg">
              <h4>Escríbenos</h4>
              <p>Si tienes alguna duda puedes comunicarla por nuestros canales de contactos y te responderemos tan rápido como sea posible.</p>
                <ul>
                    <li>Email: info@tiendaenlinea.local</li>
                    <li>Número de contacto: 809-123-1234</li>
                </ul>
            </div>

          </div>
        </div>
</asp:Content>