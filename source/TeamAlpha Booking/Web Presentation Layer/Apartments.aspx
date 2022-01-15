<%@ Page Title="" Language="C#" MasterPageFile="~/AlphaBooking.Master" AutoEventWireup="true" CodeBehind="Apartments.aspx.cs" Inherits="Web_Presentation_Layer.Dashboard_Pages.Apartments" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <style>
        .heading {
            font-family: 'Poppins', sans-serif;
            font-weight: 500;
            color: rgb(33, 33, 33);
        }
        .card-image-custom {
            background: url('https://socialistmodernism.com/wp-content/uploads/2017/07/placeholder-image.png?w=640') no-repeat center center/cover;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h1 class="heading mt-2">Ponuda smeštaja</h1>
            <p class="lead">
                Pronađi smeštaj kakav ti odgovara.
            </p>
        </div>           
        <asp:Repeater runat="server" ID="cardRepeater" onitemcommand="cardRepeater_ItemCommand">
            <ItemTemplate>
                <div class="row mt-3 border" id="cardHolder">
                    <!-- CARD -->
                    <div class="col-2 bg-secondary d-sm-none d-md-none d-lg-none d-xl-block p-0 card-image-custom">
                        <!-- IMAGE SET IN CSS -->
                    </div>
                    <div class="col-3 p-3">
                        <div class="d-flex ">
                            <h4 class="card-title me-4"><%#Eval("Mesto")%>
                                <span class="text-muted">#<%#Eval("Id_Stana")%></span>
                            </h4>
                        </div>
                        <p class="lead my-1">Kvadratura: <span class="fw-normal"><%#Eval("Kvadratura") %> <i>m</i><sup>2</sup></span></p>
                        <p class="lead my-1">Broj soba: <span class="fw-normal"><%#Eval("Broj_soba") %></span></p>
                        <p class="lead my-1">Sprat: <span class="fw-normal"><%#Eval("Broj_sprata") %></span></p>
                        <p class="lead my-1">Adresa: <span class="fw-normal"><%#Eval("Adresa") %></span></p>
                    </div>
                    <div class="col-3 p-3">
                        <h4 class="card-title me-4">Detalji</h4>
                        <p class="lead my-1">Depozit: <span class="fw-normal"><%#Eval("Depozit") %> € </span</p>                    
                        <p class="lead my-1">Noćenje: <span class="fw-normal"><%#Eval("Cena_nocenja") %> € </span></p>                                 
                        <p class="lead my-1">Poštanski broj: <span class="fw-normal"><%#Eval("Postanski_broj") %></span></p>
                    </div>
                    <div class="col-4 p-3">
                        <h4 class="card-title me-4 mb-4">Iznajmljivanje</h4>
                        <div class="row">
                            <div class="col-2 mb-3">
                            <label class="form-label">Dana</label>
                            <asp:TextBox runat="server" ID="NoDays" CssClass="form-control d-inline"></asp:TextBox>
                        </div>
                        <div class="col-10 mb-3">
                            <label class="form-label">Broj kartice</label>
                            <asp:TextBox runat="server" ID="CardNumber" CssClass="form-control"></asp:TextBox>
                        </div>
                        </div>
                        
                        <asp:LinkButton ID="btnRent" runat="server" CssClass="btn btn-primary w-100" CommandName="Rent" CommandArgument='<%# Eval("Id_Stana") %>' UseSubmitBehavior="false">Zakaži smeštaj</asp:LinkButton>
                    </div>

                    
                </div>
                       
            </ItemTemplate>
        </asp:Repeater>
        </div>          
</asp:Content>
