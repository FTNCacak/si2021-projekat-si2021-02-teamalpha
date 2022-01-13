<%@ Page Title="" Language="C#" MasterPageFile="~/AlphaBooking.Master" AutoEventWireup="true" CodeBehind="Apartments.aspx.cs" Inherits="Web_Presentation_Layer.Dashboard_Pages.Apartments" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">

    <link href="CSS/style.css" rel="stylesheet" />
    <style>
        .heading {
        font-family: 'Poppins', sans-serif;
        font-weight: 500;
        color: rgb(33, 33, 33);
        }
    </style>

    <script>
        function ajde(eval) {
            alert(eval);
        }
    </script>

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
                <asp:Repeater runat="server" ID="cardRepeater">
                    <ItemTemplate>
                        <div class="col md-3" runat="server" id="test">
                            <div class="card p-0">
                            <img src="https://source.unsplash.com/600x400/?interior" class="card-img-top p-0 m-0">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("Mesto") %></h5>
                                <p class="card-text lead">
                                    Apartman od <%#Eval("Kvadratura") %> <i>m</i><sup>2</sup> 
                                    <br />
                                    Broj soba: <%#Eval("Broj_soba") %>
                                    <br />
                                    Već od <span class="fw-normal"><%#Eval("Cena_nocenja") %> € </span>
                                </p>              
                                
                            </div>
                        </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>    
</asp:Content>
