namespace WindowsFormsApp2
{
    partial class UCWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWorker));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblRating = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.rating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.ptb_avt = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_tiencong = new System.Windows.Forms.Label();
            this.lbl_kinhnghiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(12, 235);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(60, 15);
            this.lblRating.TabIndex = 3;
            this.lblRating.Text = "Đánh giá:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Họ tên:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(12, 159);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(82, 15);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Số điện thoại:";
            // 
            // rating
            // 
            this.rating.BorderColor = System.Drawing.Color.Black;
            this.rating.Location = new System.Drawing.Point(74, 229);
            this.rating.Name = "rating";
            this.rating.RatingColor = System.Drawing.Color.Yellow;
            this.rating.ReadOnly = true;
            this.rating.Size = new System.Drawing.Size(120, 28);
            this.rating.TabIndex = 7;
            // 
            // ptb_avt
            // 
            this.ptb_avt.Image = ((System.Drawing.Image)(resources.GetObject("ptb_avt.Image")));
            this.ptb_avt.ImageRotate = 0F;
            this.ptb_avt.Location = new System.Drawing.Point(44, 3);
            this.ptb_avt.Name = "ptb_avt";
            this.ptb_avt.Size = new System.Drawing.Size(126, 117);
            this.ptb_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avt.TabIndex = 6;
            this.ptb_avt.TabStop = false;
            // 
            // lbl_tiencong
            // 
            this.lbl_tiencong.AutoSize = true;
            this.lbl_tiencong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiencong.Location = new System.Drawing.Point(12, 207);
            this.lbl_tiencong.Name = "lbl_tiencong";
            this.lbl_tiencong.Size = new System.Drawing.Size(63, 15);
            this.lbl_tiencong.TabIndex = 5;
            this.lbl_tiencong.Text = "Tiền Công";
            // 
            // lbl_kinhnghiem
            // 
            this.lbl_kinhnghiem.AutoSize = true;
            this.lbl_kinhnghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kinhnghiem.Location = new System.Drawing.Point(12, 183);
            this.lbl_kinhnghiem.Name = "lbl_kinhnghiem";
            this.lbl_kinhnghiem.Size = new System.Drawing.Size(79, 15);
            this.lbl_kinhnghiem.TabIndex = 5;
            this.lbl_kinhnghiem.Text = "Kinh Nghiệm";
            // 
            // UCWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rating);
            this.Controls.Add(this.ptb_avt);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lbl_kinhnghiem);
            this.Controls.Add(this.lbl_tiencong);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UCWorker";
            this.Size = new System.Drawing.Size(218, 273);
            this.Load += new System.EventHandler(this.UCWorker_Load);
            this.Click += new System.EventHandler(this.UCWorker_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox ptb_avt;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2RatingStar rating;
        private System.Windows.Forms.Label lbl_kinhnghiem;
        private System.Windows.Forms.Label lbl_tiencong;
    }
}
