namespace LibrarySystem.Genres
{
    partial class frmManageGenres
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
            this.dgvAllGeners = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsManageGenres = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.ItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBooksThisGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddGenre = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGeners)).BeginInit();
            this.cmsManageGenres.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllGeners
            // 
            this.dgvAllGeners.AllowDrop = true;
            this.dgvAllGeners.AllowUserToAddRows = false;
            this.dgvAllGeners.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllGeners.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllGeners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvAllGeners.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAllGeners.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllGeners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllGeners.ColumnHeadersHeight = 30;
            this.dgvAllGeners.ContextMenuStrip = this.cmsManageGenres;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllGeners.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllGeners.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAllGeners.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllGeners.Location = new System.Drawing.Point(0, 0);
            this.dgvAllGeners.Name = "dgvAllGeners";
            this.dgvAllGeners.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllGeners.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllGeners.RowHeadersVisible = false;
            this.dgvAllGeners.RowHeadersWidth = 51;
            this.dgvAllGeners.RowTemplate.Height = 24;
            this.dgvAllGeners.Size = new System.Drawing.Size(1245, 415);
            this.dgvAllGeners.TabIndex = 3;
            this.dgvAllGeners.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvAllGeners.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllGeners.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllGeners.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllGeners.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllGeners.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllGeners.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvAllGeners.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllGeners.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvAllGeners.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllGeners.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllGeners.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllGeners.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllGeners.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllGeners.ThemeStyle.ReadOnly = true;
            this.dgvAllGeners.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvAllGeners.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllGeners.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllGeners.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllGeners.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAllGeners.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvAllGeners.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // cmsManageGenres
            // 
            this.cmsManageGenres.BackColor = System.Drawing.Color.Silver;
            this.cmsManageGenres.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageGenres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemUpdate,
            this.ItemDelete,
            this.viewBooksThisGenreToolStripMenuItem});
            this.cmsManageGenres.Name = "cmsManageCustomer";
            this.cmsManageGenres.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.cmsManageGenres.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsManageGenres.RenderStyle.ColorTable = null;
            this.cmsManageGenres.RenderStyle.RoundedEdges = true;
            this.cmsManageGenres.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsManageGenres.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.cmsManageGenres.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsManageGenres.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsManageGenres.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsManageGenres.Size = new System.Drawing.Size(228, 76);
            // 
            // ItemUpdate
            // 
            this.ItemUpdate.Name = "ItemUpdate";
            this.ItemUpdate.Size = new System.Drawing.Size(227, 24);
            this.ItemUpdate.Text = "Update";
            this.ItemUpdate.Click += new System.EventHandler(this.ItemUpdate_Click);
            // 
            // ItemDelete
            // 
            this.ItemDelete.Name = "ItemDelete";
            this.ItemDelete.Size = new System.Drawing.Size(227, 24);
            this.ItemDelete.Text = "Delete";
            this.ItemDelete.Click += new System.EventHandler(this.ItemDelete_Click);
            // 
            // viewBooksThisGenreToolStripMenuItem
            // 
            this.viewBooksThisGenreToolStripMenuItem.Name = "viewBooksThisGenreToolStripMenuItem";
            this.viewBooksThisGenreToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.viewBooksThisGenreToolStripMenuItem.Text = "View Books This Genre";
            this.viewBooksThisGenreToolStripMenuItem.Click += new System.EventHandler(this.viewBooksThisGenreToolStripMenuItem_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Animated = true;
            this.btnAddGenre.AutoRoundedCorners = true;
            this.btnAddGenre.BorderRadius = 21;
            this.btnAddGenre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddGenre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddGenre.FillColor = System.Drawing.Color.Black;
            this.btnAddGenre.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddGenre.ForeColor = System.Drawing.Color.White;
            this.btnAddGenre.Location = new System.Drawing.Point(514, 581);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(136, 45);
            this.btnAddGenre.TabIndex = 117;
            this.btnAddGenre.Text = "Add Genre";
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // frmManageGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1245, 675);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.dgvAllGeners);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageGenres";
            this.Tag = "Manage Genres";
            this.Text = "Manage Genres";
            this.Load += new System.EventHandler(this.frmManageGenres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGeners)).EndInit();
            this.cmsManageGenres.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAllGeners;
        private Guna.UI2.WinForms.Guna2Button btnAddGenre;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsManageGenres;
        private System.Windows.Forms.ToolStripMenuItem ItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem ItemDelete;
        private System.Windows.Forms.ToolStripMenuItem viewBooksThisGenreToolStripMenuItem;
    }
}