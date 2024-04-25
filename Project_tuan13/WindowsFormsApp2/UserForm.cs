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
    public partial class UserForm : Form
    {
        public static string UserID;
        public UserForm()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenForm(Form form)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PanelContain.Controls.Add(form);
            PanelContain.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfomationCusForm.role = "User";
            InfomationCusForm.ID = userID_lbl.Text;
            OpenForm(new InfomationCusForm());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryWorkerForm.userID = userID_lbl.Text;
            OpenForm(new HistoryWorkerForm("Customer"));
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            OpenForm(new ServiceForm());
        }

        private void btnSinUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenForm(new OrderWorkerForm());
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UserID = userID_lbl.Text;
            guna2Button1.Visible = false;
        }
    }
}
