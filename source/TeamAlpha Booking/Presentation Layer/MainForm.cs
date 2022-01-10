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
    }
}
