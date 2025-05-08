<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWeb_equipo_12B.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Inicio</title>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js" integrity="sha384-j1CDi7MgGQ12Z7Qab0qlWQ/Qqz24Gc6BM0thvEMVjHnfYGF0rmFCozFSxQBxwHKO" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4Q6Gf2aSP4eDXB8Miphtr37CMZZQ5oXLH2yaXMJ2w8e2ZtHTl7GptT4jmndRuHDT" crossorigin="anonymous" />

</head>
<body style="background-image: linear-gradient(to right, #4080bf, #9fbfdf)">
    <form id="form1" runat="server">

        <header style="background-color: #333333; padding: 30px">
        </header>

        <figure class="text-center" style="margin-top: 30px">
            <h1 class="display-5">¡Bienvenido!</h1>
            <p class="lead">
                Acá podés ganar increíbles premios.
            </p>
        </figure>

        <div class="container" style="margin-top: 40px">
            <div class="text-center" style="max-width: 300px; margin: 0 auto;">
                <div class="mb-3">
                    <asp:Label Text="Ingresá el código de tu voucher:" ID="lblIngresaVoucher" CssClass="form-label" runat="server" />
                    <asp:TextBox type="text"  CssClass="form-control text-center" ID="txtboxVoucher" placeholder="XXXXXXXXXXXX" required="true" runat="server">
                    </asp:TextBox>

                </div>
                <div class="mb-3">
                    <asp:Button Text="Aceptar" ID="btnAceptarVoucher" OnClick="btnAceptarVoucher_Click" CssClass="btn btn-primary" runat="server" />
                    <div>

                        <asp:Label Text="Voucher ya canjeado, intente con uno nuevo" ID="lblVoucherCanjeado" Visible="false" CssClass="form-label" runat="server" />
                    </div>
                </div>
            </div>
        </div>

    </form>
    
</body>
</html>
