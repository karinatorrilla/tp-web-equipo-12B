<%@ Page Title="Premios" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="PaginaPremios.aspx.cs" Inherits="TPWeb_equipo_12B.PaginaPremios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container-fluid bg-warning d-flex flex-column">
        <div class="row">
            <div class="col-12 text-center">
                <h1 class="my-4">Productos</h1>
            </div>
        </div>
        <div class="row justify-content-center">
            <asp:Repeater ID="RepeaterPremios" runat="server">
                <ItemTemplate>
                    <div class="col-12 col-md-6 col-lg-4 mb-4">
                        <div class="card h-100" style="width: 18rem;">
                            <img
                                src="<%# ObtenerImagenUrl(Eval("Id"))[0] %>"
                                class="card-img-top"
                                alt="<%# Eval("Nombre") %>"
                                style="max-height: 200px; object-fit: cover;"
                            />
                            <div class="card-body d-flex flex-column">
                                <h5 class="card-title"><%# Eval("Nombre") %></h5>
                                <button
                                    type="button"
                                    class="btn btn-primary mt-auto"
                                    data-bs-toggle="modal"
                                    data-bs-target="#productoModal"
                                    onclick="mostrarModal('<%# ObtenerImagenUrl(Eval("Id"))[0] %>', '<%# Eval("Nombre") %>', '<%# Eval("Descripcion") %>', '<%# Eval("Precio", "{0:C}") %>', '<%# Eval("Id") %>')">
                                    Ver Detalles
                                </button>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <div class="modal fade" id="productoModal" tabindex="-1"
        aria-labelledby="productoModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="productoModalLabel">Detalles del Producto</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal"
                        aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <img id="modalImagen" src="" class="card-img-top"
                        style="max-height: 150px; object-fit: cover;" />
                    <h3 id="modalNombre"></h3>
                    <p id="modalDescripcion"></p>
                    <p id="modalPrecio"></p>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar este!"
                        CssClass="btn btn-success" OnClick="btnSeleccionar_Click" />
                </div>
            </div>
        </div>
    </div>


</asp:Content>
