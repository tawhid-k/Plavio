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
    public partial class adminShowCourseInfo : Form
    {
        public adminShowCourseInfo(DataTable dt)
        {
            InitializeComponent();
            string t;
            namelbl.Text = "Course Name: " + dt.Rows[0]["cname"].ToString();
            idlbl.Text = "Course ID: " + dt.Rows[0]["cid"].ToString();
            seclbl.Text = "Section: " + dt.Rows[0]["sec"].ToString();
            day1lbl.Text = dt.Rows[0]["day"].ToString();
            day1lbl.Text += ": ";
            t = dt.Rows[0]["start"].ToString();
            t = t.Remove(t.Length - 3, 3);
            day1lbl.Text += t;
            day1lbl.Text += " - ";
            t = dt.Rows[0]["endt"].ToString();
            t = t.Remove(t.Length - 3, 3);
            day1lbl.Text += t;
            if (dt.Rows.Count == 2)
            {
                day2lbl.Text = dt.Rows[1]["day"].ToString();
                day2lbl.Text += ": ";
                t = dt.Rows[1]["start"].ToString();
                t = t.Remove(t.Length - 3, 3);
                day2lbl.Text += t;
                day2lbl.Text += " - ";
                t = dt.Rows[1]["endt"].ToString();
                t = t.Remove(t.Length - 3, 3);
                day2lbl.Text += t;
            }
            else day2lbl.Text = "";
            /**/
        }
        private void Okay(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
