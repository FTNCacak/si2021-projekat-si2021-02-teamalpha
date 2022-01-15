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
            initializeDGW(rentDGW);
        }

        private void initializeDGW(System.Windows.Forms.DataGridView dgw)
        {

            List<Rent> list = rentBusiness.GetAllRents();
            foreach (Rent a in list)
            {
                string[] newItem = {a.Id_Rente.ToString(), a.Datum_pocetka.ToString(), a.Broj_dana.ToString(),
                (a.Nacin_placanja ? "Gotovina" : "Kartica"),a.Broj_kartice != null ? a.Broj_kartice : "/", userBusiness.GetUserNameById(a.Id_Korisnika),
                a.Id_Stana.ToString(), userBusiness.GetUserNameById(a.Id_Stanodavca)};
                dgw.Rows.Add(newItem);
            }
        }
    }
}
