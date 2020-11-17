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
    public partial class adminAddCourse : Form
    {
        public adminAddCourse()
        {
            InitializeComponent();
        }

        private void close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applyEntry(object sender, EventArgs e)
        {
            if (cname.Text == null || sec.Text == null || day1day.SelectedItem == null || d1t1.Text == null || d1t2 == null)
            {
                MessageBox.Show("Please fill up all the requirements first");
                return;
            }
            if (noLab.Checked)
            {
                if (day2day.SelectedItem == null || d2t1.Text == null || d2t2.Text == null)
                {
                    MessageBox.Show("Please fill up all the requirements first");
                    return;
                }
            }
            string name, section, day, time1, time2;
            name = cname.Text; section = sec.Text; day = day1day.SelectedItem.ToString();
            time1 = d1t1.Text; time2 = d1t2.Text;
            if (checkTimes(time1) == false || checkTimes(time2) == false)
            {
                MessageBox.Show("Invalid Times");
                return;
            }
            if (noLab.Checked)
            {
                if (checkTimes(d2t1.Text) == false || checkTimes(d2t2.Text) == false)
                {
                    MessageBox.Show("Invalid Times");
                    return;
                }
            }
            int ID;
            database db = new database();
            DataTable dt = db.Table("select * from timing where cname = '" + cname.Text + "'");
            if (dt.Rows.Count > 0)
            {
                ID = Int32.Parse(dt.Rows[0]["cid"].ToString());
            }
            else
            {
                dt = db.Table("select * from courses where id = (select MAX(id) from courses)");
                ID = Int32.Parse(dt.Rows[0]["id"].ToString());
                ID++;
                db.update("insert into courses values (" + ID + ",'" + cname.Text + "')");
            }
            string query = "insert into timing values (" + ID + ",'" + name + "','" + section + "','" + day + "','" + time1 + "','" + time2 + "')";
            db.update(query);
            if (noLab.Checked)
            {
                time1 = d2t1.Text;
                time2 = d2t2.Text;
                query = "insert into timing values (" + ID + ",'" + name + "','" + section + "','" + day + "','" + time1 + "','" + time2 + "')";
                db.update(query);
            }
            MessageBox.Show("Successful");
            this.Close();
        }
        private bool checkTimes (string t1)
        {
            if (t1.Length == 0) return false;
            int num1=  -1, num2 = -1;
            int i = 0;
            string value = "";
            while (i < t1.Length && char.IsDigit(t1[i]))
            {
                value += t1[i];
                i++;
            }
            while (i < t1.Length && char.IsDigit(t1[i]) == false)
            {
                if (t1[i] == ':')
                    i++;
                else return false;
            }
            if (value.Length > 0) num1 = Int32.Parse(value);
            value = "";
            while (i < t1.Length)
            {
                if (char.IsDigit(t1[i]))
                {
                    value += t1[i];
                }
                else return false;
                i++;
            }
            if (value.Length > 0) num2 = Int32.Parse(value);
            if ((num1 >= 0 && num1 <= 12) && (num2 >= 0 && num2 <= 59))
                return true;
            else return false;
        }
        private void isLab(object sender, EventArgs e)
        {
            if (yesLab.Checked)
                day2panel.Visible = false;
            else if (noLab.Checked)
                day2panel.Visible = true;
        }
    }
}
