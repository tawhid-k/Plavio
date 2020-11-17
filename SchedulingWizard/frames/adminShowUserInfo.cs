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
    public partial class adminShowUserInfo : Form
    {
        public adminShowUserInfo(int row, DataTable dt)
        {
            InitializeComponent();
            name.Text = "Name: " + dt.Rows[row]["name"].ToString();
            id.Text = "ID: " + dt.Rows[row]["id"].ToString();
            email.Text = "Email: " + dt.Rows[row]["email"].ToString();
        }

        private void okay(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
