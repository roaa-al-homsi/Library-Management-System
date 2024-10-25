namespace LibraryStstem.Fines
{
    partial class frmManageFines
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
            this.dgvAllFines = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsManageFines = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ItemPay = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllFines)).BeginInit();
            this.cmsManageFines.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllFines
            // 
            this.dgvAllFines.AllowDrop = true;
            this.dgvAllFines.AllowUserToAddRows = false;
            this.dgvAllFines.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllFines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllFines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvAllFines.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAllFines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllFines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllFines.ColumnHeadersHeight = 30;
            this.dgvAllFines.ContextMenuStrip = this.cmsManageFines;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllFines.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllFines.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAllFines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllFines.Location = new System.Drawing.Point(0, 0);
            this.dgvAllFines.Name = "dgvAllFines";
            this.dgvAllFines.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllFines.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllFines.RowHeadersVisible = false;
            this.dgvAllFines.RowHeadersWidth = 51;
            this.dgvAllFines.RowTemplate.Height = 24;
            this.dgvAllFines.Size = new System.Drawing.Size(1245, 415);
            this.dgvAllFines.TabIndex = 3;
            this.dgvAllFines.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvAllFines.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllFines.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllFines.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllFines.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllFines.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllFines.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvAllFines.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllFines.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvAllFines.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllFines.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllFines.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllFines.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllFines.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllFines.ThemeStyle.ReadOnly = true;
            this.dgvAllFines.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvAllFines.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllFines.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllFines.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllFines.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAllFines.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvAllFines.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // cmsManageFines
            // 
            this.cmsManageFines.BackColor = System.Drawing.Color.Silver;
            this.cmsManageFines.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageFines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemPay,
            this.ItemViewDetails});
            this.cmsManageFines.Name = "cmsManageCustomer";
            this.cmsManageFines.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.cmsManageFines.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsManageFines.RenderStyle.ColorTable = null;
            this.cmsManageFines.RenderStyle.RoundedEdges = true;
            this.cmsManageFines.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsManageFines.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.cmsManageFines.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsManageFines.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsManageFines.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsManageFines.Size = new System.Drawing.Size(211, 80);
            this.cmsManageFines.Opening += new System.ComponentModel.CancelEventHandler(this.cmsManageFines_Opening);
            // 
            // ItemPay
            // 
            this.ItemPay.Name = "ItemPay";
            this.ItemPay.Size = new System.Drawing.Size(210, 24);
            this.ItemPay.Text = "Pay";
            this.ItemPay.Click += new System.EventHandler(this.ItemPay_Click);
            // 
            // ItemViewDetails
            // 
            this.ItemViewDetails.Name = "ItemViewDetails";
            this.ItemViewDetails.Size = new System.Drawing.Size(210, 24);
            this.ItemViewDetails.Text = "View Details";
            this.ItemViewDetails.Click += new System.EventHandler(this.ItemViewDetails_Click);
            // 
            // frmManageFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1245, 675);
            this.Controls.Add(this.dgvAllFines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageFines";
            this.Tag = "Manage Fines";
            this.Text = "Manage Fines";
            this.Load += new System.EventHandler(this.frmManageFines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllFines)).EndInit();
            this.cmsManageFines.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAllFines;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsManageFines;
        private System.Windows.Forms.ToolStripMenuItem ItemPay;
        private System.Windows.Forms.ToolStripMenuItem ItemViewDetails;
    }
}