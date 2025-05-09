<%@ Page Title="Premios" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="PaginaPremios.aspx.cs" Inherits="TPWeb_equipo_12B.PaginaPremios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Repeater ID="RepeaterPremios" runat="server">

        <ItemTemplate>
            
            <div class="col-sm-12">
            <h2>Artículo ID: <%# Eval("ArticuloId") %></h2>
            
            <asp:Repeater ID="RepeaterImagenes" runat="server" DataSource='<%# Eval("Imagenes") %>'>
                <ItemTemplate>
                    <img src='<%# Eval("ImagenUrl") %>' class="object-fit-contain border rounded" alt="Premio" style="width:150px; height:150px;">
                </ItemTemplate>
            </asp:Repeater>
        </div>

            
        </ItemTemplate>
    </asp:Repeater>




</asp:Content>
