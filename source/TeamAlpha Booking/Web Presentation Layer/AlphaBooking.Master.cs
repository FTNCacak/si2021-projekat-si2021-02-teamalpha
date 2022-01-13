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
    public partial class AlphaBooking : System.Web.UI.MasterPage
    {
        private readonly IUserBusiness userBusiness;
        private User currentUser;

        public AlphaBooking(IUserBusiness _userBusiness)
        {
            userBusiness = _userBusiness;
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            logOutLink.ServerClick += new EventHandler(logOutLink_ServerClick);
        }

        private void logOutLink_ServerClick(object sender, EventArgs e)
        {
            Logout();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //if page is being loaded for the first time
            {
                if (Session["currentUserEmail"] != null)
                {
                    string currentUserEmail = Session["currentUserEmail"].ToString();
                    currentUser = userBusiness.GetUserByEmail(currentUserEmail);

                    currentUserFirstName.Text = currentUser.Ime;
                    addRentLink.Visible = currentUser.Stanodavac;
                    userRole.Text = currentUser.Stanodavac ? "Stanodavac" : "Korisnik";
                }

                else
                {
                    Logout();
                }
            }
            else
            {
                //Logout();
            }
         
        }

        private void Logout()
        {
            Session.Remove("currentUserEmail");
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }

        
    }
}