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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
            dgvUsers.CellFormatting += dgvUsers_CellFormatting;
            dgvUsers.CellClick += dgvUsers_CellClick;
            dgvUsers.MouseDown += dgvUsers_MouseDown;
        }

        MyDatabase db = new MyDatabase();
        int selectedUserID = -1;
        int selectedLoginID = -1;

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                ClearFields();
            }
        }

        private void ClearFields()
        {
            tbFname.Clear();
            tbMname.Clear();
            tbLname.Clear();
            tbEmailAdd.Clear();
            tbHomeAdd.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            dtpBirthDate.Value = DateTime.Now;

            selectedUserID = -1;
            selectedLoginID = -1;
        }
        private void dgvUsers_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dgvUsers.HitTest(e.X, e.Y);

            
            if (hit.RowIndex == -1)
            {
                dgvUsers.ClearSelection();
                ClearFields();
            }
        }
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                selectedUserID = Convert.ToInt32(row.Cells["userID"].Value);
                selectedLoginID = Convert.ToInt32(row.Cells["LoginID"].Value);

                tbFname.Text = row.Cells["firstname"].Value.ToString();
                tbMname.Text = row.Cells["middlename"].Value.ToString();
                tbLname.Text = row.Cells["lastname"].Value.ToString();
                tbEmailAdd.Text = row.Cells["emailAddress"].Value.ToString();
                tbHomeAdd.Text = row.Cells["homeAddress"].Value.ToString();
                dtpBirthDate.Value = Convert.ToDateTime(row.Cells["birthDate"].Value);
                tbUsername.Text = row.Cells["Username"].Value.ToString();
                tbPassword.Text = row.Cells["Password"].Value.ToString();
            }
        }


        private void frmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            string query = "SELECT tbluserinformation.userID, tbllogincredentials.LoginID, tbluserinformation.firstname, tbluserinformation.middlename, tbluserinformation.lastname, tbluserinformation.emailAddress, tbluserinformation.homeAddress, tbluserinformation.birthDate, tbllogincredentials.user_username as 'Username', tbllogincredentials.user_password as 'Password' FROM tbllogincredentials INNER JOIN tbluserinformation ON tbllogincredentials.userID = tbluserinformation.userID;";

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsers.DataSource = db.ExecuteReturnQuery(query);
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[1].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tbluserinformation (Firstname, Middlename, Lastname, EmailAddress, HomeAddress, BirthDate) VALUES (@fname, @mname, @lname, @email, @hadd, @bDate);SET @newUserID = LAST_INSERT_ID();INSERT INTO tbllogincredentials (userID, user_username, user_password) VALUES (@newUserID, @username, @password);";

            int affectedRowCount = db.ExecuteNoReturnQuery(query,
                new MySqlParameter("@fname", tbFname.Text),
                new MySqlParameter("@mname", tbMname.Text),
                new MySqlParameter("@lname", tbLname.Text),
                new MySqlParameter("@email", tbEmailAdd.Text),
                new MySqlParameter("@hadd", tbHomeAdd.Text),
                new MySqlParameter("@bDate", dtpBirthDate.Value),
                new MySqlParameter("@username", tbUsername.Text),
                new MySqlParameter("@password", tbPassword.Text)
                );

            if (affectedRowCount > 0)
            {
                MessageBox.Show("Data Inserted!");
                frmUsers_Load(null, null);
                ClearFields();
            }
        }

        private void frmUsers_FormClosing_1(object sender, FormClosingEventArgs e)
        {
           
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Name == "Password" && e.Value != null)
            {
                e.Value = new string('●', e.Value.ToString().Length);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserID == -1)
            {
                MessageBox.Show("Please select a user first");
                return;
            }

            string query = @"UPDATE tbluserinformation 
                     SET firstname=@fname, middlename=@mname, lastname=@lname, 
                         emailAddress=@email, homeAddress=@hadd, birthDate=@bDate
                     WHERE userID=@uid;

                     UPDATE tbllogincredentials 
                     SET user_username=@username, user_password=@password
                     WHERE LoginID=@lid;";

            int result = db.ExecuteNoReturnQuery(query,
                new MySqlParameter("@fname", tbFname.Text),
                new MySqlParameter("@mname", tbMname.Text),
                new MySqlParameter("@lname", tbLname.Text),
                new MySqlParameter("@email", tbEmailAdd.Text),
                new MySqlParameter("@hadd", tbHomeAdd.Text),
                new MySqlParameter("@bDate", dtpBirthDate.Value),
                new MySqlParameter("@username", tbUsername.Text),
                new MySqlParameter("@password", tbPassword.Text),
                new MySqlParameter("@uid", selectedUserID),
                new MySqlParameter("@lid", selectedLoginID)
            );

            if (result > 0)
            {
                MessageBox.Show("User Updated!");
                frmUsers_Load(null, null);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (selectedUserID == -1)
            {
                MessageBox.Show("Please select a user first");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to deactivate this user?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                string query = "UPDATE tbluserinformation SET is_active = 0 WHERE userID = @uid;";

                int result = db.ExecuteNoReturnQuery(query,
                    new MySqlParameter("@uid", selectedUserID)
                );

                if (result > 0)
                {
                    MessageBox.Show("User deactivated!");
                    frmUsers_Load(null, null);
                    ClearFields();
                }
            }
        }
    }
}
