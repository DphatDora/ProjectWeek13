namespace WindowsFormsApp2
{
    partial class HistoryWorker2Form
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
            this.lbl_date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_thanhtoan = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.rating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.txb_danhgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_danhgia = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPicture = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.flContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbtn_yeuThich = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lbl_congviec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("UTM Alberta Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(38, 167);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(61, 25);
            this.lbl_date.TabIndex = 13;
            this.lbl_date.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Alberta Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đánh giá:";
            // 
            // lbl_thanhtoan
            // 
            this.lbl_thanhtoan.AutoSize = true;
            this.lbl_thanhtoan.Font = new System.Drawing.Font("UTM Alberta Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thanhtoan.Location = new System.Drawing.Point(38, 121);
            this.lbl_thanhtoan.Name = "lbl_thanhtoan";
            this.lbl_thanhtoan.Size = new System.Drawing.Size(181, 25);
            this.lbl_thanhtoan.TabIndex = 15;
            this.lbl_thanhtoan.Text = "Tiền đã thanh toán:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("UTM Alberta Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(38, 36);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(74, 25);
            this.lbl_name.TabIndex = 16;
            this.lbl_name.Text = "Họ tên:";
            // 
            // rating
            // 
            this.rating.BackColor = System.Drawing.Color.White;
            this.rating.BorderColor = System.Drawing.Color.Black;
            this.rating.Location = new System.Drawing.Point(149, 213);
            this.rating.Name = "rating";
            this.rating.RatingColor = System.Drawing.Color.Yellow;
            this.rating.Size = new System.Drawing.Size(120, 28);
            this.rating.TabIndex = 17;
            // 
            // txb_danhgia
            // 
            this.txb_danhgia.Animated = true;
            this.txb_danhgia.BorderRadius = 15;
            this.txb_danhgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_danhgia.DefaultText = "";
            this.txb_danhgia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_danhgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_danhgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_danhgia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_danhgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_danhgia.Font = new System.Drawing.Font("UTM Alberta Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_danhgia.ForeColor = System.Drawing.Color.Black;
            this.txb_danhgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_danhgia.Location = new System.Drawing.Point(42, 254);
            this.txb_danhgia.Multiline = true;
            this.txb_danhgia.Name = "txb_danhgia";
            this.txb_danhgia.PasswordChar = '\0';
            this.txb_danhgia.PlaceholderText = "";
            this.txb_danhgia.SelectedText = "";
            this.txb_danhgia.Size = new System.Drawing.Size(465, 109);
            this.txb_danhgia.TabIndex = 18;
            // 
            // btn_danhgia
            // 
            this.btn_danhgia.Animated = true;
            this.btn_danhgia.AutoRoundedCorners = true;
            this.btn_danhgia.BackColor = System.Drawing.Color.Transparent;
            this.btn_danhgia.BorderRadius = 16;
            this.btn_danhgia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_danhgia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_danhgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_danhgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_danhgia.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_danhgia.ForeColor = System.Drawing.Color.White;
            this.btn_danhgia.Location = new System.Drawing.Point(361, 625);
            this.btn_danhgia.Name = "btn_danhgia";
            this.btn_danhgia.ShadowDecoration.BorderRadius = 26;
            this.btn_danhgia.ShadowDecoration.Enabled = true;
            this.btn_danhgia.Size = new System.Drawing.Size(106, 35);
            this.btn_danhgia.TabIndex = 19;
            this.btn_danhgia.Text = "Gửi";
            this.btn_danhgia.Click += new System.EventHandler(this.btn_danhgia_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Animated = true;
            this.btnAddPicture.AutoRoundedCorners = true;
            this.btnAddPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPicture.BorderRadius = 16;
            this.btnAddPicture.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPicture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPicture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPicture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPicture.FillColor = System.Drawing.Color.Silver;
            this.btnAddPicture.Font = new System.Drawing.Font("UTM Alberta Heavy", 11.25F);
            this.btnAddPicture.ForeColor = System.Drawing.Color.Black;
            this.btnAddPicture.Location = new System.Drawing.Point(105, 625);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.ShadowDecoration.BorderRadius = 26;
            this.btnAddPicture.ShadowDecoration.Enabled = true;
            this.btnAddPicture.Size = new System.Drawing.Size(106, 35);
            this.btnAddPicture.TabIndex = 19;
            this.btnAddPicture.Text = "Thêm ảnh";
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.Image = global::WindowsFormsApp2.Properties.Resources.close2;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Image = global::WindowsFormsApp2.Properties.Resources.close2;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.IndicateFocus = true;
            this.btnClose.Location = new System.Drawing.Point(506, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = global::WindowsFormsApp2.Properties.Resources.close2;
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Size = new System.Drawing.Size(35, 36);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // flContainer
            // 
            this.flContainer.AutoScroll = true;
            this.flContainer.AutoSize = true;
            this.flContainer.Location = new System.Drawing.Point(43, 369);
            this.flContainer.Name = "flContainer";
            this.flContainer.Size = new System.Drawing.Size(464, 157);
            this.flContainer.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbtn_yeuThich
            // 
            this.cbtn_yeuThich.AutoSize = true;
            this.cbtn_yeuThich.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtn_yeuThich.CheckedState.BorderRadius = 0;
            this.cbtn_yeuThich.CheckedState.BorderThickness = 0;
            this.cbtn_yeuThich.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtn_yeuThich.Location = new System.Drawing.Point(43, 544);
            this.cbtn_yeuThich.Name = "cbtn_yeuThich";
            this.cbtn_yeuThich.Size = new System.Drawing.Size(121, 17);
            this.cbtn_yeuThich.TabIndex = 21;
            this.cbtn_yeuThich.Text = "Đánh dấu yêu thích";
            this.cbtn_yeuThich.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbtn_yeuThich.UncheckedState.BorderRadius = 0;
            this.cbtn_yeuThich.UncheckedState.BorderThickness = 0;
            this.cbtn_yeuThich.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbtn_yeuThich.CheckedChanged += new System.EventHandler(this.cbtn_yeuThich_CheckedChanged);
            // 
            // lbl_congviec
            // 
            this.lbl_congviec.AutoSize = true;
            this.lbl_congviec.Font = new System.Drawing.Font("UTM Alberta Heavy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_congviec.Location = new System.Drawing.Point(38, 77);
            this.lbl_congviec.Name = "lbl_congviec";
            this.lbl_congviec.Size = new System.Drawing.Size(99, 25);
            this.lbl_congviec.TabIndex = 22;
            this.lbl_congviec.Text = "Công việc:";
            // 
            // HistoryWorker2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 699);
            this.Controls.Add(this.lbl_congviec);
            this.Controls.Add(this.cbtn_yeuThich);
            this.Controls.Add(this.flContainer);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.btn_danhgia);
            this.Controls.Add(this.txb_danhgia);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_thanhtoan);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryWorker2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryWorker2Form";
            this.Load += new System.EventHandler(this.HistoryWorker2Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_thanhtoan;
        private System.Windows.Forms.Label lbl_name;
        private Guna.UI2.WinForms.Guna2RatingStar rating;
        private Guna.UI2.WinForms.Guna2TextBox txb_danhgia;
        private Guna.UI2.WinForms.Guna2Button btn_danhgia;
        private Guna.UI2.WinForms.Guna2Button btnAddPicture;
        private System.Windows.Forms.FlowLayoutPanel flContainer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2CheckBox cbtn_yeuThich;
        private System.Windows.Forms.Label lbl_congviec;
    }
}