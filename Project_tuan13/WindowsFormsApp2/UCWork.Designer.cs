namespace WindowsFormsApp2
{
    partial class UCWork
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txb_chitiet = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txb_congviec = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_kinhnghiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_tiencong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_week = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_day = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_image = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txb_chitiet
            // 
            this.txb_chitiet.Animated = true;
            this.txb_chitiet.BorderRadius = 15;
            this.txb_chitiet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_chitiet.DefaultText = "";
            this.txb_chitiet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_chitiet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_chitiet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_chitiet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_chitiet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_chitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txb_chitiet.ForeColor = System.Drawing.Color.Black;
            this.txb_chitiet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_chitiet.Location = new System.Drawing.Point(126, 316);
            this.txb_chitiet.Multiline = true;
            this.txb_chitiet.Name = "txb_chitiet";
            this.txb_chitiet.PasswordChar = '\0';
            this.txb_chitiet.PlaceholderText = "";
            this.txb_chitiet.ReadOnly = true;
            this.txb_chitiet.SelectedText = "";
            this.txb_chitiet.Size = new System.Drawing.Size(336, 88);
            this.txb_chitiet.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Mô tả chi tiết";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 51;
            this.label12.Text = "Tiền Công";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 16);
            this.label13.TabIndex = 50;
            this.label13.Text = "Thời gian làm việc trong ngày";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 16);
            this.label14.TabIndex = 55;
            this.label14.Text = "Thời gian làm việc trong tuần";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(240, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 49;
            this.label15.Text = "Kinh Nghiệm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 16);
            this.label16.TabIndex = 48;
            this.label16.Text = "Công Việc";
            // 
            // txb_congviec
            // 
            this.txb_congviec.Animated = true;
            this.txb_congviec.BorderRadius = 15;
            this.txb_congviec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_congviec.DefaultText = "";
            this.txb_congviec.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_congviec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_congviec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_congviec.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_congviec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_congviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txb_congviec.ForeColor = System.Drawing.Color.Black;
            this.txb_congviec.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_congviec.Location = new System.Drawing.Point(89, 35);
            this.txb_congviec.Multiline = true;
            this.txb_congviec.Name = "txb_congviec";
            this.txb_congviec.PasswordChar = '\0';
            this.txb_congviec.PlaceholderText = "";
            this.txb_congviec.ReadOnly = true;
            this.txb_congviec.SelectedText = "";
            this.txb_congviec.Size = new System.Drawing.Size(135, 42);
            this.txb_congviec.TabIndex = 57;
            // 
            // txb_kinhnghiem
            // 
            this.txb_kinhnghiem.Animated = true;
            this.txb_kinhnghiem.BorderRadius = 15;
            this.txb_kinhnghiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_kinhnghiem.DefaultText = "";
            this.txb_kinhnghiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_kinhnghiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_kinhnghiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_kinhnghiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_kinhnghiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_kinhnghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txb_kinhnghiem.ForeColor = System.Drawing.Color.Black;
            this.txb_kinhnghiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_kinhnghiem.Location = new System.Drawing.Point(328, 35);
            this.txb_kinhnghiem.Multiline = true;
            this.txb_kinhnghiem.Name = "txb_kinhnghiem";
            this.txb_kinhnghiem.PasswordChar = '\0';
            this.txb_kinhnghiem.PlaceholderText = "";
            this.txb_kinhnghiem.ReadOnly = true;
            this.txb_kinhnghiem.SelectedText = "";
            this.txb_kinhnghiem.Size = new System.Drawing.Size(134, 42);
            this.txb_kinhnghiem.TabIndex = 57;
            // 
            // txb_tiencong
            // 
            this.txb_tiencong.Animated = true;
            this.txb_tiencong.BorderRadius = 15;
            this.txb_tiencong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_tiencong.DefaultText = "";
            this.txb_tiencong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_tiencong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_tiencong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_tiencong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_tiencong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_tiencong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txb_tiencong.ForeColor = System.Drawing.Color.Black;
            this.txb_tiencong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_tiencong.Location = new System.Drawing.Point(89, 105);
            this.txb_tiencong.Multiline = true;
            this.txb_tiencong.Name = "txb_tiencong";
            this.txb_tiencong.PasswordChar = '\0';
            this.txb_tiencong.PlaceholderText = "";
            this.txb_tiencong.ReadOnly = true;
            this.txb_tiencong.SelectedText = "";
            this.txb_tiencong.Size = new System.Drawing.Size(135, 42);
            this.txb_tiencong.TabIndex = 57;
            // 
            // txb_week
            // 
            this.txb_week.Animated = true;
            this.txb_week.BorderRadius = 15;
            this.txb_week.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_week.DefaultText = "";
            this.txb_week.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_week.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_week.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_week.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_week.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_week.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txb_week.ForeColor = System.Drawing.Color.Black;
            this.txb_week.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_week.Location = new System.Drawing.Point(202, 170);
            this.txb_week.Multiline = true;
            this.txb_week.Name = "txb_week";
            this.txb_week.PasswordChar = '\0';
            this.txb_week.PlaceholderText = "";
            this.txb_week.ReadOnly = true;
            this.txb_week.SelectedText = "";
            this.txb_week.Size = new System.Drawing.Size(260, 42);
            this.txb_week.TabIndex = 57;
            // 
            // txb_day
            // 
            this.txb_day.Animated = true;
            this.txb_day.BorderRadius = 15;
            this.txb_day.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_day.DefaultText = "";
            this.txb_day.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_day.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_day.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_day.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_day.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txb_day.ForeColor = System.Drawing.Color.Black;
            this.txb_day.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_day.Location = new System.Drawing.Point(202, 237);
            this.txb_day.Multiline = true;
            this.txb_day.Name = "txb_day";
            this.txb_day.PasswordChar = '\0';
            this.txb_day.PlaceholderText = "";
            this.txb_day.ReadOnly = true;
            this.txb_day.SelectedText = "";
            this.txb_day.Size = new System.Drawing.Size(260, 42);
            this.txb_day.TabIndex = 57;
            // 
            // panel_image
            // 
            this.panel_image.Location = new System.Drawing.Point(126, 410);
            this.panel_image.Name = "panel_image";
            this.panel_image.Size = new System.Drawing.Size(336, 108);
            this.panel_image.TabIndex = 58;
            // 
            // UCWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel_image);
            this.Controls.Add(this.txb_day);
            this.Controls.Add(this.txb_week);
            this.Controls.Add(this.txb_tiencong);
            this.Controls.Add(this.txb_kinhnghiem);
            this.Controls.Add(this.txb_congviec);
            this.Controls.Add(this.txb_chitiet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Name = "UCWork";
            this.Size = new System.Drawing.Size(503, 559);
            this.Load += new System.EventHandler(this.UCWork_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txb_chitiet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txb_day;
        private Guna.UI2.WinForms.Guna2TextBox txb_week;
        private Guna.UI2.WinForms.Guna2TextBox txb_tiencong;
        private Guna.UI2.WinForms.Guna2TextBox txb_kinhnghiem;
        private Guna.UI2.WinForms.Guna2TextBox txb_congviec;
        private System.Windows.Forms.FlowLayoutPanel panel_image;
    }
}
