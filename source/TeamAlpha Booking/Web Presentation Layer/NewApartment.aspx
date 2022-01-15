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
                <h1 class="heading mt-2">Dodaj novi stan</h1>
                <p class="lead">
                    Popuni sva polja i dodaj novi oglas
                </p>
            </div>
        <div class="row">
            <div class="col-lg-10 col-xl-10 mt-4">
                <div>
                    <div class="form-group mb-3">
                        <label class="form-label">Mesto</label>
                        <asp:TextBox ID="inputPlace" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group mb-3">
                        <label class="form-label">Adresa</label>
                        <asp:TextBox ID="inputAddress" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    
                    <div class="form-group mb-3">
                        <label class="form-label">Broj soba</label>
                        <asp:TextBox ID="inputNoRooms" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group mb-3">
                        <label class="form-label">Kvadratura</label>
                        <asp:TextBox ID="inputSize" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group mb-3">
                        <label class="form-label">Poštanski broj</label>
                        <asp:TextBox ID="inputZipCode" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group mb-3">
                        <label class="form-label">Sprat</label>
                        <asp:TextBox ID="inputFloor" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group mb-3">
                        <label class="form-label">Cena noćenja</label>
                        <asp:TextBox ID="inputNightPrice" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group mb-3">
                        <label>Depozit</label>
                        <asp:TextBox ID="inputDeposit" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="d-grid mb-2">
                        <asp:LinkButton ID="AddApartmentBtn" runat="server" CssClass="btn btn-lg btn-primary btn-login fw-bold text-uppercase" OnClick="AddApartmentBtn_Click">Postavi oglas</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
        </div>    
</asp:Content>
