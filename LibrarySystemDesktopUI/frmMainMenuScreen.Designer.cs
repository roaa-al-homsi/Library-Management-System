namespace LibrarySystem
{
    partial class frmMainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenuScreen));
            this.btnTitle = new Guna.UI2.WinForms.Guna2Button();
            this.btnGenres = new Guna.UI2.WinForms.Guna2Button();
            this.labUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labCurrentUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllBooks = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.picCurrentUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAuthors = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlOptions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogins = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageReservation = new Guna.UI2.WinForms.Guna2Button();
            this.btnBorrowing = new Guna.UI2.WinForms.Guna2Button();
            this.btnFines = new Guna.UI2.WinForms.Guna2Button();
            this.panelMainMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.labLoginDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentUser)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTitle
            // 
            this.btnTitle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTitle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTitle.FillColor = System.Drawing.Color.Transparent;
            this.btnTitle.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.Color.MintCream;
            this.btnTitle.Image = ((System.Drawing.Image)(resources.GetObject("btnTitle.Image")));
            this.btnTitle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTitle.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTitle.Location = new System.Drawing.Point(3, 36);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(435, 42);
            this.btnTitle.TabIndex = 2;
            this.btnTitle.Text = "Home";
            this.btnTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnGenres
            // 
            this.btnGenres.BackColor = System.Drawing.Color.Black;
            this.btnGenres.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenres.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenres.FillColor = System.Drawing.Color.Black;
            this.btnGenres.Font = new System.Drawing.Font("Andalus", 10.8F);
            this.btnGenres.ForeColor = System.Drawing.Color.White;
            this.btnGenres.Image = ((System.Drawing.Image)(resources.GetObject("btnGenres.Image")));
            this.btnGenres.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenres.ImageSize = new System.Drawing.Size(40, 40);
            this.btnGenres.Location = new System.Drawing.Point(0, 373);
            this.btnGenres.Name = "btnGenres";
            this.btnGenres.Size = new System.Drawing.Size(210, 51);
            this.btnGenres.TabIndex = 8;
            this.btnGenres.Tag = "Genres";
            this.btnGenres.Text = "Genres";
            this.btnGenres.Click += new System.EventHandler(this.btnGenres_Click);
            // 
            // labUserName
            // 
            this.labUserName.BackColor = System.Drawing.Color.Transparent;
            this.labUserName.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.labUserName.Location = new System.Drawing.Point(827, 38);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(3, 2);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = null;
            this.labUserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labCurrentUser
            // 
            this.labCurrentUser.AutoSize = false;
            this.labCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.labCurrentUser.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCurrentUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labCurrentUser.Location = new System.Drawing.Point(990, 36);
            this.labCurrentUser.Name = "labCurrentUser";
            this.labCurrentUser.Size = new System.Drawing.Size(160, 37);
            this.labCurrentUser.TabIndex = 0;
            this.labCurrentUser.Text = null;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Black;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FillColor = System.Drawing.Color.Black;
            this.btnUsers.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUsers.Location = new System.Drawing.Point(0, 322);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(210, 51);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Tag = "Users";
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Black;
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FillColor = System.Drawing.Color.Black;
            this.btnCustomers.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCustomers.Location = new System.Drawing.Point(0, 271);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(210, 51);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Tag = "Customers";
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnAllBooks
            // 
            this.btnAllBooks.BackColor = System.Drawing.Color.Black;
            this.btnAllBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllBooks.FillColor = System.Drawing.Color.Black;
            this.btnAllBooks.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllBooks.ForeColor = System.Drawing.Color.White;
            this.btnAllBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnAllBooks.Image")));
            this.btnAllBooks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAllBooks.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAllBooks.Location = new System.Drawing.Point(0, 169);
            this.btnAllBooks.Name = "btnAllBooks";
            this.btnAllBooks.Size = new System.Drawing.Size(210, 51);
            this.btnAllBooks.TabIndex = 2;
            this.btnAllBooks.Tag = "Books";
            this.btnAllBooks.Text = "Books";
            this.btnAllBooks.Click += new System.EventHandler(this.btnAllBooks_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Black;
            this.guna2Panel2.Controls.Add(this.picCurrentUser);
            this.guna2Panel2.Controls.Add(this.btnTitle);
            this.guna2Panel2.Controls.Add(this.labUserName);
            this.guna2Panel2.Controls.Add(this.labCurrentUser);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(210, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1245, 84);
            this.guna2Panel2.TabIndex = 4;
            // 
            // picCurrentUser
            // 
            this.picCurrentUser.Image = ((System.Drawing.Image)(resources.GetObject("picCurrentUser.Image")));
            this.picCurrentUser.ImageRotate = 0F;
            this.picCurrentUser.Location = new System.Drawing.Point(1142, 3);
            this.picCurrentUser.Name = "picCurrentUser";
            this.picCurrentUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picCurrentUser.Size = new System.Drawing.Size(91, 75);
            this.picCurrentUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCurrentUser.TabIndex = 3;
            this.picCurrentUser.TabStop = false;
            // 
            // btnAuthors
            // 
            this.btnAuthors.BackColor = System.Drawing.Color.Black;
            this.btnAuthors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAuthors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAuthors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAuthors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAuthors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuthors.FillColor = System.Drawing.Color.Black;
            this.btnAuthors.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthors.ForeColor = System.Drawing.Color.White;
            this.btnAuthors.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthors.Image")));
            this.btnAuthors.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAuthors.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAuthors.Location = new System.Drawing.Point(0, 220);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(210, 51);
            this.btnAuthors.TabIndex = 3;
            this.btnAuthors.Tag = "   Authors";
            this.btnAuthors.Text = "   Authors";
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(210, 169);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(56, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(96, 95);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Andalus", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 113);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(177, 50);
            this.guna2HtmlLabel3.TabIndex = 48;
            this.guna2HtmlLabel3.Text = "Library System";
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.Black;
            this.pnlOptions.Controls.Add(this.btnLogout);
            this.pnlOptions.Controls.Add(this.btnLogins);
            this.pnlOptions.Controls.Add(this.btnManageReservation);
            this.pnlOptions.Controls.Add(this.btnBorrowing);
            this.pnlOptions.Controls.Add(this.btnFines);
            this.pnlOptions.Controls.Add(this.btnGenres);
            this.pnlOptions.Controls.Add(this.btnUsers);
            this.pnlOptions.Controls.Add(this.btnCustomers);
            this.pnlOptions.Controls.Add(this.btnAuthors);
            this.pnlOptions.Controls.Add(this.btnAllBooks);
            this.pnlOptions.Controls.Add(this.guna2Panel1);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(210, 759);
            this.pnlOptions.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FillColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(0, 628);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(210, 51);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Tag = "Logout";
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogins
            // 
            this.btnLogins.BackColor = System.Drawing.Color.Black;
            this.btnLogins.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogins.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogins.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogins.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogins.FillColor = System.Drawing.Color.Black;
            this.btnLogins.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogins.ForeColor = System.Drawing.Color.White;
            this.btnLogins.Image = ((System.Drawing.Image)(resources.GetObject("btnLogins.Image")));
            this.btnLogins.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogins.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogins.Location = new System.Drawing.Point(0, 577);
            this.btnLogins.Name = "btnLogins";
            this.btnLogins.Size = new System.Drawing.Size(210, 51);
            this.btnLogins.TabIndex = 12;
            this.btnLogins.Tag = "Logins";
            this.btnLogins.Text = "Logins";
            this.btnLogins.Click += new System.EventHandler(this.btnLogins_Click);
            // 
            // btnManageReservation
            // 
            this.btnManageReservation.BackColor = System.Drawing.Color.Black;
            this.btnManageReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageReservation.FillColor = System.Drawing.Color.Black;
            this.btnManageReservation.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageReservation.ForeColor = System.Drawing.Color.White;
            this.btnManageReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnManageReservation.Image")));
            this.btnManageReservation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageReservation.ImageSize = new System.Drawing.Size(40, 40);
            this.btnManageReservation.Location = new System.Drawing.Point(0, 526);
            this.btnManageReservation.Name = "btnManageReservation";
            this.btnManageReservation.Size = new System.Drawing.Size(210, 51);
            this.btnManageReservation.TabIndex = 11;
            this.btnManageReservation.Tag = "Reservations";
            this.btnManageReservation.Text = "Reservations";
            this.btnManageReservation.Click += new System.EventHandler(this.btnManageReservation_Click);
            // 
            // btnBorrowing
            // 
            this.btnBorrowing.BackColor = System.Drawing.Color.Black;
            this.btnBorrowing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrowing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrowing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrowing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBorrowing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowing.FillColor = System.Drawing.Color.Black;
            this.btnBorrowing.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowing.ForeColor = System.Drawing.Color.White;
            this.btnBorrowing.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrowing.Image")));
            this.btnBorrowing.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBorrowing.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBorrowing.Location = new System.Drawing.Point(0, 475);
            this.btnBorrowing.Name = "btnBorrowing";
            this.btnBorrowing.Size = new System.Drawing.Size(210, 51);
            this.btnBorrowing.TabIndex = 10;
            this.btnBorrowing.Tag = "Borrowing";
            this.btnBorrowing.Text = "Borrowing";
            this.btnBorrowing.Click += new System.EventHandler(this.btnBorrowing_Click);
            // 
            // btnFines
            // 
            this.btnFines.BackColor = System.Drawing.Color.Black;
            this.btnFines.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFines.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFines.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFines.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFines.FillColor = System.Drawing.Color.Black;
            this.btnFines.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFines.ForeColor = System.Drawing.Color.White;
            this.btnFines.Image = ((System.Drawing.Image)(resources.GetObject("btnFines.Image")));
            this.btnFines.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFines.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFines.Location = new System.Drawing.Point(0, 424);
            this.btnFines.Name = "btnFines";
            this.btnFines.Size = new System.Drawing.Size(210, 51);
            this.btnFines.TabIndex = 9;
            this.btnFines.Tag = "Fines";
            this.btnFines.Text = "Fines";
            this.btnFines.Click += new System.EventHandler(this.btnFines_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMainMenu.Controls.Add(this.labLoginDate);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.FillColor = System.Drawing.Color.Black;
            this.panelMainMenu.Location = new System.Drawing.Point(210, 84);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1245, 675);
            this.panelMainMenu.TabIndex = 5;
            // 
            // labLoginDate
            // 
            this.labLoginDate.AutoSize = false;
            this.labLoginDate.BackColor = System.Drawing.Color.Transparent;
            this.labLoginDate.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLoginDate.ForeColor = System.Drawing.Color.FloralWhite;
            this.labLoginDate.Location = new System.Drawing.Point(464, 230);
            this.labLoginDate.Name = "labLoginDate";
            this.labLoginDate.Size = new System.Drawing.Size(256, 59);
            this.labLoginDate.TabIndex = 0;
            this.labLoginDate.Text = null;
            this.labLoginDate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 759);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.pnlOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMainMenuScreen_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentUser)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.panelMainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTitle;
        private Guna.UI2.WinForms.Guna2Button btnGenres;
        private Guna.UI2.WinForms.Guna2HtmlLabel labUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel labCurrentUser;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnAllBooks;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnAuthors;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel pnlOptions;
        private Guna.UI2.WinForms.Guna2Panel panelMainMenu;
        private Guna.UI2.WinForms.Guna2Button btnFines;
        private Guna.UI2.WinForms.Guna2Button btnBorrowing;
        private Guna.UI2.WinForms.Guna2Button btnManageReservation;
        private Guna.UI2.WinForms.Guna2Button btnLogins;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picCurrentUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel labLoginDate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}

