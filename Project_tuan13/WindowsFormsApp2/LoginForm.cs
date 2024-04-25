using Guna.UI2.WinForms;
using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using ServiceStack;
using static ServiceStack.Script.Lisp;
using Microsoft.VisualBasic.ApplicationServices;

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {
        CheckCondition check = new CheckCondition();
        public bool btnClicked;
        public LoginForm()
        {          
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundForm.CreateRoundRectRgn(0,0,Width,Height,30,30));
            pnlSinUp.Hide();
            check.AttachValidatingEventToTextBoxes(this);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            pnlSinUp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnClicked)
            {
                if (UserDAO.check_Login(txbLogin.Text, txtPasslogin.Text))
                {
                    string userID = "User_" + txbLogin.Text;
                    this.Hide();
                    UserForm f = new UserForm();
                    f.userID_lbl.Text = userID;
                    f.ShowDialog();
                    f = null;
                    this.Show();
                }
            }
            else
            {
                if (WorkerDAO.check_Login(txbLogin.Text, txtPasslogin.Text))
                {
                    string workerID = "Worker_" + txbLogin.Text;
                    this.Hide();
                    WorkerForm f = new WorkerForm();
                    f.WorkerID_lbl.Text = workerID;
                    f.ShowDialog();
                    f = null;
                    this.Show();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlSinUp.Hide();
        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {
            //pnlSinUp.Hide();
            if (btnClicked)
            {
                string userID = "User_" + txtPhone.Text;
                User user =new User(userID, txtName.Text,txtPhone.Text, txtEmail.Text);              
                UserDAO.New_User(user, txtPassWord.Text);
                pnlSinUp.Hide();
            }
            else
            {
                string workerID = "Worker_" + txtPhone.Text;
                Worker worker = new Worker(workerID, txtName.Text, txtPhone.Text, txtEmail.Text);
                WorkerDAO.New_Worker( worker,txtPassWord.Text);
                pnlSinUp.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            btnClicked = true;
        }

        private void workerBtn_Click(object sender, EventArgs e)
        {
            btnClicked = false;
        }

        private void btn_userlogin_Click(object sender, EventArgs e)
        {
            btnClicked = true;
        }

        private void btn_workerlogin_Click(object sender, EventArgs e)
        {
            btnClicked = false;
        }
    }
}
