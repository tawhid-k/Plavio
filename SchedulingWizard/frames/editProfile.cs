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
    public partial class editProfile : Form
    {
        private database db;
        private DataTable dt;
        private string username;

        public editProfile(string username)
        {
            InitializeComponent();
            this.username = username;
            db = new database();
            dt = new DataTable();

            string query = "select * from userinfo where name = '" + username + "'";
            dt = db.Table(query);

            name.Text = dt.Rows[0]["name"].ToString();
            id.Text = dt.Rows[0]["id"].ToString();
            email.Text = dt.Rows[0]["email"].ToString();
            oldPass.Text = "";
            newPass.Text = dt.Rows[0]["pass"].ToString();
            cNewPass.Text = dt.Rows[0]["pass"].ToString();
        }

        private void closePage(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkOldPass(object sender, EventArgs e)
        {
            if (oldPass.Text == dt.Rows[0]["pass"].ToString())
            {
                newPass.ReadOnly = false;
                cNewPass.ReadOnly = false;
            }
            else
            {
                newPass.ReadOnly = true;
                cNewPass.ReadOnly = true;
            }
        }

        private void applyChange(object sender, EventArgs e)
        {
            if (newPass.Text == cNewPass.Text)
            {
                string query = "update userinfo set name = '" + name.Text + "', id = '" + id.Text + "', email = '" + email.Text + "', pass = '" + newPass.Text + "' where name = '" + username + "'";
                db.update(query);
                this.Close();
                MessageBox.Show("Profile updated");
            }
            else MessageBox.Show("Password's didn't match");
        }
    }
}
