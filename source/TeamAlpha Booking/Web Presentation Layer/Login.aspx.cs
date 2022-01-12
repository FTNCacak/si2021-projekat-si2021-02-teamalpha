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
    public partial class Login : System.Web.UI.Page
    {
        private readonly IUserBusiness userBusiness;

        public Login(IUserBusiness _userBusiness)
        {
            userBusiness = _userBusiness;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = Request["floatingEmail"];
            string password = Request["floatingPassword"];
            
            if (userBusiness.CheckPassword(email, password))
            {
                // proslediti email usera preko sesije na dashboard
                // na dashboardu u load eventu pozvati getUserByEmail 

                Session["currentUserEmail"] = email;
                Response.Redirect("Dashboard.aspx");
            }       
            else
            {
                Alert("Nije pronađen korisnik sa unetim podacima. Pokušaj ponovo.");
            }
        }


        private void Alert(string message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('{message}')", true);
        }

    }
}