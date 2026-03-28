using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOLINES_EDP
{
    public partial class frmHome : Form
    {
        public string username;

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Hi, " + username;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            RegisterForm rf = new RegisterForm();
            rf.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStoreStatus_Click(object sender, EventArgs e)
        {
            StoreStatusForm rf = new StoreStatusForm();
            rf.ShowDialog();
        }

        private void btnPricebook_Click(object sender, EventArgs e)
        {
            PricebookForm rf = new PricebookForm();
            rf.ShowDialog();
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            VendorsForm rf = new VendorsForm();
            rf.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm rf = new UsersForm();
            rf.ShowDialog();
        }

        private void btnTimeClock_Click(object sender, EventArgs e)
        {
            TimeClockForm rf = new TimeClockForm();
            rf.ShowDialog();
        }

        private void pcboxArrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
