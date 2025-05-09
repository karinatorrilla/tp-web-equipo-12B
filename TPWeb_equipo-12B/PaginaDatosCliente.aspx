<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="PaginaDatosCliente.aspx.cs" Inherits="TPWeb_equipo_12B.PaginaDatosCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row justify-content-center">
        <div class="col-10 col-md-8 col-lg-6">
            <div class="m-4"">
                <h2 class="mb-4 text-left font-weight-bold text-dark">Datos Personales</h2>
            </div>
            
            <div class="p-4 rounded bg-white shadow-sm">
                <div class="row">
                    <div class="col-12">
                        <div class="mb-3">
                            <label for="txtDni" class="form-label font-weight-bold text-dark">DNI</label>
                            <asp:TextBox runat="server" ID="txtDni" CssClass="form-control" required="true" />
                        </div>
                        <div class="mb-3">
                            <label for="txtNombre" class="form-label font-weight-bold text-dark">Nombre: </label>
                            <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" required="true" />
                        </div>
                        <div class="mb-3">
                            <label for="txtApellido" class="form-label font-weight-bold text-dark">Apellido: </label>
                            <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" required="true" />
                        </div>
                        <div class="mb-3">
                            <label for="txtEmail" class="form-label font-weight-bold text-dark">Email: </label>
                            <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" required="true" />
                        </div>
                    </div>
                    <div class="col-12">
                        <div class="mb-3">
                            <label for="txtDireccion" class="form-label font-weight-bold text-dark">Dirección: </label>
                            <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" required="true" />
                        </div>
                        <div class="mb-3">
                            <label for="txtCiudad" class="form-label font-weight-bold text-dark">Ciudad: </label>
                            <asp:TextBox runat="server" ID="txtCiudad" CssClass="form-control" required="true" />
                        </div>
                        <div class="mb-3">
                            <label for="txtCP" class="form-label font-weight-bold text-dark">CP: </label>
                            <asp:TextBox runat="server" ID="txtCP" CssClass="form-control" TextMode="Number" required="true" />
                        </div>
                    </div>
                </div>
                <div class="row justify-content-center mt-3">
                    <div class="col-12 col-md-8 text-center">
                        <asp:Button Text="Participar" ID="btnParticipar" CssClass="btn btn-primary w-100" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
