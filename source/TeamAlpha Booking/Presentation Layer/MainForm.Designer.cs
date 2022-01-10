
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
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(224, 90);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation_Layer.Properties.Resources.LogoWhiteAB;
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.currentBtnSelection);
            this.panelMenu.Controls.Add(this.btnRents);
            this.panelMenu.Controls.Add(this.btnApartments);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(224, 631);
            this.panelMenu.TabIndex = 1;
            // 
            // currentBtnSelection
            // 
            this.currentBtnSelection.BackColor = System.Drawing.Color.Gainsboro;
            this.currentBtnSelection.Location = new System.Drawing.Point(0, 90);
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
            this.btnRents.ForeColor = System.Drawing.Color.Silver;
            this.btnRents.Image = global::Presentation_Layer.Properties.Resources.transaction_32px;
            this.btnRents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRents.Location = new System.Drawing.Point(0, 270);
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
            this.btnApartments.ForeColor = System.Drawing.Color.Silver;
            this.btnApartments.Image = global::Presentation_Layer.Properties.Resources.list_32px;
            this.btnApartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApartments.Location = new System.Drawing.Point(0, 210);
            this.btnApartments.Name = "btnApartments";
            this.btnApartments.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnApartments.Size = new System.Drawing.Size(224, 60);
            this.btnApartments.TabIndex = 3;
            this.btnApartments.Text = "   Oglasi";
            this.btnApartments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApartments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApartments.UseVisualStyleBackColor = true;
            this.btnApartments.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Silver;
            this.btnUsers.Image = global::Presentation_Layer.Properties.Resources.staff_32px;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 150);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(224, 60);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "   Korisnici";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.button1_Click);
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
            this.btnDashboard.Location = new System.Drawing.Point(0, 90);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 90);
            this.panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1010, 670);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlphaBooking";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

