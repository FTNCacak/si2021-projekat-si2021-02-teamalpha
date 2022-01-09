using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Models;
using Shared.Interfaces;
using Data_Layer;
using Business_Layer;

namespace Presentation_Layer
{
    public partial class MainForm : Form
    {
        readonly IUserBusiness userBusiness;

        public MainForm(IUserBusiness _userBusiness)
        {
            userBusiness = _userBusiness;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userBusiness.RegisterUser(new User
            {
                Email = txtEmail.Text,
                Lozinka = txtPassowrd.Text,
                Ime = "Petar",
                Prezime = "Petrovic",
                Broj_telefona = "065-516-0718",
                Stanodavac = false,
                Datum_rodjenja = DateTime.Parse("01/01/2001")
            }) ;
        }
    }
}
