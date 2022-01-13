using Shared.Interfaces;
using Shared.Models;
using System.Collections.Generic;

namespace Presentation_Layer.UserControls
{
    partial class Apartments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label8 = new System.Windows.Forms.Label();
            this.apartmentDGW = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label8.Location = new System.Drawing.Point(75, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(666, 89);
            this.label8.TabIndex = 7;
            this.label8.Text = "Oglasi";
            // 
            // apartmentDGW
            // 
            this.apartmentDGW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.apartmentDGW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.apartmentDGW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.apartmentDGW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.apartmentDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apartmentDGW.EnableHeadersVisualStyles = false;
            this.apartmentDGW.Location = new System.Drawing.Point(26, 175);
            this.apartmentDGW.MultiSelect = false;
            this.apartmentDGW.Name = "apartmentDGW";
            this.apartmentDGW.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.apartmentDGW.RowHeadersVisible = false;
            this.apartmentDGW.RowHeadersWidth = 72;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.apartmentDGW.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.apartmentDGW.RowTemplate.Height = 31;
            this.apartmentDGW.Size = new System.Drawing.Size(1170, 922);
            this.apartmentDGW.TabIndex = 8;
            // 
            // Apartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.apartmentDGW);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Apartments";
            this.Size = new System.Drawing.Size(1441, 1122);
            this.Load += new System.EventHandler(this.Apartments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apartmentDGW)).EndInit();
            this.ResumeLayout(false);

            // DataGridView Columns
            apartmentDGW.ColumnCount = 10;
            apartmentDGW.Columns[0].Name = "ID";
            apartmentDGW.Columns[1].Name = "Mesto";
            apartmentDGW.Columns[2].Name = "Adresa";
            apartmentDGW.Columns[3].Name = "Broj soba";
            apartmentDGW.Columns[4].Name = "Kvadratura";
            apartmentDGW.Columns[5].Name = "Postanski br";
            apartmentDGW.Columns[6].Name = "Cena nocenja";
            apartmentDGW.Columns[7].Name = "Depozit";
            apartmentDGW.Columns[8].Name = "Broj sprata";
            apartmentDGW.Columns[9].Name = "Stanodavac";

            //initializeDGW(apartmentDGW);
        }

        

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView apartmentDGW;
    }
}
