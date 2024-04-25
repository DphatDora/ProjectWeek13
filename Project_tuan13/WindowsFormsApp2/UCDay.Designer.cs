namespace WindowsFormsApp2
{
    partial class UCDay
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
            this.lblday = new System.Windows.Forms.Label();
            this.lbl_sukien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Font = new System.Drawing.Font("UTM Alberta Heavy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.Location = new System.Drawing.Point(13, 9);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(21, 14);
            this.lblday.TabIndex = 1;
            this.lblday.Text = "00";
            // 
            // lbl_sukien
            // 
            this.lbl_sukien.AutoSize = true;
            this.lbl_sukien.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sukien.Font = new System.Drawing.Font("UTM Alberta Heavy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sukien.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_sukien.Location = new System.Drawing.Point(13, 48);
            this.lbl_sukien.Name = "lbl_sukien";
            this.lbl_sukien.Size = new System.Drawing.Size(110, 14);
            this.lbl_sukien.TabIndex = 1;
            this.lbl_sukien.Text = "Không có sự kiện nào";
            // 
            // UCDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_sukien);
            this.Controls.Add(this.lblday);
            this.Name = "UCDay";
            this.Size = new System.Drawing.Size(144, 94);
            this.Load += new System.EventHandler(this.UCDay_Load);
            this.Click += new System.EventHandler(this.UCDay_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lbl_sukien;
    }
}
