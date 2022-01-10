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
        bool mouseDown;
        private Point offset;

        public MainForm(IUserBusiness _userBusiness)
        {
            userBusiness = _userBusiness;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UC_Overview.BringToFront();
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
            currentBtnSelection.Location = new Point { X = 0, Y = 62 };
            ActivateButton(btnDashboard);

            UC_Overview.BringToFront();
        }


        private void ActivateButton(Button btn)
        {
            btnApartments.ForeColor = Color.DarkGray;
            btnApartments.BackColor = Color.FromArgb(39, 39, 39);

            btnDashboard.ForeColor = Color.DarkGray;
            btnDashboard.BackColor = Color.FromArgb(39, 39, 39);

            btnUsers.ForeColor = Color.DarkGray;
            btnUsers.BackColor = Color.FromArgb(39, 39, 39);

            btnRents.ForeColor = Color.DarkGray;
            btnRents.BackColor = Color.FromArgb(39, 39, 39);

            btn.ForeColor = Color.Gainsboro;
            btn.BackColor = Color.FromArgb(42, 42, 42);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            currentBtnSelection.Location = new Point { X = 0, Y = 122 };
            ActivateButton(btnUsers);

            UC_Users.BringToFront();
        }

        private void btnApartments_Click(object sender, EventArgs e)
        {
            currentBtnSelection.Location = new Point { X = 0, Y = 182 };
            ActivateButton(btnApartments);

            UC_Apartments.BringToFront();
        }

        private void btnRents_Click(object sender, EventArgs e)
        {
            currentBtnSelection.Location = new Point { X = 0, Y = 242 };
            ActivateButton(btnRents);

            UC_Rents.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentMousePosition = PointToScreen(e.Location);
                Location = new Point(currentMousePosition.X - offset.X, currentMousePosition.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
