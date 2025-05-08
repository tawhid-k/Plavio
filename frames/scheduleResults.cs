using SchedulingWizard.DBConnection;
using SchedulingWizard.scheduling_Datatypes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SchedulingWizard.frames
{
    public partial class scheduleResults : Form
    {
        private scheduleResults prev;
        private showCourseList showList;
        private string username;
        private Label[] clbl, tlbl;
        private int noOfCourse, pageValue;

        public scheduleResults(int firstValue, scheduleResults pp, showCourseList lst, string uname)
        {
            InitializeComponent();
            routineLabel.Text += " " + firstValue.ToString();
            pageShow.Text = "Page: " + firstValue.ToString() + "\n" + "Total produced: "+prepareSchedule.combinationalSchedules.Count.ToString();
            this.username = uname;
            pageValue = firstValue;
            prev = pp;
            showList = lst;
            const int len = 793;
            int[] arrSize = new int[] {87, 53, 142, 260, 372, 490, 610 };
            int introPnl = arrSize[0];
            noOfCourse = prepareSchedule.combinationalSchedules[0].courses.Count;
            int showPnl = arrSize[noOfCourse + 1];
            int fnlPnl = arrSize[1];
            this.Size = new Size(len, introPnl + showPnl + fnlPnl);
            introductoryPnl.Size = new Size(len, introPnl);
            resultShowPnl.Size = new Size(len, showPnl);
            finalPnl.Size = new Size(len, fnlPnl);
            this.storeComponents();
            showResults();

            if (pageValue == prepareSchedule.combinationalSchedules.Count) nxtBtn.Visible = false;
        }
        private void storeComponents()
        {
            clbl = new Label[5];
            clbl[0] = clbl1;
            clbl[1] = clbl2;
            clbl[2] = clbl3;
            clbl[3] = clbl4;
            clbl[4] = clbl5;

            tlbl = new Label[10];
            tlbl[0] = tlbl1;
            tlbl[1] = tlbl2;
            tlbl[2] = tlbl3;
            tlbl[3] = tlbl4;
            tlbl[4] = tlbl5;
            tlbl[5] = tlbl6;
            tlbl[6] = tlbl7;
            tlbl[7] = tlbl8;
            tlbl[8] = tlbl9;
            tlbl[9] = tlbl10;
        }
        private void showResults()
        {
            string day, time, slt;
            course temp;
            int lblCount = 0;
            int subStringPart = 0;
            DateTime dt = DateTime.Now;
            while (dt.ToString()[subStringPart] != ' ')
                subStringPart++;
            subStringPart++;
            for (int i = 0; i < noOfCourse; i++)
            {
                temp = prepareSchedule.combinationalSchedules[pageValue - 1].courses[i];
                string t = temp.name;
                if (t.Length > 35)
                {
                    t = t.Remove(35, t.Length - 35);
                    t += "...";
                }
                clbl[i].Text = t;
                clbl[i].Text += " [" + temp.section + "]";
                for (int j = 0; j < temp.slots.Count; j++)
                {
                    tlbl[lblCount].Text = temp.slots[j].day + ": ";
                    //subStringPart is changed according to the date
                    //The more letters in the date the more value for subStringPart
                    slt = temp.slots[j].start.ToString().Substring(subStringPart, 5);
                    if (slt.EndsWith(":")) tlbl[lblCount].Text += slt.Substring(0, 4);
                    else tlbl[lblCount].Text += slt.Substring(0, 5);
                    tlbl[lblCount].Text += " - ";
                    slt = temp.slots[j].end.ToString().Substring(subStringPart, 5);
                    if (slt.EndsWith(":")) tlbl[lblCount].Text += slt.Substring(0, 4);
                    else tlbl[lblCount].Text += slt.Substring(0, 5);
                    lblCount++;
                }
            }
        }
        private void prevPage(object sender, EventArgs e)
        {
            this.Hide();
            if (prev == null)
                showList.Show();
            else prev.Show();
        }

        private void minimizePage(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void nxtPage(object sender, EventArgs e)
        {
            this.Hide();
            new scheduleResults(pageValue + 1, this, null, username).ShowDialog();
        }
        private void close(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
