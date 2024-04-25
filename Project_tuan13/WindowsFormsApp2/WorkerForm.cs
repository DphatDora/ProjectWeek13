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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }
        public static string workerID;
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
        //btnWork
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Work2Form.workerID = WorkerID_lbl.Text;
            OpenForm(new Work2Form());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfomationCusForm.role = "Worker";
            InfomationCusForm.ID = WorkerID_lbl.Text;
            OpenForm(new InfomationCusForm());
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            OpenForm(new OrderWorkerForm());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryWorkerForm.workerID=WorkerID_lbl.Text;
            OpenForm(new HistoryWorkerForm("Worker"));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSinUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNotifica_Click(object sender, EventArgs e)
        {
            NotificationForm.workerID = WorkerID_lbl.Text;
            OpenForm(new NotificationForm());
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            workerID = WorkerID_lbl.Text;
            OpenForm(new NotificationForm());
        }
    }
}
