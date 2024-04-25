namespace WindowsFormsApp2
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.giolamviec = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txb_ghichu = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_datLich = new Guna.UI2.WinForms.Guna2Button();
            this.Messenger = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.ngaylamviec = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txb_diachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.lbl_giatien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết đặt lịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn giờ";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "giờ";
            // 
            // giolamviec
            // 
            this.giolamviec.AutoRoundedCorners = true;
            this.giolamviec.BackColor = System.Drawing.Color.Transparent;
            this.giolamviec.BorderRadius = 17;
            this.giolamviec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.giolamviec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.giolamviec.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.giolamviec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.giolamviec.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giolamviec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.giolamviec.ItemHeight = 30;
            this.giolamviec.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.giolamviec.Location = new System.Drawing.Point(89, 199);
            this.giolamviec.Name = "giolamviec";
            this.giolamviec.Size = new System.Drawing.Size(140, 36);
            this.giolamviec.TabIndex = 4;
            // 
            // txb_ghichu
            // 
            this.txb_ghichu.Animated = true;
            this.txb_ghichu.BorderRadius = 10;
            this.txb_ghichu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_ghichu.DefaultText = "";
            this.txb_ghichu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_ghichu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_ghichu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_ghichu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_ghichu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_ghichu.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ghichu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_ghichu.Location = new System.Drawing.Point(10, 432);
            this.txb_ghichu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_ghichu.Multiline = true;
            this.txb_ghichu.Name = "txb_ghichu";
            this.txb_ghichu.PasswordChar = '\0';
            this.txb_ghichu.PlaceholderText = "";
            this.txb_ghichu.SelectedText = "";
            this.txb_ghichu.Size = new System.Drawing.Size(546, 142);
            this.txb_ghichu.TabIndex = 5;
            // 
            // btn_huy
            // 
            this.btn_huy.Animated = true;
            this.btn_huy.AutoRoundedCorners = true;
            this.btn_huy.BackColor = System.Drawing.Color.Transparent;
            this.btn_huy.BorderRadius = 21;
            this.btn_huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_huy.FillColor = System.Drawing.Color.White;
            this.btn_huy.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_huy.Location = new System.Drawing.Point(63, 611);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.ShadowDecoration.BorderRadius = 25;
            this.btn_huy.ShadowDecoration.Enabled = true;
            this.btn_huy.Size = new System.Drawing.Size(180, 45);
            this.btn_huy.TabIndex = 6;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_datLich
            // 
            this.btn_datLich.Animated = true;
            this.btn_datLich.AutoRoundedCorners = true;
            this.btn_datLich.BackColor = System.Drawing.Color.Transparent;
            this.btn_datLich.BorderRadius = 21;
            this.btn_datLich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_datLich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_datLich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_datLich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_datLich.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datLich.ForeColor = System.Drawing.Color.White;
            this.btn_datLich.Location = new System.Drawing.Point(326, 611);
            this.btn_datLich.Name = "btn_datLich";
            this.btn_datLich.ShadowDecoration.BorderRadius = 26;
            this.btn_datLich.ShadowDecoration.Enabled = true;
            this.btn_datLich.Size = new System.Drawing.Size(180, 45);
            this.btn_datLich.TabIndex = 6;
            this.btn_datLich.Text = "Đặt lịch";
            this.btn_datLich.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Messenger
            // 
            this.Messenger.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.Messenger.Caption = null;
            this.Messenger.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.Messenger.Parent = this;
            this.Messenger.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.Messenger.Text = "Bạn đã đặt lịch thành công";
            // 
            // ngaylamviec
            // 
            this.ngaylamviec.Animated = true;
            this.ngaylamviec.AutoRoundedCorners = true;
            this.ngaylamviec.BackColor = System.Drawing.Color.Transparent;
            this.ngaylamviec.BorderRadius = 17;
            this.ngaylamviec.Checked = true;
            this.ngaylamviec.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ngaylamviec.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaylamviec.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ngaylamviec.Location = new System.Drawing.Point(89, 133);
            this.ngaylamviec.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngaylamviec.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngaylamviec.Name = "ngaylamviec";
            this.ngaylamviec.Size = new System.Drawing.Size(226, 36);
            this.ngaylamviec.TabIndex = 2;
            this.ngaylamviec.Value = new System.DateTime(2024, 3, 13, 14, 47, 2, 618);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(34, 74);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(500, 10);
            this.guna2Separator1.TabIndex = 3;
            // 
            // txb_diachi
            // 
            this.txb_diachi.Animated = true;
            this.txb_diachi.AutoRoundedCorners = true;
            this.txb_diachi.BorderRadius = 19;
            this.txb_diachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_diachi.DefaultText = "";
            this.txb_diachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_diachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_diachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_diachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_diachi.FillColor = System.Drawing.Color.LightGray;
            this.txb_diachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_diachi.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_diachi.ForeColor = System.Drawing.Color.Black;
            this.txb_diachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_diachi.Location = new System.Drawing.Point(121, 250);
            this.txb_diachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_diachi.Name = "txb_diachi";
            this.txb_diachi.PasswordChar = '\0';
            this.txb_diachi.PlaceholderText = "";
            this.txb_diachi.SelectedText = "";
            this.txb_diachi.Size = new System.Drawing.Size(413, 41);
            this.txb_diachi.TabIndex = 38;
            this.txb_diachi.TextChanged += new System.EventHandler(this.txb_diachi_TextChanged);
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diachi.Location = new System.Drawing.Point(12, 262);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(105, 17);
            this.lbl_diachi.TabIndex = 39;
            this.lbl_diachi.Text = "Địa chỉ làm việc:";
            // 
            // lbl_giatien
            // 
            this.lbl_giatien.AutoSize = true;
            this.lbl_giatien.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giatien.Location = new System.Drawing.Point(69, 315);
            this.lbl_giatien.Name = "lbl_giatien";
            this.lbl_giatien.Size = new System.Drawing.Size(40, 17);
            this.lbl_giatien.TabIndex = 40;
            this.lbl_giatien.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UTM Alberta Heavy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Giá tiền:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 711);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_giatien);
            this.Controls.Add(this.lbl_diachi);
            this.Controls.Add(this.txb_diachi);
            this.Controls.Add(this.btn_datLich);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.txb_ghichu);
            this.Controls.Add(this.giolamviec);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.ngaylamviec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbl_diachi;
        private Guna.UI2.WinForms.Guna2TextBox txb_diachi;
        private Guna.UI2.WinForms.Guna2Button btn_datLich;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private Guna.UI2.WinForms.Guna2TextBox txb_ghichu;
        private Guna.UI2.WinForms.Guna2ComboBox giolamviec;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DateTimePicker ngaylamviec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2MessageDialog Messenger;
        private System.Windows.Forms.Label lbl_giatien;
        private System.Windows.Forms.Label label5;
    }
}