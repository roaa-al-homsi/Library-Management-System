namespace LibraryStstem.Authors
{
    partial class frmManageAuthors
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
            this.dgvAllAuthors = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsManageAuthors = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddAuthor = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAuthors)).BeginInit();
            this.cmsManageAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllAuthors
            // 
            this.dgvAllAuthors.AllowDrop = true;
            this.dgvAllAuthors.AllowUserToAddRows = false;
            this.dgvAllAuthors.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllAuthors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllAuthors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvAllAuthors.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAllAuthors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllAuthors.ColumnHeadersHeight = 30;
            this.dgvAllAuthors.ContextMenuStrip = this.cmsManageAuthors;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllAuthors.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllAuthors.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAllAuthors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllAuthors.Location = new System.Drawing.Point(0, 0);
            this.dgvAllAuthors.Name = "dgvAllAuthors";
            this.dgvAllAuthors.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllAuthors.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllAuthors.RowHeadersVisible = false;
            this.dgvAllAuthors.RowHeadersWidth = 51;
            this.dgvAllAuthors.RowTemplate.Height = 24;
            this.dgvAllAuthors.Size = new System.Drawing.Size(1245, 415);
            this.dgvAllAuthors.TabIndex = 1;
            this.dgvAllAuthors.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvAllAuthors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvAllAuthors.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllAuthors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllAuthors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllAuthors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllAuthors.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvAllAuthors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvAllAuthors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvAllAuthors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAllAuthors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllAuthors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllAuthors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllAuthors.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAllAuthors.ThemeStyle.ReadOnly = true;
            this.dgvAllAuthors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvAllAuthors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllAuthors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllAuthors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllAuthors.ThemeStyle.RowsStyle.Height = 24;
            this.dgvAllAuthors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvAllAuthors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // cmsManageAuthors
            // 
            this.cmsManageAuthors.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmsManageAuthors.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageAuthors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.showBookToolStripMenuItem});
            this.cmsManageAuthors.Name = "cmsManageAuthors";
            this.cmsManageAuthors.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.cmsManageAuthors.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsManageAuthors.RenderStyle.ColorTable = null;
            this.cmsManageAuthors.RenderStyle.RoundedEdges = true;
            this.cmsManageAuthors.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsManageAuthors.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.cmsManageAuthors.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsManageAuthors.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsManageAuthors.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsManageAuthors.Size = new System.Drawing.Size(211, 104);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // showBookToolStripMenuItem
            // 
            this.showBookToolStripMenuItem.Name = "showBookToolStripMenuItem";
            this.showBookToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showBookToolStripMenuItem.Text = "View author\'s books";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Animated = true;
            this.btnAddAuthor.AutoRoundedCorners = true;
            this.btnAddAuthor.BorderRadius = 24;
            this.btnAddAuthor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAuthor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAuthor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(29)))), ((int)(((byte)(44)))));
            this.btnAddAuthor.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthor.Location = new System.Drawing.Point(534, 601);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(159, 51);
            this.btnAddAuthor.TabIndex = 115;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // frmManageAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1245, 675);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.dgvAllAuthors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageAuthors";
            this.Tag = "Manage Authors";
            this.Text = "Manage Authors";
            this.Load += new System.EventHandler(this.frmManageAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAuthors)).EndInit();
            this.cmsManageAuthors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvAllAuthors;
        private Guna.UI2.WinForms.Guna2Button btnAddAuthor;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsManageAuthors;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBookToolStripMenuItem;
    }
}