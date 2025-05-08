using SchedulingWizard.DBConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingWizard.frames
{
    public partial class adminFirst : Form
    {
        private login Login;

        public adminFirst(login Login)
        {
            InitializeComponent();

            this.Login = Login;
        }

        private void logOut(object sender, EventArgs e)
        {
            this.Hide();
            Login.Show();
            this.Close();
        }

        private void exitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizePage(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dropUserForm(object sender, EventArgs e)
        {
            database db = new database();
            string query = "select * from userinfo";
            DataTable dt = db.Table(query);
            this.Hide();
            new adminDropUser(dt, null, this, 1).ShowDialog();
        }

        private void dropCourse(object sender, EventArgs e)
        {
            database db = new database();
            string query = "select * from timing order by cid";
            DataTable dt = db.Table(query);
            this.Hide();
            new adminDropCourse(dt, null, this, 0).ShowDialog();
        }

        private void addCourse(object sender, EventArgs e)
        {
            new adminAddCourse().ShowDialog();
        }

        private void addUser(object sender, EventArgs e)
        {
            new adminAddUser().ShowDialog();
        }
    }
}
