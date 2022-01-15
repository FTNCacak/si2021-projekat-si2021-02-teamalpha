<%@ Page Title="" Language="C#" MasterPageFile="~/AlphaBooking.Master" AutoEventWireup="true" CodeBehind="NewApartment.aspx.cs" Inherits="Web_Presentation_Layer.NewApartment" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <style>
        .heading {
            font-family: 'Poppins', sans-serif;
            font-weight: 500;
            color: rgb(33, 33, 33);
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
            <div class="row">
                <h1 class="heading mt-2">Dodaj oglas</h1>
                <p class="lead">
                    Popuni sva polja i postavi novi oglas
                </p>
            </div>
        <div class="row">
            <div class="col-lg-4 px-3 py-2">
                <div class=" mt-4 shadow p-4">
                    <h4>
                        Uputstvo
                    </h4>
                    <p class="lead">Popuni dati formular i dodaj novi stan na AlphaBooking platformu.</p>
                    <h4>
                        Kontakt
                    </h4>
                    <p class="lead">Ukoliko imaš problema pri postavljanju oglasa kontaktiraj nas.</p>
                    
                    <p class="lead fw-normal"><i class="bi bi-envelope-fill"></i> support@alphabooking.com</p>
                    <p class="lead fw-normal"><i class="bi bi-telephone-fill"></i> 065-516-0718</p>
                </div>
            </div>
            
            <div class="col-lg-8 px-3 py-2">
                <div class="mt-4 shadow p-4 ">
                    <div class="row">
                        <div class="form-group mb-3 col-4">
                            <label class="form-label">Mesto</label>
                            <asp:TextBox ID="inputPlace" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group mb-3 col-4">
                            <label class="form-label">Adresa</label>
                            <asp:TextBox ID="inputAddress" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group mb-3 col-4">
                            <label class="form-label">Poštanski broj</label>
                            <asp:TextBox ID="inputZipCode" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row">
                        <div class="form-group mb-3 col-4">
                            <label class="form-label">Broj soba</label>
                            <asp:TextBox ID="inputNoRooms" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group mb-3 col-4">
                            <label class="form-label">Kvadratura</label>
                            <asp:TextBox ID="inputSize" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group mb-3 col-4">
                            <label class="form-label">Sprat</label>
                            <asp:TextBox ID="inputFloor" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row">
                        <div class="form-group mb-3 col-6">
                            <label class="form-label">Cena noćenja</label>
                            <asp:TextBox ID="inputNightPrice" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group mb-3 col-6">
                            <label class="form-label">Depozit</label>
                            <asp:TextBox ID="inputDeposit" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="d-grid mb-2">
                        <asp:LinkButton ID="AddApartmentBtn" runat="server" CssClass="btn btn-lg btn-primary btn-login fw-bold text-uppercase" OnClick="AddApartmentBtn_Click">Postavi oglas</asp:LinkButton>
                    </div>
                </div>
           
        </div>
            </div>
            
        </div>    
</asp:Content>
