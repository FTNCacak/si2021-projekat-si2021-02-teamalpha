using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared.Models;
using Shared.Interfaces;
using Business_Layer;
using System.Text.RegularExpressions;

namespace Web_Presentation_Layer
{
    public partial class Registration : System.Web.UI.Page
    {
        private readonly UserBusiness userBusiness = new UserBusiness();

   

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            string FirstName = "";
            string LastName = "";
            DateTime BirthDate;
            string Email = "";
            string PhoneNumber = "";
            string Password = "";
            string ConfirmPassword = "";
            bool IsHost = CheckBoxHost.Checked;

            if (!(Request["floatingInputFirstName"] == "" || Request["floatingInputLastName"] == "" || Request["floatingDate"] == null ||
                  Request["floatingInputEmail"] == "" || Request["floatingPassword"] == "" || Request["floatingPasswordConfirm"] == "" || Request["PhoneNumber"] == ""))
            {
                FirstName = Request["floatingInputFirstName"];
                LastName = Request["floatingInputLastName"];
                BirthDate = DateTime.Parse(Request["floatingDate"]);
                Email = Request["floatingEmail"];
                Password = Request["floatingPassword"];
                ConfirmPassword = Request["floatingPasswordConfirm"];
                PhoneNumber = Request["floatingPhone"];

                if (ValidateData(FirstName, LastName, BirthDate, Email, PhoneNumber, Password, ConfirmPassword)) // if all data is valid
                {
                    User user = new User
                    {
                        Ime = FirstName,
                        Prezime = LastName,
                        Datum_rodjenja = BirthDate,
                        Email = Email,
                        Lozinka = Password,
                        Broj_telefona = PhoneNumber,
                        Stanodavac = IsHost
                    };

                    if (userBusiness.RegisterUser(user) != 1)
                    {
                        Alert("Email je već u upotrebi!");
                    }

                    Alert("Uspešna registracija. Možeš se prijaviti.");
                }                   
            }
            else
            {
                Alert("Popuni sva polja.");
            }
        }

        private bool ValidateData(string FirstName, string LastName, DateTime BirthDate, string Email, string PhoneNumber ,string Password, string ConfirmPassword)
        {
            if(!IsEmailValid(Email))
            {
                Alert("Neispravan email!");
                return false;
            }

            if(!Password.Equals(ConfirmPassword))
            {
                Alert("Lozinke nisu iste!");
                return false;
            }

            if(!IsUserAdult(BirthDate))
            {
                Alert("Korisnik mora biti punoletan!");
                return false;
            }

            if(!IsNameValid(FirstName))
            {
                Alert("Neispravan unos imena.");
                return false;
            }

            if(!IsNameValid(LastName))
            {
                Alert("Neispravan unos prezimena.");
                return false;
            }

            if(!IsPhoneValid(PhoneNumber))
            {
                Alert("Neispravan unos broja telefona. Unesi broj u formatu: nnn-nnn-nnnn");
                return false;
            }

            return true;
        }

        private bool IsPhoneValid(string Phone)
        {
            string reg = @"^\d{3}-\d{3}-\d{4}$";
            return Regex.IsMatch(Phone, reg);
        }

        private bool IsNameValid(string name)
        {
            string reg = @"^[A-Z][a-z]*$";
            return Regex.IsMatch(name, reg);
        }

        private bool IsEmailValid(string Email)
        {
            string EmailRegex = @"^[a-z][^\@\s]+\@[^\@\s]+\.[^\@\s]+$"; //prvo slovo malo, jedan znak @, barem jedan karakter pre @, znak .

            return Regex.IsMatch(Email, EmailRegex, RegexOptions.IgnoreCase);
        }

        private bool IsUserAdult(DateTime BirthDate)
        {
            return DateTime.Now.Subtract(BirthDate).TotalDays >= 6570;
        }

        private void Alert(string message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{message}')", true);
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}