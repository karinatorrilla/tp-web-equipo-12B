<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="PaginaMensaje.aspx.cs" Inherits="TPWeb_equipo_12B.PaginaMensaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid d-flex flex-column align-items-center justify-content-center" style="min-height: 80vh;">
        <div class="text-center">
            <h2 class="text-danger font-weight-bold">
                Código incorrecto o este ya ha sido usado!
            </h2>
            <div class="mt-3">
                <asp:Button ID="btnIrInicio" OnClick="btnIrInicio_Click" CssClass="btn btn-primary" runat="server" Text="Ir a Inicio" />
            </div>
        </div>
    </div>

</asp:Content>
