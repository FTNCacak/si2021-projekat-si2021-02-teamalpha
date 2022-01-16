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
        readonly IRentBusiness rentBusiness;

        public Apartments(IApartmentBusiness _aptBusiness, IRentBusiness _rentBusiness)
        {
            aptBusiness = _aptBusiness;
            rentBusiness = _rentBusiness;
            InitializeComponent();
            initializeDGW();
        }

        private void Apartments_Load(object sender, EventArgs e)
        {
            
        }


        public void initializeDGW()
        {
            apartmentDGW.Rows.Clear();
            List<Apartment> list = aptBusiness.GetAllApartments();
            foreach (Apartment a in list)
            {
                string[] newItem = {a.Id_Stana.ToString(), a.Mesto, a.Adresa,
                a.Broj_soba.ToString(),a.Kvadratura.ToString(), a.Postanski_broj.ToString(),
                a.Cena_nocenja.ToString(), a.Depozit.ToString(), a.Broj_sprata.ToString(),
                a.Id_Korisnika.ToString()};
                apartmentDGW.Rows.Add(newItem);
            }
        }

        private void apartmentDGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void buttonDelete_Click(object sender, MouseEventArgs e)
        {
            if (apartmentDGW.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Ova akcija će takođe obrisati i sve rente povezane s ovim oglasom. Nastaviti?", "Confirm", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    int res1 = rentBusiness.DeleteRentByApartment(Convert.ToInt32(apartmentDGW.SelectedRows[0].Cells[0].Value));
                    int res2 = aptBusiness.RemoveApartment(Convert.ToInt32(apartmentDGW.SelectedRows[0].Cells[0].Value));
                    MessageBox.Show((res2 == 1) ? "Uspešno obrisano." : "Greška: Operacija brisanja nije uspela.");
                    initializeDGW();
                } else if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    // do nothing
                }
            }
        }
    }
}
