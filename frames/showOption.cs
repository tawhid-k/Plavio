using SchedulingWizard.DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SchedulingWizard.frames
{
    public partial class showOption : Form
    {
        private login lg;
        private string username;
        public showOption()
        {
            InitializeComponent();
        }
        public showOption(login l, string uname)
        {
            InitializeComponent();
            lg = l;
            username = uname;
            ulbl.Text = ulbl.Text + username;
        }
        private void exitBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeBtn(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void prevPage(object sender, EventArgs e)
        {
            this.Hide();
            lg.Show();
        }
        private void showOfferedCourses(object sender, EventArgs e)
        {
            this.Hide();
            new database().update("delete from selection");
            new showCourseList(username, 0, this, null).ShowDialog();
        }

        private void showUserInfo(object sender, EventArgs e)
        {
            database db = new database();
            string query = "select * from userinfo where name = '" + username + "'";
            DataTable dt = db.Table(query);
            new adminShowUserInfo(0, dt).ShowDialog();
        }

        private void editProfile(object sender, EventArgs e)
        {
            new editProfile(username).ShowDialog();
        }
    }
}
