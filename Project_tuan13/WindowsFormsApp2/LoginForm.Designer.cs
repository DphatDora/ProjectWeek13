namespace WindowsFormsApp2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlLogin = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlSinUp = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.workerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustom = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSignUp2 = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassWord2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_workerlogin = new Guna.UI2.WinForms.Guna2Button();
            this.btn_userlogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPasslogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            this.pnlSinUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.pnlSinUp);
            this.pnlLogin.Controls.Add(this.btn_workerlogin);
            this.pnlLogin.Controls.Add(this.btn_userlogin);
            this.pnlLogin.Controls.Add(this.txtPasslogin);
            this.pnlLogin.Controls.Add(this.txbLogin);
            this.pnlLogin.Controls.Add(this.btnSignUp);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.FillColor = System.Drawing.SystemColors.Control;
            this.pnlLogin.Location = new System.Drawing.Point(0, -1);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlLogin.ShadowShift = 10;
            this.pnlLogin.Size = new System.Drawing.Size(375, 562);
            this.pnlLogin.TabIndex = 8;
            // 
            // pnlSinUp
            // 
            this.pnlSinUp.BackColor = System.Drawing.Color.Transparent;
            this.pnlSinUp.Controls.Add(this.workerBtn);
            this.pnlSinUp.Controls.Add(this.btnCustom);
            this.pnlSinUp.Controls.Add(this.btnBack);
            this.pnlSinUp.Controls.Add(this.btnSignUp2);
            this.pnlSinUp.Controls.Add(this.txtPassWord2);
            this.pnlSinUp.Controls.Add(this.txtPassWord);
            this.pnlSinUp.Controls.Add(this.txtPhone);
            this.pnlSinUp.Controls.Add(this.txtEmail);
            this.pnlSinUp.Controls.Add(this.txtName);
            this.pnlSinUp.Controls.Add(this.label4);
            this.pnlSinUp.FillColor = System.Drawing.SystemColors.Control;
            this.pnlSinUp.Location = new System.Drawing.Point(0, 0);
            this.pnlSinUp.Name = "pnlSinUp";
            this.pnlSinUp.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlSinUp.ShadowShift = 10;
            this.pnlSinUp.Size = new System.Drawing.Size(375, 562);
            this.pnlSinUp.TabIndex = 8;
            // 
            // workerBtn
            // 
            this.workerBtn.Animated = true;
            this.workerBtn.BorderRadius = 10;
            this.workerBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.workerBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.workerBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.workerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.workerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.workerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.workerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.workerBtn.FillColor = System.Drawing.Color.Transparent;
            this.workerBtn.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F);
            this.workerBtn.ForeColor = System.Drawing.Color.Black;
            this.workerBtn.Location = new System.Drawing.Point(202, 299);
            this.workerBtn.Name = "workerBtn";
            this.workerBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.workerBtn.Size = new System.Drawing.Size(114, 45);
            this.workerBtn.TabIndex = 26;
            this.workerBtn.Text = "Thợ";
            this.workerBtn.Click += new System.EventHandler(this.workerBtn_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Animated = true;
            this.btnCustom.BorderRadius = 10;
            this.btnCustom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustom.CustomImages.Image = global::WindowsFormsApp2.Properties.Resources.user;
            this.btnCustom.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustom.FillColor = System.Drawing.Color.Transparent;
            this.btnCustom.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustom.ForeColor = System.Drawing.Color.Black;
            this.btnCustom.Location = new System.Drawing.Point(55, 299);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCustom.Size = new System.Drawing.Size(114, 45);
            this.btnCustom.TabIndex = 26;
            this.btnCustom.Text = "Khách hàng";
            this.btnCustom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.HoverState.Image = global::WindowsFormsApp2.Properties.Resources.arrow;
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Image = global::WindowsFormsApp2.Properties.Resources.arrow;
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageRotate = 0F;
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(12, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.Image = global::WindowsFormsApp2.Properties.Resources.arrow;
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Size = new System.Drawing.Size(40, 38);
            this.btnBack.TabIndex = 25;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSignUp2
            // 
            this.btnSignUp2.AutoRoundedCorners = true;
            this.btnSignUp2.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp2.BorderRadius = 20;
            this.btnSignUp2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignUp2.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp2.ForeColor = System.Drawing.Color.White;
            this.btnSignUp2.Location = new System.Drawing.Point(46, 483);
            this.btnSignUp2.Name = "btnSignUp2";
            this.btnSignUp2.ShadowDecoration.BorderRadius = 25;
            this.btnSignUp2.ShadowDecoration.Enabled = true;
            this.btnSignUp2.Size = new System.Drawing.Size(270, 42);
            this.btnSignUp2.TabIndex = 24;
            this.btnSignUp2.Text = "Đăng ký";
            this.btnSignUp2.Click += new System.EventHandler(this.btnSignUp2_Click);
            // 
            // txtPassWord2
            // 
            this.txtPassWord2.BorderRadius = 8;
            this.txtPassWord2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord2.DefaultText = "";
            this.txtPassWord2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassWord2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassWord2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord2.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord2.IconRight = ((System.Drawing.Image)(resources.GetObject("txtPassWord2.IconRight")));
            this.txtPassWord2.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtPassWord2.Location = new System.Drawing.Point(55, 422);
            this.txtPassWord2.Name = "txtPassWord2";
            this.txtPassWord2.PasswordChar = '*';
            this.txtPassWord2.PlaceholderText = "Xác nhận mật khẩu";
            this.txtPassWord2.SelectedText = "";
            this.txtPassWord2.Size = new System.Drawing.Size(261, 38);
            this.txtPassWord2.TabIndex = 20;
            // 
            // txtPassWord
            // 
            this.txtPassWord.BorderRadius = 8;
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord.DefaultText = "";
            this.txtPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassWord.Location = new System.Drawing.Point(55, 357);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.PlaceholderText = "Mật Khẩu";
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.Size = new System.Drawing.Size(261, 38);
            this.txtPassWord.TabIndex = 20;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 8;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(55, 254);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "Số điện thoại";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(261, 38);
            this.txtPhone.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(55, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(261, 38);
            this.txtEmail.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.BorderRadius = 8;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(55, 132);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Họ và Tên";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(261, 38);
            this.txtName.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Alberta Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 42);
            this.label4.TabIndex = 15;
            this.label4.Text = "Đăng Ký";
            // 
            // btn_workerlogin
            // 
            this.btn_workerlogin.Animated = true;
            this.btn_workerlogin.BorderRadius = 10;
            this.btn_workerlogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_workerlogin.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btn_workerlogin.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_workerlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_workerlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_workerlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_workerlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_workerlogin.FillColor = System.Drawing.Color.Transparent;
            this.btn_workerlogin.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_workerlogin.ForeColor = System.Drawing.Color.Black;
            this.btn_workerlogin.Location = new System.Drawing.Point(213, 131);
            this.btn_workerlogin.Name = "btn_workerlogin";
            this.btn_workerlogin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_workerlogin.Size = new System.Drawing.Size(114, 45);
            this.btn_workerlogin.TabIndex = 27;
            this.btn_workerlogin.Text = "Thợ";
            this.btn_workerlogin.Click += new System.EventHandler(this.btn_workerlogin_Click);
            // 
            // btn_userlogin
            // 
            this.btn_userlogin.Animated = true;
            this.btn_userlogin.BorderRadius = 10;
            this.btn_userlogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_userlogin.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.btn_userlogin.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_userlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_userlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_userlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_userlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_userlogin.FillColor = System.Drawing.Color.Transparent;
            this.btn_userlogin.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userlogin.ForeColor = System.Drawing.Color.Black;
            this.btn_userlogin.Location = new System.Drawing.Point(66, 131);
            this.btn_userlogin.Name = "btn_userlogin";
            this.btn_userlogin.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_userlogin.Size = new System.Drawing.Size(114, 45);
            this.btn_userlogin.TabIndex = 28;
            this.btn_userlogin.Text = "Khách hàng";
            this.btn_userlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_userlogin.Click += new System.EventHandler(this.btn_userlogin_Click);
            // 
            // txtPasslogin
            // 
            this.txtPasslogin.BorderRadius = 8;
            this.txtPasslogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasslogin.DefaultText = "";
            this.txtPasslogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasslogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasslogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasslogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasslogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasslogin.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasslogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasslogin.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPasslogin.IconLeft")));
            this.txtPasslogin.Location = new System.Drawing.Point(66, 254);
            this.txtPasslogin.Name = "txtPasslogin";
            this.txtPasslogin.PasswordChar = '*';
            this.txtPasslogin.PlaceholderText = "Mật Khẩu";
            this.txtPasslogin.SelectedText = "";
            this.txtPasslogin.Size = new System.Drawing.Size(261, 38);
            this.txtPasslogin.TabIndex = 19;
            // 
            // txbLogin
            // 
            this.txbLogin.BorderRadius = 8;
            this.txbLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLogin.DefaultText = "";
            this.txbLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbLogin.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbLogin.IconLeft = ((System.Drawing.Image)(resources.GetObject("txbLogin.IconLeft")));
            this.txbLogin.Location = new System.Drawing.Point(66, 192);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.PasswordChar = '\0';
            this.txbLogin.PlaceholderText = "Số điện thoại/Email";
            this.txbLogin.SelectedText = "";
            this.txbLogin.Size = new System.Drawing.Size(261, 38);
            this.txbLogin.TabIndex = 20;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoRoundedCorners = true;
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BorderRadius = 20;
            this.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp.FillColor = System.Drawing.Color.White;
            this.btnSignUp.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignUp.Location = new System.Drawing.Point(48, 353);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.ShadowDecoration.BorderRadius = 25;
            this.btnSignUp.ShadowDecoration.Enabled = true;
            this.btnSignUp.Size = new System.Drawing.Size(121, 42);
            this.btnSignUp.TabIndex = 17;
            this.btnSignUp.Text = "Đăng ký";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogin.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(206, 353);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.BorderRadius = 25;
            this.btnLogin.ShadowDecoration.Enabled = true;
            this.btnLogin.Size = new System.Drawing.Size(121, 42);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(125, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Đăng nhập để tiếp tục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Alberta Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "THẾ GIỚI THỢ";
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(847, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Size = new System.Drawing.Size(35, 36);
            this.guna2ImageButton1.TabIndex = 7;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.BackGroundLogin;
            this.pictureBox1.Location = new System.Drawing.Point(371, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 561);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlSinUp.ResumeLayout(false);
            this.pnlSinUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPasslogin;
        private Guna.UI2.WinForms.Guna2TextBox txbLogin;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlSinUp;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPassWord;
        private Guna.UI2.WinForms.Guna2TextBox txtPassWord2;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2Button btnSignUp2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button btnCustom;
        private Guna.UI2.WinForms.Guna2Button workerBtn;
        private Guna.UI2.WinForms.Guna2Button btn_workerlogin;
        private Guna.UI2.WinForms.Guna2Button btn_userlogin;
    }
}

