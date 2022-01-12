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
    public partial class Dashboard : System.Web.UI.Page
    {       
        private readonly IUserBusiness userBusiness;

        public Dashboard(IUserBusiness _userBusiness)
        {
            userBusiness = _userBusiness;
        }

        private User currentUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetNoStore();
            if(!IsPostBack) //if page is being loaded for the first time
            {
                if(Session["currentUserEmail"] != null)
                {
                    string currentUserEmail = Session["currentUserEmail"].ToString();
                    currentUser = userBusiness.GetUserByEmail(currentUserEmail);

                    labelUserEmail.Text = currentUser.Email;
                    labelUserFirstname.Text = currentUser.Ime;
                    labelUserID.Text = currentUser.Id_Korisnika.ToString();
                }

                else
                {
                   
                        Session.Remove("currentUserEmail");
                        Session.RemoveAll();
                        Response.Redirect("Login.aspx");
                    
                }
            }
           

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("currentUserEmail");
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }
    }
}