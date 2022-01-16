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
    public partial class Rents : System.Web.UI.Page
    {
        readonly IApartmentBusiness apartmentBusiness;
        readonly IRentBusiness rentBusiness;
        readonly IUserBusiness userBusiness;

        private User currentUser;

        private List<Rent> rentList = new List<Rent>();

        public Rents(IApartmentBusiness _apartmentBusiness, IRentBusiness _rentBusiness, IUserBusiness _userBusiness)
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
            if (currentUser == null && Session["currentUserEmail"] != null)
            {
                string currentUserEmail = Session["currentUserEmail"].ToString();
                currentUser = userBusiness.GetUserByEmail(currentUserEmail);
            }
            
            if (currentUser != null)
            {
                rentList = rentBusiness.GetUserRents(currentUser.Id_Korisnika);
                tableRowRepeater.DataSource = rentList;
                tableRowRepeater.DataBind();
            }
            
        }

        protected void tableRowRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}