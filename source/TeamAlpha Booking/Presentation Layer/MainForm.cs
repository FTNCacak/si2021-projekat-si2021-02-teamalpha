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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        protected override CreateParams CreateParams // overriding CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED, forces double buffering on form level
                return cp;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            currentBtnSelection.Location = new Point { X = 0, Y = 90 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentBtnSelection.Location = new Point { X = 0, Y = 150 };
            ActivateButton(btnUsers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentBtnSelection.Location = new Point { X = 0, Y = 210 };
        }

        private void btnRents_Click(object sender, EventArgs e)
        {
            currentBtnSelection.Location = new Point { X = 0, Y = 270 };
        }

        private void ActivateButton(Button btn)
        {
            btnApartments.ForeColor = Color.Silver;
            btnDashboard.ForeColor = Color.Silver;
            btnUsers.ForeColor = Color.Silver;

            btn.ForeColor = Color.Gainsboro;
        }
    }
}
