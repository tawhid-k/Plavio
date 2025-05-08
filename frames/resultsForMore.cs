using SchedulingWizard.scheduling_Datatypes;
using System;
using System.Windows.Forms;

namespace SchedulingWizard.frames
{
    public partial class resultsForMore : Form
    {
        private int pageValue, noOfCourses;
        private resultsForMore prev;
        private showCourseList sList;
        private string username;
        private Label[] clbl;
        private Label[] tlbl;

        public resultsForMore(int firstValue, resultsForMore rm, showCourseList lst, string uname)
        {
            InitializeComponent();

            pageValue = firstValue;
            prev = rm;
            sList = lst;
            username = uname;
            noOfCourses = prepareSchedule.combinationalSchedules[0].courses.Count;

            if (firstValue == prepareSchedule.combinationalSchedules.Count)
                nxtBtn.Visible = false;
            
            clbl = new Label[10];
            tlbl = new Label[20];
            pageShow.Text = "Page no: " + pageValue.ToString() + "\n";
            pageShow.Text += "Total produced: ";
            pageShow.Text += prepareSchedule.combinationalSchedules.Count.ToString();

            routineLabel.Text += " ";
            routineLabel.Text += firstValue.ToString();
            this.storeComponents();
            this.viewResults();
        }
        private void viewResults()
        {
            int lblCounter = 0;
            string name;
            course t;

            for (int i = 0; i < noOfCourses; i++)
            {
                t = prepareSchedule.combinationalSchedules[pageValue - 1].courses[i];
                name = t.name;
                if (name.Length > 26)
                {
                    name = name.Remove(25, name.Length - 25);
                    name += "...";
                }
                else name += " ";
                name += "[" + t.section + "]";
                clbl[i].Text = name;

                for (int j = 0; j < t.slots.Count; j++)
                {
                    tlbl[lblCounter++].Text = getLabelString(t, j);
                }
            }
        }
        private string getLabelString (course t, int i)
        {
            int subStringPart = 0;
            DateTime dt = DateTime.Now;
            while (dt.ToString()[subStringPart] != ' ')
                subStringPart++;
            subStringPart++;
            //subStringPart is changed according to the date
            //The more letters in the date the more value for subStringPart
            string temp, txt = "";
            txt += t.slots[i].day;
            txt += ": ";
            temp = t.slots[i].start.ToString().Substring(subStringPart, 5);
            if (temp.EndsWith(":"))
                txt += temp.Substring(0, 4);
            else txt += temp.Substring(0, 5);
            txt += " - ";
            temp = t.slots[i].end.ToString().Substring(subStringPart, 5);
            if (temp.EndsWith(":"))
                txt += temp.Substring(0, 4);
            else txt += temp.Substring(0, 5);
            return txt;
        }

        private void MinimizeWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prevPage(object sender, EventArgs e)
        {
            this.Hide();
            if (prev == null) sList.Show();
            else prev.Show();
        }

        private void nxtResult(object sender, EventArgs e)
        {
            this.Hide();
            new resultsForMore(pageValue + 1, this, null, username).ShowDialog();
        }

        private void storeComponents ()
        {
            clbl[0] = clbl1;
            clbl[1] = clbl2;
            clbl[2] = clbl3;
            clbl[3] = clbl4;
            clbl[4] = clbl5;
            clbl[5] = clbl6;
            clbl[6] = clbl7;
            clbl[7] = clbl8;
            clbl[8] = clbl9;
            clbl[9] = clbl10;

            tlbl[0]  = tlbl1;
            tlbl[1]  = tlbl2;
            tlbl[2]  = tlbl3;
            tlbl[3]  = tlbl4;
            tlbl[4]  = tlbl5;
            tlbl[5]  = tlbl6;
            tlbl[6]  = tlbl7;
            tlbl[7]  = tlbl8;
            tlbl[8]  = tlbl9;
            tlbl[9]  = tlbl10;
            tlbl[10] = tlbl11;
            tlbl[11] = tlbl12;
            tlbl[12] = tlbl13;
            tlbl[13] = tlbl14;
            tlbl[14] = tlbl15;
            tlbl[15] = tlbl16;
            tlbl[16] = tlbl17;
            tlbl[17] = tlbl18;
            tlbl[18] = tlbl19;
            tlbl[19] = tlbl20;

            for (int i = 0; i < 10; i++) clbl[i].Text = "";
            for (int i = 0; i < 20; i++) tlbl[i].Text = "";
        }
    }
}
