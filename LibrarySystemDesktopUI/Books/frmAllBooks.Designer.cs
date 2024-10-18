namespace LibrarySystem.Books
{
    partial class frmAllBooks
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
            this.dgvAllBooks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsBooks = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCopiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllCopies = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBooks)).BeginInit();
            this.cmsBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllBooks
            // 
            this.dgvAllBooks.AllowDrop = true;
            this.dgvAllBooks.AllowUserToAddRows = false;
            this.dgvAllBooks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvAllBooks.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAllBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllBooks.ColumnHeadersHeight = 30;
            this.dgvAllBooks.ContextMenuStrip = this.cmsBooks;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllBooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAllBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvAllBooks.Name = "dgvAllBooks";
            this.dgvAllBooks.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllBooks.RowHeadersVisible = false;
            this.dgvAllBooks.RowHeadersWidth = 51;
            this.dgvAllBooks.RowTemplate.Height = 24;
            this.dgvAllBooks.Size = new System.Drawing.Size(1245, 415);
            this.dgvAllBooks.TabIndex = 0;
            this.dgvAllBooks.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvAllBooks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllBooks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllBooks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllBooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllBooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllBooks.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvAllBooks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllBooks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvAllBooks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllBooks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllBooks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllBooks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllBooks.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllBooks.ThemeStyle.ReadOnly = true;
            this.dgvAllBooks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvAllBooks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllBooks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllBooks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllBooks.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAllBooks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvAllBooks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // cmsBooks
            // 
            this.cmsBooks.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.showCopiesToolStripMenuItem});
            this.cmsBooks.Name = "guna2ContextMenuStrip1";
            this.cmsBooks.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsBooks.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsBooks.RenderStyle.ColorTable = null;
            this.cmsBooks.RenderStyle.RoundedEdges = true;
            this.cmsBooks.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsBooks.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsBooks.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsBooks.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsBooks.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsBooks.Size = new System.Drawing.Size(164, 76);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // showCopiesToolStripMenuItem
            // 
            this.showCopiesToolStripMenuItem.Name = "showCopiesToolStripMenuItem";
            this.showCopiesToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.showCopiesToolStripMenuItem.Text = "Show Copies";
            this.showCopiesToolStripMenuItem.Click += new System.EventHandler(this.showCopiesToolStripMenuItem_Click);
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
            this.btnAddBook.Location = new System.Drawing.Point(435, 566);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(133, 54);
            this.btnAddBook.TabIndex = 113;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
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
            this.btnAllCopies.Location = new System.Drawing.Point(636, 566);
            this.btnAllCopies.Name = "btnAllCopies";
            this.btnAllCopies.Size = new System.Drawing.Size(133, 54);
            this.btnAllCopies.TabIndex = 114;
            this.btnAllCopies.Text = "All Copies";
            this.btnAllCopies.Click += new System.EventHandler(this.btnAllCopies_Click);
            // 
            // frmAllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1245, 675);
            this.Controls.Add(this.btnAllCopies);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dgvAllBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAllBooks";
            this.Text = "frmAllBooks";
            this.Load += new System.EventHandler(this.frmAllBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBooks)).EndInit();
            this.cmsBooks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAllBooks;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsBooks;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCopiesToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAddBook;
        private Guna.UI2.WinForms.Guna2Button btnAllCopies;
    }
}