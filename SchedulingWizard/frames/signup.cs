using System;
using SchedulingWizard.frames;
using SchedulingWizard.DBConnection;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SchedulingWizard.frames
{
    public partial class signup : Form
    {
        private options opt;
        private login lg;
        public signup()
        {
            InitializeComponent();
        }
        public signup (options o)
        {
            InitializeComponent();
            this.opt = o;
            lg = null;
        }
        public signup(login l)
        {
            InitializeComponent();
            this.lg = l;
            opt = null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool Valid ()
        {
            if (pass.Text != null && pass.Text == cpass.Text)
                return true;
            return false;
        }
        private void confirmReg (object sender, EventArgs e)
        {
            if (name.Text == "" || id.Text == "" || email.Text == "" || pass.Text == "" || cpass.Text == "")
            {
                MessageBox.Show("Please fill up all the requirements first");
                return;
            }
            if (Valid())
            {
                string query = "insert into userinfo values ('" + name.Text + "','" + id.Text + "','" + email.Text + "','" + pass.Text + "')";
                database db = new database();
                if (db.Table("select * from userinfo where name = '" + name.Text + "'").Rows.Count > 0)
                {
                    MessageBox.Show("User with that name already exists");
                    return;
                }
                db.update(query);
                MessageBox.Show("Registration Successful");
                this.Hide();
                opt.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Passwords didn't match!");
            }
            return;
        }

        private void closeWindow(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void prevPage(object sender, EventArgs e)
        {
            this.Hide();
            if (opt == null)
                lg.Show();
            else opt.Show();
            this.Close();
        }

        private void passChange(object sender, EventArgs e)
        {
            pass.isPassword = true;
        }

        private void cpassChange(object sender, EventArgs e)
        {
            cpass.isPassword = true;
        }
    }
}
