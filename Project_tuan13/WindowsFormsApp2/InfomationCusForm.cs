using Microsoft.VisualBasic.ApplicationServices;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using static ServiceStack.Script.Lisp;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace WindowsFormsApp2
{
    public partial class InfomationCusForm : Form
    {
        CheckCondition check=new CheckCondition();  
        public InfomationCusForm()
        {
            InitializeComponent();
            check.AttachValidatingEventToTextBoxes(this);
        }
        public static string role;
        public static string ID;
        private string gioitinh;
        
        private void InfomationCusForm_Load(object sender, EventArgs e)
        {
            if (role=="User")
            {
                User user = UserDAO.Load_info_User(ID);
                txtName.Text = user.Hoten;
                txtAddress.Text = user.Diachi;
                dateBirthDay.Value = user.Ngaysinh.Date;
                txtPhone.Text = user.Sdt;
                txtEmail.Text = user.Email;
                txtCMND.Text = user.Cccd;
                GioiTinh(user.Gioitinh);
                if (user.Avatar != null && user.Avatar.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(user.Avatar, 0, user.Avatar.Length);
                    ptbAvatar.Image = Image.FromStream(ms);
                }
            }
            else
            {
                Worker worker = WorkerDAO.Load_info_Worker(ID);
                txtName.Text = worker.Hoten;
                txtAddress.Text = worker.Diachi;
                dateBirthDay.Value = worker.Ngaysinh;
                txtPhone.Text = worker.Sdt;
                txtEmail.Text = worker.Email;
                txtCMND.Text = worker.Cccd;
                GioiTinh(worker.Gioitinh);
                if (worker.Avatar != null && worker.Avatar.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(worker.Avatar, 0, worker.Avatar.Length);
                    ptbAvatar.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (role == "User")
            {
                User user = new User(ID, txtName.Text, txtAddress.Text, dateBirthDay.Value, txtPhone.Text, txtEmail.Text, gioitinh, txtCMND.Text);
                UserDAO.Edit_Info(user);
            }
            else
            {
                Worker worker = new Worker(ID, txtName.Text, txtAddress.Text, dateBirthDay.Value, txtPhone.Text, txtEmail.Text, gioitinh, txtCMND.Text);
                WorkerDAO.Edit_Info(worker);
            }
        }

      

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_saveAnh_Click(object sender, EventArgs e)
        {
            byte[] imageData = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select an Image File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tệp được chọn
                string selectedImagePath = openFileDialog1.FileName;

                // Hiển thị hình ảnh được chọn
                ptbAvatar.ImageLocation = selectedImagePath;

                // Đọc dữ liệu hình ảnh từ tệp
                
                using (FileStream fs = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, (int)fs.Length);
                }

            }
            if (role == "User")
            {
                UserDAO.Save_Anh(ID, imageData);
            }
            else
            {
                WorkerDAO.Save_Anh(ID, imageData);
            }
        }
        private void GioiTinh(string s)
        {
            if (s == "Nam       ")
            {
                btnNam.Checked = true;
            }

            else
                btnNu.Checked = true;
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            gioitinh = btnNam.Text;
        }

        private void btnNu_Click(object sender, EventArgs e)
        {
            gioitinh = btnNu.Text;
        }
    }
}
