using Guna.UI2.WinForms;
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
    public partial class UCWorkerYT : UserControl
    {
        public UCWorkerYT()
        {
            InitializeComponent();
        }
        private string workerID;
        public Label LblName
        {
            get => lblName; set => lblName = value;
        }
        public Label LblPhone
        {
            get => lblPhone; set => lblPhone = value;
        }
        public Guna2RatingStar Rating
        {
            get => rating; set => rating = value;
        }
        public string WorkerID { get => workerID; set => workerID = value; }
        public Guna2PictureBox PtbAvt
        {
            get => ptb_avt; set => ptb_avt = value;
        }
    }
}
