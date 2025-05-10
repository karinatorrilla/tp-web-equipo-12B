<%@ Page Title="Premios" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="PaginaPremios.aspx.cs" Inherits="TPWeb_equipo_12B.PaginaPremios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row column-gap-md-1">

        <asp:Repeater ID="RepeaterPremios" runat="server">

            <ItemTemplate>

                <div class="card" style="width: 18rem;">
                    <img src="<%#Eval("ImagenUrl")%>" class="card-img-top w-25" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Articulo.Nombre") %></h5>
                        <p class="card-text"><%#Eval("Articulo.Descripcion") %></p>
                        <a href="#" class="btn btn-primary">Boton</a>
                    </div>
                </div>

            </ItemTemplate>
        </asp:Repeater>

    </div>



</asp:Content>
