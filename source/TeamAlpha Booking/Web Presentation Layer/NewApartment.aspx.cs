using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared.Interfaces;
using Shared.Models;

namespace Web_Presentation_Layer
{
    public partial class NewApartment : System.Web.UI.Page
    {
        readonly IApartmentBusiness apartmentBusiness;
        readonly IUserBusiness userBusiness;

        private User currentUser;

        public NewApartment(IApartmentBusiness _apartmentBusiness, IUserBusiness _userBusiness)
        {
            apartmentBusiness = _apartmentBusiness;
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
            if (currentUser == null && Session["currentUserEmail"] != null)
            {
                string currentUserEmail = Session["currentUserEmail"].ToString();
                currentUser = userBusiness.GetUserByEmail(currentUserEmail);
            }
        }

        protected void AddApartmentBtn_Click(object sender, EventArgs e)
        {

            if (!(inputPlace.Text == "" || inputAddress.Text == "" || inputNoRooms.Text == "" ||
                  inputSize.Text == "" || inputZipCode.Text == "" || inputFloor.Text == "" 
                  || inputNightPrice.Text == "" || inputDeposit.Text == ""))
            {
                string Place = inputPlace.Text;
                string Address = inputAddress.Text;
                int NoRooms = Int32.Parse(inputNoRooms.Text);
                int Size = Int32.Parse(inputSize.Text);
                int Zip = Int32.Parse(inputZipCode.Text);
                Decimal NightPrice = Decimal.Parse(inputNightPrice.Text);
                Decimal Deposit = Decimal.Parse(inputDeposit.Text);
                int Floor = Int32.Parse(inputFloor.Text);

                Apartment apartment = new Apartment
                {
                    Mesto = Place,
                    Adresa = Address,
                    Broj_soba = NoRooms,
                    Kvadratura = Size,
                    Postanski_broj = Zip,
                    Cena_nocenja = NightPrice,
                    Depozit = Deposit,
                    Broj_sprata = Floor,
                    Id_Korisnika = currentUser.Id_Korisnika
                };

                if(apartmentBusiness.InsertApartment(apartment) == 1)
                {
                    Alert("Oglas uspešno postavljen!");
                }

                else
                {
                    Alert("Nije moguće postaviti oglas.");
                }               
            }
            else
            {
                Alert("Popuni sva polja.");
            }
        }

        private void Alert(string message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{message}')", true);
        }
    }
}