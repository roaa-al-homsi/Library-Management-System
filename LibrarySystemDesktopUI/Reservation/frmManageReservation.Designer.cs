﻿namespace LibrarySystem.Reservations
{
    partial class frmManageReservations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageReservations));
            this.dgvAllReservation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsManageReservationRecord = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddReservation = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReservation)).BeginInit();
            this.cmsManageReservationRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllReservation
            // 
            this.dgvAllReservation.AllowDrop = true;
            this.dgvAllReservation.AllowUserToAddRows = false;
            this.dgvAllReservation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllReservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllReservation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvAllReservation.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAllReservation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllReservation.ColumnHeadersHeight = 30;
            this.dgvAllReservation.ContextMenuStrip = this.cmsManageReservationRecord;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllReservation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAllReservation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllReservation.Location = new System.Drawing.Point(0, 0);
            this.dgvAllReservation.Name = "dgvAllReservation";
            this.dgvAllReservation.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllReservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllReservation.RowHeadersVisible = false;
            this.dgvAllReservation.RowHeadersWidth = 51;
            this.dgvAllReservation.RowTemplate.Height = 24;
            this.dgvAllReservation.Size = new System.Drawing.Size(1245, 415);
            this.dgvAllReservation.TabIndex = 4;
            this.dgvAllReservation.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvAllReservation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllReservation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllReservation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllReservation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllReservation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllReservation.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvAllReservation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllReservation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvAllReservation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllReservation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllReservation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllReservation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllReservation.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllReservation.ThemeStyle.ReadOnly = true;
            this.dgvAllReservation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvAllReservation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllReservation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllReservation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllReservation.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAllReservation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvAllReservation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // cmsManageReservationRecord
            // 
            this.cmsManageReservationRecord.BackColor = System.Drawing.Color.Silver;
            this.cmsManageReservationRecord.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageReservationRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemUpdate,
            this.deleteToolStripMenuItem});
            this.cmsManageReservationRecord.Name = "cmsManageCustomer";
            this.cmsManageReservationRecord.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.cmsManageReservationRecord.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsManageReservationRecord.RenderStyle.ColorTable = null;
            this.cmsManageReservationRecord.RenderStyle.RoundedEdges = true;
            this.cmsManageReservationRecord.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsManageReservationRecord.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.cmsManageReservationRecord.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsManageReservationRecord.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsManageReservationRecord.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsManageReservationRecord.Size = new System.Drawing.Size(128, 52);
            // 
            // ItemUpdate
            // 
            this.ItemUpdate.Name = "ItemUpdate";
            this.ItemUpdate.Size = new System.Drawing.Size(127, 24);
            this.ItemUpdate.Text = "Update";
            this.ItemUpdate.Click += new System.EventHandler(this.ItemUpdate_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Animated = true;
            this.btnAddReservation.AutoRoundedCorners = true;
            this.btnAddReservation.BorderRadius = 21;
            this.btnAddReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddReservation.FillColor = System.Drawing.Color.Black;
            this.btnAddReservation.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddReservation.ForeColor = System.Drawing.Color.White;
            this.btnAddReservation.Location = new System.Drawing.Point(510, 567);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(167, 45);
            this.btnAddReservation.TabIndex = 118;
            this.btnAddReservation.Text = "Add Record";
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(996, 421);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(202, 242);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 119;
            this.guna2PictureBox2.TabStop = false;
            // 
            // frmManageReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1245, 675);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.dgvAllReservation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageReservations";
            this.Tag = "Manage Reservations";
            this.Text = "Manage Reservations";
            this.Load += new System.EventHandler(this.frmManageReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReservation)).EndInit();
            this.cmsManageReservationRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAllReservation;
        private Guna.UI2.WinForms.Guna2Button btnAddReservation;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsManageReservationRecord;
        private System.Windows.Forms.ToolStripMenuItem ItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}