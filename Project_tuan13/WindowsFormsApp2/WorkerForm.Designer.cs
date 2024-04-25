namespace WindowsFormsApp2
{
    partial class WorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PanelContain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelMenu = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignout = new Guna.UI2.WinForms.Guna2Button();
            this.btnWork = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnNotifica = new Guna.UI2.WinForms.Guna2Button();
            this.btnInfo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.WorkerID_lbl = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // PanelContain
            // 
            this.PanelContain.Location = new System.Drawing.Point(251, 56);
            this.PanelContain.Name = "PanelContain";
            this.PanelContain.Size = new System.Drawing.Size(1091, 689);
            this.PanelContain.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.IndicateFocus = true;
            this.btnClose.Location = new System.Drawing.Point(1307, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Size = new System.Drawing.Size(35, 36);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnHistory);
            this.panelMenu.Controls.Add(this.btnSignout);
            this.panelMenu.Controls.Add(this.btnWork);
            this.panelMenu.Controls.Add(this.btnOrder);
            this.panelMenu.Controls.Add(this.btnNotifica);
            this.panelMenu.Controls.Add(this.btnInfo);
            this.panelMenu.Controls.Add(this.guna2Separator3);
            this.panelMenu.Controls.Add(this.guna2Separator4);
            this.panelMenu.Controls.Add(this.WorkerID_lbl);
            this.panelMenu.Controls.Add(this.guna2PictureBox2);
            this.panelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.ShadowColor = System.Drawing.Color.Black;
            this.panelMenu.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panelMenu.Size = new System.Drawing.Size(234, 767);
            this.panelMenu.TabIndex = 0;
            // 
            // btnHistory
            // 
            this.btnHistory.Animated = true;
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BorderRadius = 20;
            this.btnHistory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHistory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.CustomImages.Image = global::WindowsFormsApp2.Properties.Resources.history;
            this.btnHistory.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.btnHistory.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Location = new System.Drawing.Point(24, 368);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnHistory.Size = new System.Drawing.Size(200, 53);
            this.btnHistory.TabIndex = 16;
            this.btnHistory.Text = "Lịch Sử";
            this.btnHistory.UseTransparentBackground = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnSignout
            // 
            this.btnSignout.BackColor = System.Drawing.Color.Transparent;
            this.btnSignout.BorderRadius = 20;
            this.btnSignout.CustomImages.Image = global::WindowsFormsApp2.Properties.Resources.logout;
            this.btnSignout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignout.FillColor = System.Drawing.Color.White;
            this.btnSignout.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.ForeColor = System.Drawing.Color.Black;
            this.btnSignout.Location = new System.Drawing.Point(14, 565);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.ShadowDecoration.BorderRadius = 25;
            this.btnSignout.ShadowDecoration.Enabled = true;
            this.btnSignout.Size = new System.Drawing.Size(210, 45);
            this.btnSignout.TabIndex = 21;
            this.btnSignout.Text = "Đăng xuất";
            this.btnSignout.UseTransparentBackground = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSinUp_Click);
            // 
            // btnWork
            // 
            this.btnWork.Animated = true;
            this.btnWork.BackColor = System.Drawing.Color.Transparent;
            this.btnWork.BorderRadius = 20;
            this.btnWork.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnWork.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWork.CustomImages.Image = global::WindowsFormsApp2.Properties.Resources.suitcase;
            this.btnWork.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWork.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWork.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWork.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWork.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWork.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.btnWork.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWork.ForeColor = System.Drawing.Color.Black;
            this.btnWork.Location = new System.Drawing.Point(24, 296);
            this.btnWork.Name = "btnWork";
            this.btnWork.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnWork.Size = new System.Drawing.Size(200, 53);
            this.btnWork.TabIndex = 17;
            this.btnWork.Text = "Công Việc";
            this.btnWork.UseTransparentBackground = true;
            this.btnWork.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Animated = true;
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BorderRadius = 20;
            this.btnOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.CustomImages.Image = global::WindowsFormsApp2.Properties.Resources.calendar;
            this.btnOrder.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.btnOrder.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(24, 214);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnOrder.Size = new System.Drawing.Size(200, 53);
            this.btnOrder.TabIndex = 18;
            this.btnOrder.Text = "Nhận Lịch";
            this.btnOrder.UseTransparentBackground = true;
            this.btnOrder.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnNotifica
            // 
            this.btnNotifica.Animated = true;
            this.btnNotifica.BackColor = System.Drawing.Color.Transparent;
            this.btnNotifica.BorderRadius = 20;
            this.btnNotifica.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNotifica.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnNotifica.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnNotifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotifica.CustomImages.Image = global::WindowsFormsApp2.Properties.Resources.notification;
            this.btnNotifica.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNotifica.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNotifica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNotifica.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNotifica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNotifica.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.btnNotifica.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifica.ForeColor = System.Drawing.Color.Black;
            this.btnNotifica.Location = new System.Drawing.Point(24, 453);
            this.btnNotifica.Name = "btnNotifica";
            this.btnNotifica.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnNotifica.Size = new System.Drawing.Size(200, 53);
            this.btnNotifica.TabIndex = 19;
            this.btnNotifica.Text = "Thông Báo";
            this.btnNotifica.UseTransparentBackground = true;
            this.btnNotifica.Click += new System.EventHandler(this.btnNotifica_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Animated = true;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BorderRadius = 20;
            this.btnInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInfo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnInfo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.CustomImages.Image = global::WindowsFormsApp2.Properties.Resources.user;
            this.btnInfo.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.btnInfo.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.Location = new System.Drawing.Point(24, 130);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.btnInfo.Size = new System.Drawing.Size(200, 53);
            this.btnInfo.TabIndex = 20;
            this.btnInfo.Text = "Thông Tin";
            this.btnInfo.UseTransparentBackground = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.guna2Separator3.Location = new System.Drawing.Point(14, 81);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator3.TabIndex = 14;
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.guna2Separator4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.guna2Separator4.Location = new System.Drawing.Point(14, 512);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator4.TabIndex = 15;
            // 
            // WorkerID_lbl
            // 
            this.WorkerID_lbl.AutoSize = true;
            this.WorkerID_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.WorkerID_lbl.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerID_lbl.Location = new System.Drawing.Point(92, 21);
            this.WorkerID_lbl.Name = "WorkerID_lbl";
            this.WorkerID_lbl.Size = new System.Drawing.Size(103, 20);
            this.WorkerID_lbl.TabIndex = 13;
            this.WorkerID_lbl.Text = "Nguyễn Văn A";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.user;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(14, 12);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(50, 48);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 11;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1354, 757);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.PanelContain);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerForm";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel PanelContain;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelMenu;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button btnSignout;
        private Guna.UI2.WinForms.Guna2Button btnWork;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Button btnNotifica;
        private Guna.UI2.WinForms.Guna2Button btnInfo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        public System.Windows.Forms.Label WorkerID_lbl;
    }
}