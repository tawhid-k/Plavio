using SchedulingWizard.DBConnection;
using System;
using System.Windows.Forms;

namespace SchedulingWizard.frames
{
    public partial class adminAddUser : Form
    {
        public adminAddUser()
        {
            InitializeComponent();
        }

        private void applyEntry(object sender, EventArgs e)
        {
            if (uname.Text == null || id.Text == null || email.Text == null || pass.Text == null || cpass.Text == null)
            {
                MessageBox.Show("Please fill al the requirements properly");
                return;
            }
            if (pass.Text != cpass.Text)
            {
                MessageBox.Show("Passwords didn't match");
                return;
            }
            database db = new database();
            if (db.Table("select * from userinfo where name = '" + uname.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("User with that name already exists");
                return;
            }
            string query = "insert into userinfo values ('" + uname.Text + "','" + id.Text + "','" + email.Text + "','" + pass.Text + "')";
            db.update(query);
            MessageBox.Show("Successful registration");
            this.Close();
        }

        private void closeWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passSetPass(object sender, EventArgs e)
        {
            pass.isPassword = true;
        }

        private void cpassSetPass(object sender, EventArgs e)
        {
            cpass.isPassword = true;
        }
    }
}
