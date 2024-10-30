namespace LibrarySystem.Fines
{
    partial class frmDetailsFines
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
            this.components = new System.ComponentModel.Container();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtBorrowingId = new Guna.UI2.WinForms.Guna2TextBox();
            this.TimePicActualReturn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TimePicDueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TimePicBorrowingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.uc_Customer1 = new LibrarySystem.uc_Customer();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.txtBorrowingId);
            this.guna2GradientPanel1.Controls.Add(this.TimePicActualReturn);
            this.guna2GradientPanel1.Controls.Add(this.TimePicDueDate);
            this.guna2GradientPanel1.Controls.Add(this.TimePicBorrowingDate);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(392, 275);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(449, 223);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // txtBorrowingId
            // 
            this.txtBorrowingId.Animated = true;
            this.txtBorrowingId.AutoRoundedCorners = true;
            this.txtBorrowingId.BorderRadius = 17;
            this.txtBorrowingId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBorrowingId.DefaultText = "??";
            this.txtBorrowingId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBorrowingId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBorrowingId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBorrowingId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBorrowingId.FillColor = System.Drawing.Color.Black;
            this.txtBorrowingId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBorrowingId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBorrowingId.ForeColor = System.Drawing.SystemColors.Control;
            this.txtBorrowingId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBorrowingId.Location = new System.Drawing.Point(237, 21);
            this.txtBorrowingId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBorrowingId.Name = "txtBorrowingId";
            this.txtBorrowingId.PasswordChar = '\0';
            this.txtBorrowingId.PlaceholderText = "";
            this.txtBorrowingId.ReadOnly = true;
            this.txtBorrowingId.SelectedText = "";
            this.txtBorrowingId.Size = new System.Drawing.Size(200, 36);
            this.txtBorrowingId.TabIndex = 140;
            this.txtBorrowingId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimePicActualReturn
            // 
            this.TimePicActualReturn.AutoRoundedCorners = true;
            this.TimePicActualReturn.BorderRadius = 17;
            this.TimePicActualReturn.Checked = true;
            this.TimePicActualReturn.Enabled = false;
            this.TimePicActualReturn.FillColor = System.Drawing.Color.Black;
            this.TimePicActualReturn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimePicActualReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.TimePicActualReturn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TimePicActualReturn.Location = new System.Drawing.Point(237, 177);
            this.TimePicActualReturn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TimePicActualReturn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TimePicActualReturn.Name = "TimePicActualReturn";
            this.TimePicActualReturn.Size = new System.Drawing.Size(200, 36);
            this.TimePicActualReturn.TabIndex = 139;
            this.TimePicActualReturn.Value = new System.DateTime(2024, 10, 19, 22, 56, 7, 337);
            // 
            // TimePicDueDate
            // 
            this.TimePicDueDate.AutoRoundedCorners = true;
            this.TimePicDueDate.BorderRadius = 17;
            this.TimePicDueDate.Checked = true;
            this.TimePicDueDate.Enabled = false;
            this.TimePicDueDate.FillColor = System.Drawing.Color.Black;
            this.TimePicDueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimePicDueDate.ForeColor = System.Drawing.SystemColors.Control;
            this.TimePicDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TimePicDueDate.Location = new System.Drawing.Point(237, 125);
            this.TimePicDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TimePicDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TimePicDueDate.Name = "TimePicDueDate";
            this.TimePicDueDate.Size = new System.Drawing.Size(200, 36);
            this.TimePicDueDate.TabIndex = 138;
            this.TimePicDueDate.Value = new System.DateTime(2024, 10, 19, 22, 56, 7, 337);
            // 
            // TimePicBorrowingDate
            // 
            this.TimePicBorrowingDate.AutoRoundedCorners = true;
            this.TimePicBorrowingDate.BorderRadius = 17;
            this.TimePicBorrowingDate.Checked = true;
            this.TimePicBorrowingDate.Enabled = false;
            this.TimePicBorrowingDate.FillColor = System.Drawing.Color.Black;
            this.TimePicBorrowingDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimePicBorrowingDate.ForeColor = System.Drawing.SystemColors.Control;
            this.TimePicBorrowingDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TimePicBorrowingDate.Location = new System.Drawing.Point(237, 73);
            this.TimePicBorrowingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TimePicBorrowingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TimePicBorrowingDate.Name = "TimePicBorrowingDate";
            this.TimePicBorrowingDate.Size = new System.Drawing.Size(200, 36);
            this.TimePicBorrowingDate.TabIndex = 137;
            this.TimePicBorrowingDate.Value = new System.DateTime(2024, 10, 19, 22, 56, 7, 337);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(3, 177);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(212, 36);
            this.guna2HtmlLabel3.TabIndex = 70;
            this.guna2HtmlLabel3.Text = "Actual Return Date:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(3, 125);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(139, 36);
            this.guna2HtmlLabel2.TabIndex = 68;
            this.guna2HtmlLabel2.Text = "Due Date:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(3, 73);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(170, 36);
            this.guna2HtmlLabel1.TabIndex = 66;
            this.guna2HtmlLabel1.Text = "Borrowing Date:";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(3, 31);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(139, 36);
            this.guna2HtmlLabel7.TabIndex = 64;
            this.guna2HtmlLabel7.Text = "Borrowing Id:";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(392, 27);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(327, 35);
            this.guna2HtmlLabel5.TabIndex = 73;
            this.guna2HtmlLabel5.Text = "Customer & Borrowing Info";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Black;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(769, 10);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(53, 52);
            this.guna2CircleButton1.TabIndex = 74;
            this.guna2CircleButton1.Text = "X";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // uc_Customer1
            // 
            this.uc_Customer1.BackColor = System.Drawing.Color.DarkGray;
            this.uc_Customer1.Location = new System.Drawing.Point(12, 10);
            this.uc_Customer1.Name = "uc_Customer1";
            this.uc_Customer1.Size = new System.Drawing.Size(368, 602);
            this.uc_Customer1.TabIndex = 75;
            // 
            // frmDetailsFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.uc_Customer1);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetailsFines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDetailsFinescs";
            this.Load += new System.EventHandler(this.frmDetailsFinescs_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimePicActualReturn;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimePicDueDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimePicBorrowingDate;
        private Guna.UI2.WinForms.Guna2TextBox txtBorrowingId;
        private uc_Customer uc_Customer1;
    }
}