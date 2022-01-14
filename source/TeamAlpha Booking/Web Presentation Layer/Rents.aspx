<%@ Page Title="" Language="C#" MasterPageFile="~/AlphaBooking.Master" AutoEventWireup="true" CodeBehind="Rents.aspx.cs" Inherits="Web_Presentation_Layer.Rents" %>
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
                <h1 class="heading mt-2">Rente</h1>
                <p class="lead">
                    Pregled renti
                </p>
            </div>
            <div class="row mt-3 px-1" id="tableHolder">
                <table class="table table-dark table-striped mx-2">
                    <thead>
                        <tr class="table-dark">
                            <td>ID Rente</td>                        
                            <td>Datum početka</td>
                            <td>Broj dana</td>
                            <td>Broj kartice</td>
                            <td>ID Stana</td>  
                            <td>ID Stanodavca</td>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="tableRowRepeater" OnItemCommand="tableRowRepeater_ItemCommand">
                            <ItemTemplate>
                                <tr class="table-dark">
                                    <td><%#Eval("Id_Rente") %></td>
                                    <td><%#Eval("Datum_pocetka") %></td>
                                    <td><%#Eval("Broj_dana") %></td>
                                    <td><%#Eval("Broj_kartice") %></td>
                                    <td><%#Eval("Id_Stana") %></td>
                                    <td><%#Eval("Id_Stanodavca") %></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>               
            </div>
        </div>    
</asp:Content>
