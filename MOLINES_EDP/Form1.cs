using MySql.Data.MySqlClient;
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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }
        string[,] userCredentials =
        {
            { "admin", "admin", "Trisha Molines" },
            { "cashier", "password", "sheldon cooper" }
        };

        MyDatabase db = new MyDatabase();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text == "")
            {
                MessageBox.Show("Please enter username:", "Validation");
                tbUsername.Focus();
            }
            else if(tbPassword.Text == "")
            {
                MessageBox.Show("Please enter password:", "Validation");
                tbPassword.Focus();
            }
            else
            {
                //for (int x = 0; x < userCredentials.GetLength(0); x++)
                //{
                //    if (tbUsername.Text == userCredentials[x, 0])
                //    {
                //        if (tbPassword.Text == userCredentials[x, 1])
                //        {

                //            frmHome frm = new frmHome();
                //            frm.username = userCredentials[x, 2];
                //            MessageBox.Show("Welcome " + userCredentials[x, 2]);
                //            this.Hide();
                //            frm.Show();
                //            break;
                //        }
                //        else
                //        {
                //            MessageBox.Show("Invalid Username/Password");
                //            break;
                //        }
                //    }
                //}
           
                DataTable dt = db.ExecuteReturnQuery("Select * from tblLoginCredentials where user_username = @uname and user_password = @pword;",
                    new MySqlParameter("@uname",tbUsername.Text),
                    new MySqlParameter("@pword",tbPassword.Text));
                if (dt.Rows.Count == 1)
                {
                    frmHome frm = new frmHome();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            if (db.TestConnection() == true)
            {
                MessageBox.Show("Connected Successfully");
            }
            else
            {
                MessageBox.Show("ngiii");
            }
        }
    }
}
