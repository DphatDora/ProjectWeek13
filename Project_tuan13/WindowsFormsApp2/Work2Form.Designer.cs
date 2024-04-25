namespace WindowsFormsApp2
{
    partial class Work2Form
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
            this.panelWork = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.flContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAdd = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.chitiet_txb = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.tienCongBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.tc_num = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CongViecBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.hour_start = new Guna.UI2.WinForms.Guna2ComboBox();
            this.day_start = new Guna.UI2.WinForms.Guna2ComboBox();
            this.KinhNghiemBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.hour_end = new Guna.UI2.WinForms.Guna2ComboBox();
            this.day_end = new Guna.UI2.WinForms.Guna2ComboBox();
            this.kn_num = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelWork.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panelWork
            // 
            this.panelWork.BackColor = System.Drawing.Color.Transparent;
            this.panelWork.Controls.Add(this.btnAdd);
            this.panelWork.Controls.Add(this.flContainer);
            this.panelWork.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.panelWork.Location = new System.Drawing.Point(9, 6);
            this.panelWork.Name = "panelWork";
            this.panelWork.ShadowColor = System.Drawing.Color.Black;
            this.panelWork.Size = new System.Drawing.Size(1073, 676);
            this.panelWork.TabIndex = 42;
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 21;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(446, 614);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.BorderRadius = 25;
            this.btnAdd.ShadowDecoration.Enabled = true;
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseTransparentBackground = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flContainer
            // 
            this.flContainer.AutoScroll = true;
            this.flContainer.Location = new System.Drawing.Point(20, 19);
            this.flContainer.Name = "flContainer";
            this.flContainer.Size = new System.Drawing.Size(1039, 589);
            this.flContainer.TabIndex = 0;
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Transparent;
            this.panelAdd.Controls.Add(this.btnBack);
            this.panelAdd.Controls.Add(this.chitiet_txb);
            this.panelAdd.Controls.Add(this.btn_Save);
            this.panelAdd.Controls.Add(this.tienCongBox);
            this.panelAdd.Controls.Add(this.tc_num);
            this.panelAdd.Controls.Add(this.label9);
            this.panelAdd.Controls.Add(this.label10);
            this.panelAdd.Controls.Add(this.label11);
            this.panelAdd.Controls.Add(this.label12);
            this.panelAdd.Controls.Add(this.CongViecBox);
            this.panelAdd.Controls.Add(this.label13);
            this.panelAdd.Controls.Add(this.label14);
            this.panelAdd.Controls.Add(this.label15);
            this.panelAdd.Controls.Add(this.hour_start);
            this.panelAdd.Controls.Add(this.day_start);
            this.panelAdd.Controls.Add(this.KinhNghiemBox);
            this.panelAdd.Controls.Add(this.label16);
            this.panelAdd.Controls.Add(this.hour_end);
            this.panelAdd.Controls.Add(this.day_end);
            this.panelAdd.Controls.Add(this.kn_num);
            this.panelAdd.FillColor = System.Drawing.Color.White;
            this.panelAdd.Location = new System.Drawing.Point(9, 3);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Radius = 13;
            this.panelAdd.ShadowColor = System.Drawing.Color.Black;
            this.panelAdd.Size = new System.Drawing.Size(1073, 676);
            this.panelAdd.TabIndex = 42;
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
            this.btnBack.Location = new System.Drawing.Point(23, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.Image = global::WindowsFormsApp2.Properties.Resources.arrow;
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Size = new System.Drawing.Size(40, 38);
            this.btnBack.TabIndex = 40;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chitiet_txb
            // 
            this.chitiet_txb.Animated = true;
            this.chitiet_txb.BorderRadius = 15;
            this.chitiet_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chitiet_txb.DefaultText = "";
            this.chitiet_txb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chitiet_txb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chitiet_txb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chitiet_txb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chitiet_txb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chitiet_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chitiet_txb.ForeColor = System.Drawing.Color.Black;
            this.chitiet_txb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chitiet_txb.Location = new System.Drawing.Point(536, 424);
            this.chitiet_txb.Multiline = true;
            this.chitiet_txb.Name = "chitiet_txb";
            this.chitiet_txb.PasswordChar = '\0';
            this.chitiet_txb.PlaceholderText = "";
            this.chitiet_txb.SelectedText = "";
            this.chitiet_txb.Size = new System.Drawing.Size(234, 121);
            this.chitiet_txb.TabIndex = 39;
            // 
            // btn_Save
            // 
            this.btn_Save.Animated = true;
            this.btn_Save.AutoRoundedCorners = true;
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BorderRadius = 21;
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(443, 595);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ShadowDecoration.BorderRadius = 25;
            this.btn_Save.ShadowDecoration.Enabled = true;
            this.btn_Save.Size = new System.Drawing.Size(180, 45);
            this.btn_Save.TabIndex = 38;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseTransparentBackground = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tienCongBox
            // 
            this.tienCongBox.Animated = true;
            this.tienCongBox.BorderRadius = 15;
            this.tienCongBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tienCongBox.DefaultText = "";
            this.tienCongBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tienCongBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tienCongBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tienCongBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tienCongBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tienCongBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienCongBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tienCongBox.Location = new System.Drawing.Point(536, 208);
            this.tienCongBox.Name = "tienCongBox";
            this.tienCongBox.PasswordChar = '\0';
            this.tienCongBox.PlaceholderText = "";
            this.tienCongBox.SelectedText = "";
            this.tienCongBox.Size = new System.Drawing.Size(129, 41);
            this.tienCongBox.TabIndex = 38;
            // 
            // tc_num
            // 
            this.tc_num.AutoRoundedCorners = true;
            this.tc_num.BackColor = System.Drawing.Color.Transparent;
            this.tc_num.BorderRadius = 17;
            this.tc_num.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tc_num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tc_num.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tc_num.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tc_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.tc_num.ItemHeight = 30;
            this.tc_num.Items.AddRange(new object[] {
            "/Giờ",
            "/Ngày"});
            this.tc_num.Location = new System.Drawing.Point(671, 208);
            this.tc_num.Name = "tc_num";
            this.tc_num.Size = new System.Drawing.Size(99, 36);
            this.tc_num.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(296, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Mô Tả Chi Tiết";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(640, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Đến";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(640, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Đến";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(296, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Tiền Công";
            // 
            // CongViecBox
            // 
            this.CongViecBox.AutoRoundedCorners = true;
            this.CongViecBox.BackColor = System.Drawing.Color.Transparent;
            this.CongViecBox.BorderRadius = 17;
            this.CongViecBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CongViecBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CongViecBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CongViecBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CongViecBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CongViecBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CongViecBox.ItemHeight = 30;
            this.CongViecBox.Items.AddRange(new object[] {
            "ThoDien",
            "Dien Lanh",
            "Ong Nuoc",
            "Tho Moc",
            "Xay Dung",
            "Thong Tac",
            "Ve Sinh",
            "Sua Nha"});
            this.CongViecBox.Location = new System.Drawing.Point(536, 56);
            this.CongViecBox.Name = "CongViecBox";
            this.CongViecBox.Size = new System.Drawing.Size(234, 36);
            this.CongViecBox.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(296, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Thời gian làm việc trong ngày";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(296, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Thời gian làm việc trong tuần";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(296, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "Kinh Nghiệm";
            // 
            // hour_start
            // 
            this.hour_start.AutoRoundedCorners = true;
            this.hour_start.BackColor = System.Drawing.Color.Transparent;
            this.hour_start.BorderRadius = 17;
            this.hour_start.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hour_start.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hour_start.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hour_start.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hour_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.hour_start.ItemHeight = 30;
            this.hour_start.Items.AddRange(new object[] {
            "7h",
            "8h",
            "9h",
            "10h",
            "11h",
            "12h",
            "13h",
            "14h",
            "15h",
            "16h",
            "17h",
            "18h",
            "19h",
            "20h"});
            this.hour_start.Location = new System.Drawing.Point(536, 344);
            this.hour_start.Name = "hour_start";
            this.hour_start.Size = new System.Drawing.Size(98, 36);
            this.hour_start.TabIndex = 27;
            // 
            // day_start
            // 
            this.day_start.AutoRoundedCorners = true;
            this.day_start.BackColor = System.Drawing.Color.Transparent;
            this.day_start.BorderRadius = 17;
            this.day_start.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.day_start.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day_start.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.day_start.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.day_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.day_start.ItemHeight = 30;
            this.day_start.Items.AddRange(new object[] {
            "Thứ hai",
            "Thứ ba",
            "Thứ tư",
            "Thứ năm",
            "Thứ sáu ",
            "Thứ bảy",
            "Chủ nhật"});
            this.day_start.Location = new System.Drawing.Point(536, 279);
            this.day_start.Name = "day_start";
            this.day_start.Size = new System.Drawing.Size(98, 36);
            this.day_start.TabIndex = 26;
            // 
            // KinhNghiemBox
            // 
            this.KinhNghiemBox.AutoRoundedCorners = true;
            this.KinhNghiemBox.BackColor = System.Drawing.Color.Transparent;
            this.KinhNghiemBox.BorderRadius = 17;
            this.KinhNghiemBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.KinhNghiemBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KinhNghiemBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KinhNghiemBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KinhNghiemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KinhNghiemBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.KinhNghiemBox.ItemHeight = 30;
            this.KinhNghiemBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
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
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.KinhNghiemBox.Location = new System.Drawing.Point(536, 135);
            this.KinhNghiemBox.Name = "KinhNghiemBox";
            this.KinhNghiemBox.Size = new System.Drawing.Size(98, 36);
            this.KinhNghiemBox.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(296, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "Công Việc";
            // 
            // hour_end
            // 
            this.hour_end.AutoRoundedCorners = true;
            this.hour_end.BackColor = System.Drawing.Color.Transparent;
            this.hour_end.BorderRadius = 17;
            this.hour_end.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hour_end.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hour_end.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hour_end.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hour_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_end.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.hour_end.ItemHeight = 30;
            this.hour_end.Items.AddRange(new object[] {
            "7h",
            "8h",
            "9h",
            "10h",
            "11h",
            "12h",
            "13h",
            "14h",
            "15h",
            "16h",
            "17h",
            "18h",
            "19h",
            "20h"});
            this.hour_end.Location = new System.Drawing.Point(684, 344);
            this.hour_end.Name = "hour_end";
            this.hour_end.Size = new System.Drawing.Size(86, 36);
            this.hour_end.TabIndex = 23;
            // 
            // day_end
            // 
            this.day_end.AutoRoundedCorners = true;
            this.day_end.BackColor = System.Drawing.Color.Transparent;
            this.day_end.BorderRadius = 17;
            this.day_end.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.day_end.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.day_end.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.day_end.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.day_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_end.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.day_end.ItemHeight = 30;
            this.day_end.Items.AddRange(new object[] {
            "Thứ hai",
            "Thứ ba",
            "Thứ tư",
            "Thứ năm",
            "Thứ sáu ",
            "Thứ bảy",
            "Chủ nhật"});
            this.day_end.Location = new System.Drawing.Point(684, 279);
            this.day_end.Name = "day_end";
            this.day_end.Size = new System.Drawing.Size(86, 36);
            this.day_end.TabIndex = 29;
            // 
            // kn_num
            // 
            this.kn_num.AutoRoundedCorners = true;
            this.kn_num.BackColor = System.Drawing.Color.Transparent;
            this.kn_num.BorderRadius = 17;
            this.kn_num.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.kn_num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kn_num.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kn_num.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kn_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kn_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.kn_num.ItemHeight = 30;
            this.kn_num.Items.AddRange(new object[] {
            "Tháng",
            "Năm"});
            this.kn_num.Location = new System.Drawing.Point(640, 135);
            this.kn_num.Name = "kn_num";
            this.kn_num.Size = new System.Drawing.Size(130, 36);
            this.kn_num.TabIndex = 22;
            // 
            // Work2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1091, 689);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelWork);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Work2Form";
            this.Text = "Work2Form";
            this.Load += new System.EventHandler(this.Work2Form_Load);
            this.panelWork.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelWork;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelAdd;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2TextBox chitiet_txb;
        private Guna.UI2.WinForms.Guna2Button btn_Save;
        private Guna.UI2.WinForms.Guna2TextBox tienCongBox;
        private Guna.UI2.WinForms.Guna2ComboBox tc_num;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox CongViecBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ComboBox hour_start;
        private Guna.UI2.WinForms.Guna2ComboBox day_start;
        private Guna.UI2.WinForms.Guna2ComboBox KinhNghiemBox;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2ComboBox hour_end;
        private Guna.UI2.WinForms.Guna2ComboBox day_end;
        private Guna.UI2.WinForms.Guna2ComboBox kn_num;
        private System.Windows.Forms.FlowLayoutPanel flContainer;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}