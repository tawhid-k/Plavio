using SchedulingWizard.DBConnection;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchedulingWizard.frames
{
    public partial class adminDropUser : Form
    {
        private Label[] nlbl, ulbl;
        private RadioButton[] rbtn;
        public DataTable dt;
        private adminFirst aFirst;
        private adminDropUser aUser;
        public int firstValue, noOfRows;
        
        public adminDropUser(DataTable dt, adminDropUser adu, adminFirst aF, int initNum)
        {
            InitializeComponent();

            this.dt = dt;
            aFirst = aF;
            aUser = adu;
            firstValue = initNum;
            noOfRows = dt.Rows.Count;

            int showDataNumber = 8;
            nlbl = new Label[showDataNumber];
            ulbl = new Label[showDataNumber];
            rbtn = new RadioButton[showDataNumber];

            storeComponents();
            showData();
        }
        private void showData()
        {
            for (int i = 0; i < 8; i++)
                nlbl[i].Text = ulbl[i].Text = "";

            for (int i = 0; i < 8 && (firstValue + i) < noOfRows; i++)
            {
                nlbl[i].Text = (firstValue + i).ToString() + ".";
                ulbl[i].Text = dt.Rows[firstValue + i]["name"].ToString();
            }
            if (firstValue + 7 > noOfRows)
            {
                for (int i = 0; i < 8; i++)
                    if (nlbl[i].Text == "")
                        rbtn[i].Visible = false;
            }
        }
        private void closeWindow(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void prevDataTableUpdate()
        {
            if (aUser != null)
            {
                aUser.dt = this.dt;
                aUser.noOfRows = this.noOfRows;
                aUser.prevDataTableUpdate();
            }
        }
        private void nxtPage(object sender, EventArgs e)
        {
            if (firstValue + 8 > noOfRows)
            {
                MessageBox.Show("No more users to be shown");
                return;
            }
            this.Hide();
            new adminDropUser(dt, this, null, firstValue + 8).ShowDialog();
        }

        private void minimizeWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void viewInfo(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
                if (rbtn[i].Checked)
                {
                    new adminShowUserInfo(i + firstValue, dt).ShowDialog();
                    return;
                }
            MessageBox.Show("Select a specific user first");
        }

        private void dropUser(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                if (rbtn[i].Checked)
                {
                    database db = new database();
                    string query = "delete from userinfo where name = '" + ulbl[i].Text + "'";
                    db.update(query);
                    query = "delete from enroll where username = '" + ulbl[i].Text + "'";
                    db.update(query);
                    query = "select * from userinfo";
                    dt = db.Table(query);
                    noOfRows = dt.Rows.Count;
                    prevDataTableUpdate();
                    this.showData();
                    return;
                }
            }
            MessageBox.Show("No user is selected");
        }

        private void prevPage(object sender, EventArgs e)
        {
            this.Hide();
            if (this.aFirst == null)
                aUser.Show();
            else aFirst.Show();
            this.Close();
        }

        private void storeComponents()
        {
            ulbl[0] = ulbl1;
            ulbl[1] = ulbl2;
            ulbl[2] = ulbl3;
            ulbl[3] = ulbl4;
            ulbl[4] = ulbl5;
            ulbl[5] = ulbl6;
            ulbl[6] = ulbl7;
            ulbl[7] = ulbl8;

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
