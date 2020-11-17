using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SchedulingWizard.DBConnection;
using SchedulingWizard.scheduling_Datatypes;

namespace SchedulingWizard.frames
{
    public partial class showCourseList : Form
    {
        private string username;
        
        private showOption showOpt;
        private showCourseList showCL;
        private DataTable dt;
        private int initNum, numOfRows;
        
        private Label[] numlbl = new Label[8];
        private Label[] courselbl = new Label[8];
        private CheckBox[] cbox = new CheckBox[8];
        
        public showCourseList(string uname, int initializar, showOption so, showCourseList cl)
        {
            InitializeComponent();
            username = uname;
            initNum = initializar;
            storeComponents();

            showOpt = so;
            showCL = cl;

            string query = "select * from courses";
            DataRow row;
            database db = new database();
            dt = db.Table(query);
            setCoursesAndNumbers(dt, initNum);
            setCheckBox();
            refreshSelections();
        }   
        private void setCoursesAndNumbers (DataTable dt, int Num)
        {       
            numOfRows = dt.Rows.Count;
            DataRow row;
            for (int i = 0; i < 8 && Num < numOfRows; i++)
            {
                row = dt.Rows[Num++];
                courselbl[i].Text = row["name"].ToString();
                numlbl[i].Text = row["id"].ToString() + ".";
            }
        }   
        private void searchCourse(object sender, EventArgs e)
        {
            this.setCoursesAndNumbers(dt, initNum);
            if (searchLabel.Text == "")
            {
                refreshSelections();
                return;
            }
            string query = "select * from courses where name like '" + searchLabel.Text + "%'";
            database db = new database();
            DataTable dt2 = db.Table(query);
            if (dt2.Rows.Count > 0)
                this.setCoursesAndNumbers(dt2, 0);
            refreshSelections();
        }   
        public void refreshSelections()
        {
            string txt;
            DataTable dt = new database().Table("select * from selection");
            for (int i = 0; i < 8; i++)
            {
                txt = courselbl[i].Text;
                if (txt == "") return;
                if (txt[txt.Length - 1] == '✔')
                {
                    txt = txt.Remove(txt.Length - 2, 2);
                }
                if (cbox[i].Visible == false)
                    cbox[i].Visible = true;
                checkingWithSelection(txt, i, dt);
            }
        }
        private void checkingWithSelection(string txt, int i, DataTable dt)
        {
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                if (txt == dt.Rows[j]["name"].ToString())
                {
                    if (cbox[i].Checked == false)
                        cbox[i].Checked = true;
                    txt += " ✔";
                    courselbl[i].Text = txt;
                    return;
                }
            }
            courselbl[i].Text = txt;
            if (cbox[i].Checked)
                cbox[i].Checked = false;
        }
        private void setCheckBox()
        {          
            cbox[0] = checkBox1;
            cbox[1] = checkBox2;
            cbox[2] = checkBox3;
            cbox[3] = checkBox4;
            cbox[4] = checkBox5;
            cbox[5] = checkBox6;
            cbox[6] = checkBox7;
            cbox[7] = checkBox8;
                   
            for (int i = 0; i < 8; i++)
            {
                if (courselbl[i].Text == "")
                    cbox[i].Visible = false;
            }
        }
        private void prevPage(object sender, EventArgs e)
        {
            this.Hide();
            if (showOpt == null)
            {
                showCL.refreshSelections();
                showCL.Show();
            }
            else showOpt.Show();
        }
        private void minimizePage(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void selectChoice (object sender, EventArgs e)
        {
            database db = new database();
            string query, course;
            string txt, num;
            for (int i = 0; i < 8; i++)
            {
                if (courselbl[i].Text == "")
                    continue;
                txt = courselbl[i].Text;
                if (cbox[i].Checked)
                {
                    if (txt[txt.Length - 1] != '✔')
                    {
                        num = numlbl[i].Text.ToString();
                        num = num.Remove(num.Length - 1, 1);
                        course = txt;
                        txt += " ✔";
                        query = "insert into selection values (" + num + ",'" + course + "')";
                        db.update(query);
                    }
                }
                else
                {
                    if (txt[txt.Length - 1] == '✔')
                    {
                        txt = txt.Remove(txt.Length - 2, 2);
                        course = txt;
                        query = "delete from selection where name = '" + course + "'";
                        db.update(query);
                    }
                }
                courselbl[i].Text = txt;
            }
            refreshSelections();
        }
        private void generateSchedule(object sender, EventArgs e)
        {
            database db = new database();
            List<string> courseID = new List<string>();
            string query = "select * from selection";
            DataTable dt = db.Table(query);
            int len = dt.Rows.Count;

            if (len == 0)
            {
                MessageBox.Show("Please select the courses you want to take..!");
                return;
            }

            routine[] selectedCourses = new routine[len];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                courseID.Add(dt.Rows[i]["id"].ToString());
            }
            for (int i = 0; i < len; i++)
            {
                selectedCourses[i] = prepareSchedule.addSpecificCourse(courseID[i]);
            }         
            routine recursiveScheduleMaker = new routine();
            recursiveScheduleMaker.courses = new List<course>();
            
            prepareSchedule.combinationalSchedules = null;
            prepareSchedule.combinationalSchedules = new List<routine>();
            prepareSchedule.MakeMySchedule(0, selectedCourses, recursiveScheduleMaker);

            int generatedRoutines = prepareSchedule.combinationalSchedules.Count;
            
            if (generatedRoutines != 0)
            this.Hide();
            
            if (generatedRoutines == 0)
            {
                MessageBox.Show("No routines can be generated");
                return;
            }
            else if (prepareSchedule.combinationalSchedules[0].courses.Count > 5)
                new resultsForMore(1, null, this, username).ShowDialog();
            else new scheduleResults(1, null, this, username).ShowDialog();

            this.uncheckAllCheckBoxesPrev();
            this.uncheckAllCheckBoxesFurther();

            query = "delete from selection";
            db.update(query);
        }
        public void uncheckAllCheckBoxesPrev ()
        {
            for (int i = 0; i < 8; i++)
            {
                if (cbox[i].Checked) cbox[i].Checked = false;
            }
            if (showCL != null) showCL.uncheckAllCheckBoxesPrev();
        }


        public void uncheckAllCheckBoxesFurther ()
        {
            for (int i = 0; i < 8; i++)
            {
                if (cbox[i].Checked) cbox[i].Checked = false;
            }
        }
        private void nextPage(object sender, EventArgs e)
        {
            if (initNum + 8 < numOfRows)
            {
                this.Hide();
                new showCourseList(username, initNum + 8, null, this).ShowDialog();
            }
            else noCoursesAvailableShow.Visible = true;
        }
        private void storeComponents()
        {
            courselbl[0] = label1;
            courselbl[1] = label2;
            courselbl[2] = label3;
            courselbl[3] = label4;
            courselbl[4] = label5;
            courselbl[5] = label6;
            courselbl[6] = label7;
            courselbl[7] = label8;

            numlbl[0] = label9;
            numlbl[1] = label10;
            numlbl[2] = label11;
            numlbl[3] = label12;
            numlbl[4] = label13;
            numlbl[5] = label14;
            numlbl[6] = label15;
            numlbl[7] = label16;
        }
    }
}
