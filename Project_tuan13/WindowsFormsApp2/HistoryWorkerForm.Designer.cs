namespace WindowsFormsApp2
{
    partial class HistoryWorkerForm
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cb_thoYT = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.end_day = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.start_day = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.txb_timkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_daHoanThanh = new Guna.UI2.WinForms.Guna2Button();
            this.btn_danglam = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // flContainer
            // 
            this.flContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.flContainer.Location = new System.Drawing.Point(270, 19);
            this.flContainer.Name = "flContainer";
            this.flContainer.Size = new System.Drawing.Size(790, 651);
            this.flContainer.TabIndex = 1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.flContainer;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btn_danglam);
            this.guna2ShadowPanel1.Controls.Add(this.btn_daHoanThanh);
            this.guna2ShadowPanel1.Controls.Add(this.cb_thoYT);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator3);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Button11);
            this.guna2ShadowPanel1.Controls.Add(this.end_day);
            this.guna2ShadowPanel1.Controls.Add(this.start_day);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.label8);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator4);
            this.guna2ShadowPanel1.Controls.Add(this.txb_timkiem);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(21, 8);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(233, 674);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // cb_thoYT
            // 
            this.cb_thoYT.AutoSize = true;
            this.cb_thoYT.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_thoYT.CheckedState.BorderRadius = 0;
            this.cb_thoYT.CheckedState.BorderThickness = 0;
            this.cb_thoYT.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_thoYT.Location = new System.Drawing.Point(23, 342);
            this.cb_thoYT.Name = "cb_thoYT";
            this.cb_thoYT.Size = new System.Drawing.Size(93, 17);
            this.cb_thoYT.TabIndex = 46;
            this.cb_thoYT.Text = "Thợ yêu thích";
            this.cb_thoYT.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_thoYT.UncheckedState.BorderRadius = 0;
            this.cb_thoYT.UncheckedState.BorderThickness = 0;
            this.cb_thoYT.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_thoYT.CheckedChanged += new System.EventHandler(this.cb_thoYT_CheckedChanged);
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Location = new System.Drawing.Point(19, 312);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator3.TabIndex = 45;
            // 
            // guna2Button11
            // 
            this.guna2Button11.AutoRoundedCorners = true;
            this.guna2Button11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button11.BorderRadius = 16;
            this.guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button11.ForeColor = System.Drawing.Color.White;
            this.guna2Button11.Location = new System.Drawing.Point(58, 259);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.ShadowDecoration.BorderRadius = 21;
            this.guna2Button11.ShadowDecoration.Enabled = true;
            this.guna2Button11.Size = new System.Drawing.Size(111, 34);
            this.guna2Button11.TabIndex = 44;
            this.guna2Button11.Text = "Áp dụng";
            this.guna2Button11.Click += new System.EventHandler(this.guna2Button11_Click);
            // 
            // end_day
            // 
            this.end_day.Animated = true;
            this.end_day.BorderRadius = 10;
            this.end_day.Checked = true;
            this.end_day.CustomFormat = "dd/MM/yyyy";
            this.end_day.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.end_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_day.Location = new System.Drawing.Point(19, 193);
            this.end_day.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.end_day.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.end_day.Name = "end_day";
            this.end_day.Size = new System.Drawing.Size(200, 36);
            this.end_day.TabIndex = 43;
            this.end_day.Value = new System.DateTime(2024, 3, 10, 18, 35, 49, 58);
            // 
            // start_day
            // 
            this.start_day.Animated = true;
            this.start_day.BorderRadius = 10;
            this.start_day.Checked = true;
            this.start_day.CustomFormat = "dd/MM/yyyy";
            this.start_day.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.start_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_day.Location = new System.Drawing.Point(19, 124);
            this.start_day.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.start_day.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.start_day.Name = "start_day";
            this.start_day.Size = new System.Drawing.Size(200, 36);
            this.start_day.TabIndex = 42;
            this.start_day.Value = new System.DateTime(2024, 3, 10, 18, 35, 49, 58);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Tới ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Từ ngày";
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Location = new System.Drawing.Point(19, 75);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator4.TabIndex = 37;
            // 
            // txb_timkiem
            // 
            this.txb_timkiem.BackColor = System.Drawing.Color.Transparent;
            this.txb_timkiem.BorderRadius = 10;
            this.txb_timkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_timkiem.DefaultText = "";
            this.txb_timkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_timkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_timkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_timkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_timkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_timkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_timkiem.IconLeft = global::WindowsFormsApp2.Properties.Resources.search;
            this.txb_timkiem.Location = new System.Drawing.Point(19, 20);
            this.txb_timkiem.Name = "txb_timkiem";
            this.txb_timkiem.PasswordChar = '\0';
            this.txb_timkiem.PlaceholderText = "Tìm theo tên";
            this.txb_timkiem.SelectedText = "";
            this.txb_timkiem.Size = new System.Drawing.Size(200, 38);
            this.txb_timkiem.TabIndex = 36;
            this.txb_timkiem.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // btn_daHoanThanh
            // 
            this.btn_daHoanThanh.AutoRoundedCorners = true;
            this.btn_daHoanThanh.BackColor = System.Drawing.Color.Transparent;
            this.btn_daHoanThanh.BorderRadius = 5;
            this.btn_daHoanThanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_daHoanThanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_daHoanThanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_daHoanThanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_daHoanThanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_daHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_daHoanThanh.ForeColor = System.Drawing.Color.White;
            this.btn_daHoanThanh.Location = new System.Drawing.Point(19, 380);
            this.btn_daHoanThanh.Name = "btn_daHoanThanh";
            this.btn_daHoanThanh.ShadowDecoration.BorderRadius = 21;
            this.btn_daHoanThanh.ShadowDecoration.Enabled = true;
            this.btn_daHoanThanh.Size = new System.Drawing.Size(200, 34);
            this.btn_daHoanThanh.TabIndex = 47;
            this.btn_daHoanThanh.Text = "Đã hoàn thành";
            this.btn_daHoanThanh.Click += new System.EventHandler(this.btn_daHoanThanh_Click);
            // 
            // btn_danglam
            // 
            this.btn_danglam.AutoRoundedCorners = true;
            this.btn_danglam.BackColor = System.Drawing.Color.Transparent;
            this.btn_danglam.BorderRadius = 5;
            this.btn_danglam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_danglam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_danglam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_danglam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_danglam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_danglam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_danglam.ForeColor = System.Drawing.Color.White;
            this.btn_danglam.Location = new System.Drawing.Point(19, 427);
            this.btn_danglam.Name = "btn_danglam";
            this.btn_danglam.ShadowDecoration.BorderRadius = 21;
            this.btn_danglam.ShadowDecoration.Enabled = true;
            this.btn_danglam.Size = new System.Drawing.Size(200, 34);
            this.btn_danglam.TabIndex = 47;
            this.btn_danglam.Text = "Đang làm";
            this.btn_danglam.Click += new System.EventHandler(this.btn_danglam_Click);
            // 
            // HistoryWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1081, 684);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.flContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryWorkerForm";
            this.Text = "HistoryWorkerForm";
            this.Load += new System.EventHandler(this.HistoryWorkerForm_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.FlowLayoutPanel flContainer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2DateTimePicker end_day;
        private Guna.UI2.WinForms.Guna2DateTimePicker start_day;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2TextBox txb_timkiem;
        private Guna.UI2.WinForms.Guna2CheckBox cb_thoYT;
        private Guna.UI2.WinForms.Guna2Button btn_danglam;
        private Guna.UI2.WinForms.Guna2Button btn_daHoanThanh;
    }
}