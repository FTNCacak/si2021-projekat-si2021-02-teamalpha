
namespace Presentation_Layer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.currentBtnSelection = new System.Windows.Forms.Panel();
            this.btnRents = new System.Windows.Forms.Button();
            this.btnApartments = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContentArea = new System.Windows.Forms.Panel();
            this.UC_Users = new Presentation_Layer.UserControls.Users();
            this.UC_Overview = new Presentation_Layer.UserControls.Overview();
            this.UC_Apartments = new Presentation_Layer.UserControls.Apartments();
            this.UC_Rents = new Presentation_Layer.UserControls.Rents();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelContentArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(224, 62);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.LogoWhiteAB;
            this.pictureBox1.Location = new System.Drawing.Point(0, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.currentBtnSelection);
            this.panelMenu.Controls.Add(this.btnRents);
            this.panelMenu.Controls.Add(this.btnApartments);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.MinimumSize = new System.Drawing.Size(224, 631);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(224, 670);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // currentBtnSelection
            // 
            this.currentBtnSelection.BackColor = System.Drawing.Color.Gainsboro;
            this.currentBtnSelection.Location = new System.Drawing.Point(0, 62);
            this.currentBtnSelection.Name = "currentBtnSelection";
            this.currentBtnSelection.Size = new System.Drawing.Size(5, 60);
            this.currentBtnSelection.TabIndex = 5;
            // 
            // btnRents
            // 
            this.btnRents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRents.FlatAppearance.BorderSize = 0;
            this.btnRents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRents.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRents.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRents.Image = global::Presentation_Layer.Properties.Resources.transaction_32px;
            this.btnRents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRents.Location = new System.Drawing.Point(0, 242);
            this.btnRents.Name = "btnRents";
            this.btnRents.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRents.Size = new System.Drawing.Size(224, 60);
            this.btnRents.TabIndex = 4;
            this.btnRents.Text = "   Rente";
            this.btnRents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRents.UseVisualStyleBackColor = true;
            this.btnRents.Click += new System.EventHandler(this.btnRents_Click);
            // 
            // btnApartments
            // 
            this.btnApartments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApartments.FlatAppearance.BorderSize = 0;
            this.btnApartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApartments.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApartments.ForeColor = System.Drawing.Color.DarkGray;
            this.btnApartments.Image = global::Presentation_Layer.Properties.Resources.list_32px;
            this.btnApartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApartments.Location = new System.Drawing.Point(0, 182);
            this.btnApartments.Name = "btnApartments";
            this.btnApartments.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnApartments.Size = new System.Drawing.Size(224, 60);
            this.btnApartments.TabIndex = 3;
            this.btnApartments.Text = "   Oglasi";
            this.btnApartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApartments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApartments.UseVisualStyleBackColor = true;
            this.btnApartments.Click += new System.EventHandler(this.btnApartments_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.DarkGray;
            this.btnUsers.Image = global::Presentation_Layer.Properties.Resources.staff_32px;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 122);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(224, 60);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "   Korisnici";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.Image = global::Presentation_Layer.Properties.Resources.home_32px;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 62);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(224, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "   Pregled";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 62);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Presentation_Layer.Properties.Resources.macos_minimize_24px;
            this.button2.Location = new System.Drawing.Point(710, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 30);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Presentation_Layer.Properties.Resources.macos_close_24px;
            this.button1.Location = new System.Drawing.Point(744, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelContentArea
            // 
            this.panelContentArea.Controls.Add(this.UC_Rents);
            this.panelContentArea.Controls.Add(this.UC_Users);
            this.panelContentArea.Controls.Add(this.UC_Overview);
            this.panelContentArea.Controls.Add(this.UC_Apartments);
            this.panelContentArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentArea.Location = new System.Drawing.Point(224, 62);
            this.panelContentArea.Name = "panelContentArea";
            this.panelContentArea.Size = new System.Drawing.Size(786, 608);
            this.panelContentArea.TabIndex = 3;
            // 
            // UC_Users
            // 
            this.UC_Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.UC_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Users.Location = new System.Drawing.Point(0, 0);
            this.UC_Users.Name = "UC_Users";
            this.UC_Users.Size = new System.Drawing.Size(786, 608);
            this.UC_Users.TabIndex = 2;
            // 
            // UC_Overview
            // 
            this.UC_Overview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.UC_Overview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Overview.Location = new System.Drawing.Point(0, 0);
            this.UC_Overview.Name = "UC_Overview";
            this.UC_Overview.Padding = new System.Windows.Forms.Padding(10);
            this.UC_Overview.Size = new System.Drawing.Size(786, 608);
            this.UC_Overview.TabIndex = 0;
            // 
            // UC_Apartments
            // 
            this.UC_Apartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.UC_Apartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Apartments.Location = new System.Drawing.Point(0, 0);
            this.UC_Apartments.Name = "UC_Apartments";
            this.UC_Apartments.Size = new System.Drawing.Size(786, 608);
            this.UC_Apartments.TabIndex = 1;
            // 
            // UC_Rents
            // 
            this.UC_Rents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.UC_Rents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Rents.Location = new System.Drawing.Point(0, 0);
            this.UC_Rents.Name = "UC_Rents";
            this.UC_Rents.Size = new System.Drawing.Size(786, 608);
            this.UC_Rents.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1010, 670);
            this.Controls.Add(this.panelContentArea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1010, 670);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlphaBooking";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelContentArea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnRents;
        private System.Windows.Forms.Button btnApartments;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel currentBtnSelection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelContentArea;
        private UserControls.Overview UC_Overview;
        private UserControls.Apartments UC_Apartments;
        private UserControls.Users UC_Users;
        private UserControls.Rents UC_Rents;
    }
}

