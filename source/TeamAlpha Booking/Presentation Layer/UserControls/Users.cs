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
        readonly IApartmentBusiness aptBusiness;
        readonly IRentBusiness rentBusiness;
        public Users(IUserBusiness _userBusiness, IApartmentBusiness _aptBusiness, IRentBusiness _rentBusiness)
        {
            userBusiness = _userBusiness;
            aptBusiness = _aptBusiness;
            rentBusiness = _rentBusiness;
            InitializeComponent();
            initializeDGW();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        public void test()
        {

        }

        public void initializeDGW()
        {
            userDGW.Rows.Clear();
            List<User> list = userBusiness.GetAllUsers();
            foreach (User a in list)
            {
                string[] newItem = {a.Id_Korisnika.ToString(), "**********", a.Ime,
                a.Prezime, a.Email, a.Datum_rodjenja.ToString(),
                (a.Broj_telefona != null ? a.Broj_telefona : "/"), (a.Stanodavac ? "Stanodavac" : "Korisnik") };
                userDGW.Rows.Add(newItem);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (userDGW.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Ova akcija će takođe obrisati i sve stanove kao i rente povezane s ovim korisnikom. Nastaviti?", "Confirm", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    int res1 = rentBusiness.DeleteRentByUserOrLandlord(Convert.ToInt32(userDGW.SelectedRows[0].Cells[0].Value));
                    int res2 = aptBusiness.RemoveApartmentByUser(Convert.ToInt32(userDGW.SelectedRows[0].Cells[0].Value));
                    int res3 = userBusiness.RemoveUser(Convert.ToInt32(userDGW.SelectedRows[0].Cells[0].Value));
                    MessageBox.Show((res3 == 1) ? "Uspešno obrisano." : "Greška: Operacija brisanja nije uspela.");
                    initializeDGW();
                }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    // do nothing
                }
            }
        }
    }
}
