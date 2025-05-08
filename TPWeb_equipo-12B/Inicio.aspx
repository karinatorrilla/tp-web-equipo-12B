<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TPWeb_equipo_12B.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <figure class="text-center" style="margin-top: 30px">
        <h1 class="display-5">¡Bienvenido!</h1>
        <p class="lead">
            Acá podés canjear increíbles premios.
        </p>
    </figure>

    <div class="container" style="margin-top: 40px">
        <div class="text-center" style="max-width: 300px; margin: 0 auto;">
            <div class="mb-3">
                <asp:Label Text="Ingresá el código de tu voucher:" ID="lblIngresaVoucher" CssClass="form-label" runat="server" />
                <asp:TextBox type="text" CssClass="form-control text-center" ID="txtboxVoucher" placeholder="XXXXXXXXXXXX" required="true" runat="server">
                </asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptarVoucher" OnClick="btnAceptarVoucher_Click" CssClass="btn btn-primary" runat="server" />
                <div>
                    <asp:Label Text="¡Voucher ya canjeado, intente con uno nuevo!" ID="lblVoucherCanjeado" Visible="false" CssClass="form-label" runat="server" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
