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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllBorrowingRecords = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAllCopies = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddBook = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBorrowingRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllBorrowingRecords
            // 
            this.dgvAllBorrowingRecords.AllowDrop = true;
            this.dgvAllBorrowingRecords.AllowUserToAddRows = false;
            this.dgvAllBorrowingRecords.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllBorrowingRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllBorrowingRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvAllBorrowingRecords.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAllBorrowingRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = "NULL";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllBorrowingRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAllBorrowingRecords.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllBorrowingRecords.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAllBorrowingRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAllBorrowingRecords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllBorrowingRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvAllBorrowingRecords.Name = "dgvAllBorrowingRecords";
            this.dgvAllBorrowingRecords.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllBorrowingRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            // btnAllCopies
            // 
            this.btnAllCopies.Animated = true;
            this.btnAllCopies.AutoRoundedCorners = true;
            this.btnAllCopies.BorderRadius = 26;
            this.btnAllCopies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllCopies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllCopies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllCopies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllCopies.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.btnAllCopies.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnAllCopies.ForeColor = System.Drawing.Color.White;
            this.btnAllCopies.Location = new System.Drawing.Point(606, 583);
            this.btnAllCopies.Name = "btnAllCopies";
            this.btnAllCopies.Size = new System.Drawing.Size(133, 54);
            this.btnAllCopies.TabIndex = 116;
            this.btnAllCopies.Text = "All Copies";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Animated = true;
            this.btnAddBook.AutoRoundedCorners = true;
            this.btnAddBook.BorderRadius = 26;
            this.btnAddBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.btnAddBook.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(419, 583);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(133, 54);
            this.btnAddBook.TabIndex = 115;
            this.btnAddBook.Text = "Add Book";
            // 
            // frmManageBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1245, 675);
            this.Controls.Add(this.btnAllCopies);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dgvAllBorrowingRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageBorrowing";
            this.Text = "Manage Borrowing And Return";
            this.Load += new System.EventHandler(this.frmManageBorrowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBorrowingRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAllBorrowingRecords;
        private Guna.UI2.WinForms.Guna2Button btnAllCopies;
        private Guna.UI2.WinForms.Guna2Button btnAddBook;
    }
}