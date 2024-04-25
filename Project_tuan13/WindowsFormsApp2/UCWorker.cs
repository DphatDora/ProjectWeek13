using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UCWorker : UserControl
    {
        private string workerID;
        private string cv;
        public Label LblName
        {
            get => lblName; set => lblName = value;
        }
        public Label LblPhone
        {
            get => lblPhone; set => lblPhone = value;
        }
        public Label LblKinhnghiem
        {
            get => lbl_kinhnghiem; set => lbl_kinhnghiem = value;
        }
        public Label LblTiencong
        {
            get => lbl_tiencong; set => lbl_tiencong = value;
        }
        public Guna2RatingStar Rating
        {
            get => rating; set => rating = value;
        }
        public string WorkerID { get => workerID; set => workerID = value; }
        public Guna2PictureBox Ptb_avt { get => ptb_avt; set => ptb_avt = value; }
        public string Cv { get => cv; set => cv = value; }

        public UCWorker()
        {
            InitializeComponent();
        }

        public UCWorker(string workerID)
        {
            WorkerID = workerID;
            InitializeComponent();
        }
        private void UCWorker_Click(object sender, EventArgs e)
        {
            InfoWorkerForm f = new InfoWorkerForm();
            f.WorkerID = workerID;
            f.Cv = cv;
            f.Show();
        }

        private void UCWorker_Load(object sender, EventArgs e)
        {

        }
    }
}
