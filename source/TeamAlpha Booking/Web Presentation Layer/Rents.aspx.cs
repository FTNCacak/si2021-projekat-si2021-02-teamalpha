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
        private readonly IUserBusiness userBusiness;
        private readonly IRentBusiness rentBusiness;
        private readonly IApartmentBusiness apartmentBusiness;

        public User currentUser;

        public Rents(IUserBusiness _userBusiness, IRentBusiness _rentBusiness, IApartmentBusiness _apartmentBusiness)
        {
            userBusiness = _userBusiness;
            rentBusiness = _rentBusiness;
            apartmentBusiness = _apartmentBusiness;
        }
     

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //if page is being loaded for the first time
            {
                if (Session["currentUserEmail"] != null)
                {
                    string currentUserEmail = Session["currentUserEmail"].ToString();
                    currentUser = userBusiness.GetUserByEmail(currentUserEmail);
                }
            }
        }
    }
}