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


        public Apartments(IApartmentBusiness _apartmentBusiness)
        {
            apartmentBusiness = _apartmentBusiness;
        }

        private List<Apartment> apartments = new List<Apartment>();


        protected void Page_Load(object sender, EventArgs e)
        {
            apartments = apartmentBusiness.GetAllApartments();
            cardRepeater.DataSource = apartments;        
            cardRepeater.DataBind();          
        }

        protected void Page_Init(object sender, EventArgs e)
        {
      
        }
    }
}