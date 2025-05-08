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
    public partial class adminDropCourse : Form
    {
        public struct courseInfo
        {
            public string name;
            public string section;
            public string id;
        }
        private courseInfo[] cinfo;
        public DataTable dt;
        private adminFirst aFirst;
        private adminDropCourse aCourse;
        public int firstValue, noOfRows;
        private Label[] nlbl, clbl;
        private RadioButton[] rbtn;

        public adminDropCourse(DataTable dt, adminDropCourse aCourse, adminFirst aFirst, int init)
        {
            InitializeComponent();

            this.dt = dt;
            this.aFirst = aFirst;
            this.aCourse = aCourse;
            this.firstValue = init;
            noOfRows = dt.Rows.Count;

            int showDataNumber = 8;
            nlbl = new Label[showDataNumber];
            clbl = new Label[showDataNumber];
            rbtn = new RadioButton[showDataNumber];
            cinfo = new courseInfo[showDataNumber];

            storeComponents();
            showData(dt, firstValue, noOfRows);
        }

        private void prevPage(object sender, EventArgs e)
        {
            this.Hide();
            if (aCourse == null) aFirst.Show();
            else aCourse.Show();
            this.Close();
        }

        private void minimizeWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void appExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nxtPage(object sender, EventArgs e)
        {
            if ((2 * firstValue + 8) < dt.Rows.Count)
            {
                this.Hide();
                new adminDropCourse(dt, this, null, firstValue + 8).ShowDialog();
                return;
            }
            MessageBox.Show("No other courses are remaining to be shown");
        }

        private void showCourseInfo(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                if (rbtn[i].Checked)
                {
                    database db = new database();
                    string query = "select * from timing where cname = '" + cinfo[i].name + "' and sec = '" + cinfo[i].section + "'";
                    new adminShowCourseInfo(db.Table(query)).ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Please enter your choice first");
        }

        private void dropCourse(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                if (rbtn[i].Checked)
                {
                    database db = new database();
                    string query = "delete from timing where cname = '" + cinfo[i].name + "' and sec = '" + cinfo[i].section + "'";
                    db.update(query);
                    if (db.Table("select * from timing where cname = '"+cinfo[i].name+"'").Rows.Count == 0)
                    {
                        query = "update timing set cid = cid - 1 where cid > " + cinfo[i].id;
                        db.update(query);
                        query = "delete from courses where name = '" + cinfo[i].name + "'";
                        db.update(query);
                        query = "update courses set id = id - 1 where id > " + cinfo[i].id;
                        db.update(query);
                    }
                    query = "select * from timing";
                    dt = db.Table(query);
                    noOfRows = dt.Rows.Count;
                    this.showData(dt, firstValue, noOfRows);
                    prevRowsUpdate();
                    return;
                }
            }
            MessageBox.Show("No course is selected");
        }
        public void prevRowsUpdate()
        {
            if (aCourse != null)
            {
                aCourse.dt = this.dt;
                aCourse.noOfRows = this.noOfRows;
                aCourse.prevRowsUpdate();
            }
        }

        private void searchCourse(object sender, EventArgs e)
        {
            if (searchLabel.Text == "")
            {
                this.showData(dt, firstValue, noOfRows);
            }
            else
            {
                string query = "select * from timing where cname like '" + searchLabel.Text + "%'";
                database db = new database();
                DataTable dt = db.Table(query);
                if (dt.Rows.Count > 0)
                this.showData(dt, 0, dt.Rows.Count);
            }
        }

        private void showData(DataTable dt, int firstValue, int noOfRows)
        {
            string t = "ABC",tCheck = "ABC", tSec = "ABC";
            for (int idx = 0; idx < 8; idx++)
                nlbl[idx].Text = clbl[idx].Text = "";
            for (int idx = 0; idx < 8; idx++)
                nlbl[idx].Text = (firstValue + idx + 1).ToString() + ".";
            int i = firstValue, counter = 0;
            while (counter < 8 && (firstValue + i) < noOfRows)
            {
                if (tCheck == dt.Rows[firstValue + i]["cname"].ToString() && tSec == dt.Rows[firstValue + i]["sec"].ToString())
                {
                    i++;
                    continue;
                }
                t = dt.Rows[firstValue + i]["cname"].ToString();
                tSec = dt.Rows[firstValue + i]["sec"].ToString();
                tCheck = t;
                cinfo[counter].name = t;
                cinfo[counter].section = tSec;
                cinfo[counter].id = dt.Rows[firstValue + i]["cid"].ToString();
                if (t.Length > 30)
                {
                    t = t.Remove(30, t.Length - 30);
                    t += "...";
                }
                t += "["+dt.Rows[firstValue + i]["sec"].ToString()+"]";
                clbl[counter].Text = t;
                counter++;
                i++;
            }
            for (int idx = 0; idx < 8; idx++)
                if (clbl[idx].Text == "")
                {
                    rbtn[idx].Visible = false;
                    nlbl[idx].Text = "";
                }
                else rbtn[idx].Visible = true;
        }
        private void storeComponents()
        {
            clbl[0] = clbl1;
            clbl[1] = clbl2;
            clbl[2] = clbl3;
            clbl[3] = clbl4;
            clbl[4] = clbl5;
            clbl[5] = clbl6;
            clbl[6] = clbl7;
            clbl[7] = clbl8;

            nlbl[0] = nlbl1;
            nlbl[1] = nlbl2;
            nlbl[2] = nlbl3;
            nlbl[3] = nlbl4;
            nlbl[4] = nlbl5;
            nlbl[5] = nlbl6;
            nlbl[6] = nlbl7;
            nlbl[7] = nlbl8;

            rbtn[0] = rbtn1;
            rbtn[1] = rbtn2;
            rbtn[2] = rbtn3;
            rbtn[3] = rbtn4;
            rbtn[4] = rbtn5;
            rbtn[5] = rbtn6;
            rbtn[6] = rbtn7;
            rbtn[7] = rbtn8;
        }
    }
}
