using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddressForm : Form
    {
        UCAddress2 uc;
        public AddressForm()
        {
            InitializeComponent();
            panelAdd.Hide();
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelAdd.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelAdd.Show();
            
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            UCAddress2 uc1 = new UCAddress2("Nguyễn Mạnh Tú", "01 Võ Văn Ngân, Phường Linh Chiểu, Thành phố Thủ Đức, Thành phố Hồ Chí Minh", "0384983735");
            flContainter.Controls.Add(uc1);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
