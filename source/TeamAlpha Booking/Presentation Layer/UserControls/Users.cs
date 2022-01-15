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
using Shared.Models;

namespace Presentation_Layer.UserControls
{
    public partial class Users : UserControl
    {
        readonly IUserBusiness userBusiness;
        public Users(IUserBusiness _userBusiness)
        {
            userBusiness = _userBusiness;
            InitializeComponent();
            initializeDGW(this.userDGW);
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        public void test()
        {

        }

        private void initializeDGW(System.Windows.Forms.DataGridView dgw)
        {

            List<User> list = userBusiness.GetAllUsers();
            foreach (User a in list)
            {
                string[] newItem = {a.Id_Korisnika.ToString(), "**********", a.Ime,
                a.Prezime, a.Email, a.Datum_rodjenja.ToString(),
                (a.Broj_telefona != null ? a.Broj_telefona : "/"), (a.Stanodavac ? "Stanodavac" : "Korisnik") };
                userDGW.Rows.Add(newItem);
            }
        }
    }
}
