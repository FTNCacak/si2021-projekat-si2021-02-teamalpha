using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Models;
using Shared.Interfaces;

namespace Presentation_Layer.UserControls
{
    public partial class Rents : UserControl
    {
        readonly IRentBusiness rentBusiness;
        readonly IUserBusiness userBusiness;
        public Rents(IRentBusiness _rentBusiness, IUserBusiness _userBusiness)
        {
            this.rentBusiness = _rentBusiness;
            this.userBusiness = _userBusiness;
            InitializeComponent();
            initializeDGW();
        }

        public void initializeDGW()
        {
            rentDGW.Rows.Clear();
            List<Rent> list = rentBusiness.GetAllRents();
            foreach (Rent a in list)
            {
                string[] newItem = {a.Id_Rente.ToString(), a.Datum_pocetka.ToString(), a.Broj_dana.ToString(),
                (a.Nacin_placanja ? "Gotovina" : "Kartica"),a.Broj_kartice != null ? a.Broj_kartice : "/", userBusiness.GetUserNameById(a.Id_Korisnika),
                a.Id_Stana.ToString(), userBusiness.GetUserNameById(a.Id_Stanodavca)};
                rentDGW.Rows.Add(newItem);
            }
        }
        private void buttonDelete_Click(object sender, MouseEventArgs e)
        {
            if (rentDGW.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Da li ste sigurno da želite da obrišete ovu stavku?", "Confirm", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    int res1 = rentBusiness.RemoveRent(Convert.ToInt32(rentDGW.SelectedRows[0].Cells[0].Value));
                    MessageBox.Show((res1 == 1) ? "Uspešno obrisano." : "Greška: Operacija brisanja nije uspela.");
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
