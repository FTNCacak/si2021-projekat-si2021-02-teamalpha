<%@ Page Title="" Language="C#" MasterPageFile="~/AlphaBooking.Master" AutoEventWireup="true" CodeBehind="Apartments.aspx.cs" Inherits="Web_Presentation_Layer.Dashboard_Pages.Apartments" %>
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
                <h1 class="heading mt-2">Ponuda smeštaja</h1>
                <p class="lead">
                    Pronađi smeštaj kakav ti odgovara.
                </p>
            </div>
            <div class="row mt-3" id="cardHolder">
                <asp:Repeater runat="server" ID="cardRepeater" onitemcommand="cardRepeater_ItemCommand">
                    <ItemTemplate>
                        <div class="col-sm-12 col-md-4 col-lg-3" runat="server" id="test">
                            <div class="card p-0 mb-3">
                                <div class="card-body">
                                    <div class="d-flex justify-content-between">
                                        <h5 class="card-title"><%#Eval("Mesto")%></h5>
                                        <h6 class="text-white rounded-2 bg-secondary p-2" style="margin-top: -5px;">#<%#Eval("Id_Stana")%></h6>
                                    </div>

                                    <p class="card-text lead">
                                        Apartman od <%#Eval("Kvadratura") %> <i>m</i><sup>2</sup>
                                        <br />
                                        Broj soba: <%#Eval("Broj_soba") %>
                                        <br />
                                        Već od <span class="fw-normal"><%#Eval("Cena_nocenja") %> € </span>
                                    </p>
                                    <hr />
                                    <div class="mb-3">
                                        <label class="form-label">Broj dana</label>
                                        <asp:TextBox runat="server" ID="NoDays" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="mb-3">
                                        <label class="form-label">Broj kartice</label>
                                        <asp:TextBox runat="server" ID="CardNumber" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <asp:LinkButton ID="btnRent" runat="server" CssClass="btn btn-primary w-100" CommandName="Rent" CommandArgument='<%# Eval("Id_Stana") %>' UseSubmitBehavior="false">Iznajmi</asp:LinkButton>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>    
</asp:Content>
