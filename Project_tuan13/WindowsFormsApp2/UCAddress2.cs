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
    public partial class UCAddress2 : UserControl
    {
        public UCAddress2()
        {
            InitializeComponent();
        }
        public UCAddress2(string name, string address, string phone)
        {
            InitializeComponent();
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
           
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCAddress2_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblAddress.Text = address;
            lblPhone.Text = phone;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            EditAddressForm f = new EditAddressForm();
            f.ShowDialog();
        }
    }
}
