using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Interfaces;

namespace Presentation_Layer.UserControls
{
    public partial class Overview : UserControl
    {

        readonly IUserBusiness userBusiness;
        readonly IApartmentBusiness apartmentBusiness;
        readonly IRentBusiness rentBusiness;

        public Overview(IUserBusiness _userBusiness,IApartmentBusiness _apartmentBusiness,IRentBusiness _rentBusiness)
        {
            userBusiness = _userBusiness;
            apartmentBusiness = _apartmentBusiness;
            rentBusiness = _rentBusiness;

            InitializeComponent();
        }

        

        private void Overview_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            lblNumberOfUsers.Text = userBusiness.GetUserCount().ToString();
            lblNumberofApartments.Text = apartmentBusiness.GetApartmentCount().ToString();
            lblNumberofRents.Text = rentBusiness.GetRentCount().ToString();
            lblRevenue.Text = rentBusiness.CalculateRevenue().ToString();
        }
    }
}
