namespace LibraryStstem.BorrowingReturn
{
    partial class frmManageBorrowing
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
            this.dgvAllBorrowingRecords = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddRecord = new Guna.UI2.WinForms.Guna2Button();
            this.cmsManageBorrowingRecord = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ItemReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBorrowingRecords)).BeginInit();
            this.cmsManageBorrowingRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllBorrowingRecords
            // 
            this.dgvAllBorrowingRecords.AllowDrop = true;
            this.dgvAllBorrowingRecords.AllowUserToAddRows = false;
            this.dgvAllBorrowingRecords.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllBorrowingRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllBorrowingRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvAllBorrowingRecords.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAllBorrowingRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllBorrowingRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllBorrowingRecords.ColumnHeadersHeight = 30;
            this.dgvAllBorrowingRecords.ContextMenuStrip = this.cmsManageBorrowingRecord;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllBorrowingRecords.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllBorrowingRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAllBorrowingRecords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllBorrowingRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvAllBorrowingRecords.Name = "dgvAllBorrowingRecords";
            this.dgvAllBorrowingRecords.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllBorrowingRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllBorrowingRecords.RowHeadersVisible = false;
            this.dgvAllBorrowingRecords.RowHeadersWidth = 51;
            this.dgvAllBorrowingRecords.RowTemplate.Height = 24;
            this.dgvAllBorrowingRecords.Size = new System.Drawing.Size(1245, 415);
            this.dgvAllBorrowingRecords.TabIndex = 1;
            this.dgvAllBorrowingRecords.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvAllBorrowingRecords.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllBorrowingRecords.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllBorrowingRecords.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllBorrowingRecords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllBorrowingRecords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllBorrowingRecords.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvAllBorrowingRecords.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllBorrowingRecords.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvAllBorrowingRecords.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllBorrowingRecords.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllBorrowingRecords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllBorrowingRecords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllBorrowingRecords.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllBorrowingRecords.ThemeStyle.ReadOnly = true;
            this.dgvAllBorrowingRecords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvAllBorrowingRecords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllBorrowingRecords.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllBorrowingRecords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllBorrowingRecords.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAllBorrowingRecords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvAllBorrowingRecords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Animated = true;
            this.btnAddRecord.AutoRoundedCorners = true;
            this.btnAddRecord.BorderRadius = 26;
            this.btnAddRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRecord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.btnAddRecord.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddRecord.ForeColor = System.Drawing.Color.White;
            this.btnAddRecord.Location = new System.Drawing.Point(521, 587);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(140, 54);
            this.btnAddRecord.TabIndex = 115;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // cmsManageBorrowingRecord
            // 
            this.cmsManageBorrowingRecord.BackColor = System.Drawing.Color.Silver;
            this.cmsManageBorrowingRecord.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageBorrowingRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemReturn,
            this.ItemViewDetails,
            this.ItemUpdate});
            this.cmsManageBorrowingRecord.Name = "cmsManageCustomer";
            this.cmsManageBorrowingRecord.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.cmsManageBorrowingRecord.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsManageBorrowingRecord.RenderStyle.ColorTable = null;
            this.cmsManageBorrowingRecord.RenderStyle.RoundedEdges = true;
            this.cmsManageBorrowingRecord.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsManageBorrowingRecord.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.cmsManageBorrowingRecord.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsManageBorrowingRecord.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsManageBorrowingRecord.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsManageBorrowingRecord.Size = new System.Drawing.Size(211, 104);
            this.cmsManageBorrowingRecord.Opening += new System.ComponentModel.CancelEventHandler(this.cmsManageBorrowingRecord_Opening);
            // 
            // ItemReturn
            // 
            this.ItemReturn.Name = "ItemReturn";
            this.ItemReturn.Size = new System.Drawing.Size(210, 24);
            this.ItemReturn.Text = "Return";
            this.ItemReturn.Visible = false;
            this.ItemReturn.Click += new System.EventHandler(this.ItemReturn_Click);
            // 
            // ItemViewDetails
            // 
            this.ItemViewDetails.Name = "ItemViewDetails";
            this.ItemViewDetails.Size = new System.Drawing.Size(210, 24);
            this.ItemViewDetails.Text = "View Details";
            this.ItemViewDetails.Click += new System.EventHandler(this.ItemViewDetails_Click);
            // 
            // ItemUpdate
            // 
            this.ItemUpdate.Name = "ItemUpdate";
            this.ItemUpdate.Size = new System.Drawing.Size(210, 24);
            this.ItemUpdate.Text = "Update";
            this.ItemUpdate.Click += new System.EventHandler(this.ItemUpdate_Click);
            // 
            // frmManageBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1245, 675);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.dgvAllBorrowingRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageBorrowing";
            this.Text = "Manage Borrowing And Return";
            this.Load += new System.EventHandler(this.frmManageBorrowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBorrowingRecords)).EndInit();
            this.cmsManageBorrowingRecord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAllBorrowingRecords;
        private Guna.UI2.WinForms.Guna2Button btnAddRecord;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsManageBorrowingRecord;
        private System.Windows.Forms.ToolStripMenuItem ItemReturn;
        private System.Windows.Forms.ToolStripMenuItem ItemViewDetails;
        private System.Windows.Forms.ToolStripMenuItem ItemUpdate;
    }
}