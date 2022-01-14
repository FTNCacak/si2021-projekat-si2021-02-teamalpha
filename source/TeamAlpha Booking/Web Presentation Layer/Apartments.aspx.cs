using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared.Interfaces;
using Shared.Models;

namespace Web_Presentation_Layer.Dashboard_Pages
{
    public partial class Apartments : System.Web.UI.Page
    {
        readonly IApartmentBusiness apartmentBusiness;
        readonly IRentBusiness rentBusiness;
        readonly IUserBusiness userBusiness;

        public User currentUser;

        private List<Apartment> apartmentList = new List<Apartment>();
        private int apartmentID;
        private Apartment selectedAppartment;

        TextBox TB_NoDays;
        TextBox TB_CardNumber;

        public Apartments(IApartmentBusiness _apartmentBusiness, IRentBusiness _rentBusiness, IUserBusiness _userBusiness)
        {
            apartmentBusiness = _apartmentBusiness;
            rentBusiness = _rentBusiness;
            userBusiness = _userBusiness;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["currentUserEmail"] != null)
                {
                    string currentUserEmail = Session["currentUserEmail"].ToString();
                    currentUser = userBusiness.GetUserByEmail(currentUserEmail);
                }
            }
            catch (Exception)
            {
                Session.Remove("currentUserEmail");
                Session.RemoveAll();
                Response.Redirect("Login.aspx");
                throw;
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            apartmentList = apartmentBusiness.GetAllApartments();
            cardRepeater.DataSource = apartmentList;
            cardRepeater.DataBind();
        }

        protected void cardRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            TB_NoDays = (TextBox)e.Item.FindControl("NoDays");
            TB_CardNumber = (TextBox)e.Item.FindControl("CardNumber");

            if(e.CommandName == "Rent")
            {
                apartmentID = Int32.Parse(e.CommandArgument.ToString());
                selectedAppartment = apartmentBusiness.GetApartmentByID(apartmentID);

                if (!(TB_NoDays.Text.Equals("") || TB_CardNumber.Text.Equals("")))
                {
                    int NoDays = Int32.Parse(TB_NoDays.Text);
                    string CardNumber = TB_CardNumber.Text;

                    if (!(NoDays <= 0))
                    {
                        Rent rent;
                        try
                        {
                            rent = new Rent
                            {
                                Datum_pocetka = DateTime.Now,
                                Broj_dana = NoDays,
                                Nacin_placanja = true,
                                Broj_kartice = CardNumber,
                                Id_Korisnika = currentUser.Id_Korisnika,
                                Id_Stana = selectedAppartment.Id_Stana,
                                Id_Stanodavca = selectedAppartment.Id_Korisnika,
                            };
                        }
                        catch (Exception)
                        {
                            Session.Remove("currentUserEmail");
                            Session.RemoveAll();
                            Response.Redirect("Login.aspx");
                            throw;
                        }

                        if (rentBusiness.InsertRent(rent) == 1)
                        {
                            Alert("Stan iznajmljen.");
                            TB_NoDays.Text = "";
                            TB_CardNumber.Text = "";
                        }  
                        else
                        {
                            Alert("Nije moguće iznajmiti stan.");
                        }
                    }
                    else
                    {
                        Alert("Broj dana mora biti veći od nula!");
                    }                   
                }

                else
                {
                    Alert("Popuni sva polja!");
                }             
            }
        }

        private void Alert(string message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{message}')", true);
        }
    }
}