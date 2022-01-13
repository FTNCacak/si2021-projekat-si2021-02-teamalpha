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
    public partial class Apartments : UserControl
    {
        readonly IApartmentBusiness aptBusiness;

        public Apartments(IApartmentBusiness _aptBusiness)
        {
            aptBusiness = _aptBusiness;
            InitializeComponent();
            initializeDGW(apartmentDGW);
        }

        private void Apartments_Load(object sender, EventArgs e)
        {
            
        }


        private void initializeDGW(System.Windows.Forms.DataGridView dgw)
        {

            List<Apartment> list = aptBusiness.GetAllApartments();
            foreach (Apartment a in list)
            {
                string[] newItem = {a.Id_Stana.ToString(), a.Mesto, a.Adresa,
                a.Broj_soba.ToString(),a.Kvadratura.ToString(), a.Postanski_broj.ToString(),
                a.Cena_nocenja.ToString(), a.Depozit.ToString(), a.Broj_sprata.ToString(),
                a.Id_Korisnika.ToString()};
                dgw.Rows.Add(newItem);
            }
        }

        private void apartmentDGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
