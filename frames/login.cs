using System;
using SchedulingWizard.DBConnection;
using System.Windows.Forms;
using SchedulingWizard.scheduling_Datatypes;
using System.Windows.Forms.VisualStyles;

namespace SchedulingWizard.frames
{
    public partial class login : Form
    {
        options opt;
        public login(options o)
        {
            InitializeComponent();
            opt = o;
        }

        private void tryLogin(object sender, EventArgs e)
        {
            string query = "select * from userinfo where name = '" + uname.Text + "' and pass = '" + pass.Text + "'";
            database db = new database();
            if (db.checkSpecificRow(query) == true)
            {
                this.Hide();
                if (uname.Text == "Admin")
                    new adminFirst(this).ShowDialog();
                else new showOption(this, uname.Text).ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }
        private void createAccount(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void register(object sender, EventArgs e)
        {
            if (uname2.Text == "" || id2.Text == "" || email.Text == "" || pass2.Text == "" || cpass2.Text == "")
            {
                MessageBox.Show("Please fill al the requirements properly");
                return;
            }
            if (pass2.Text != cpass2.Text)
            {
                MessageBox.Show("Passwords didn't match");
                return;
            }
            database db = new database();
            if (db.Table("select * from userinfo where name = '" + uname2.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("User with that name already exists");
                return;
            }
            string query = "insert into userinfo values ('" + uname2.Text + "','" + id2.Text + "','" + email.Text + "','" + pass2.Text + "')";
            db.update(query);
            MessageBox.Show("Successful registration");
            timer2.Start();
        }

        private void prevPage(object sender, EventArgs e)
        {
            this.Hide();
            opt.Show();
            this.Close();
        }

        private void minimizePage(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void startSliding(object sender, EventArgs e)
        {
            if (registerpnl.Location.X.CompareTo(375) > 0)
                registerpnl.Location = new System.Drawing.Point(registerpnl.Location.X - 17, registerpnl.Location.Y);
            else timer1.Stop();
        }

        private void showLoginOptionAgain(object sender, EventArgs e)
        {
            if (registerpnl.Location.X.CompareTo(785) < 0)
                registerpnl.Location = new System.Drawing.Point(registerpnl.Location.X + 17, registerpnl.Location.Y);
            else timer2.Stop();
        }
        private void rPchange(object sender, EventArgs e)
        {
            pass2.isPassword = true;
        }
        private void crp2Cgange(object sender, EventArgs e)
        {
            cpass2.isPassword = true;
        }

        private void cencelRegistration(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void setPass(object sender, EventArgs e)
        {
            pass.isPassword = true;
        }
    }
}
