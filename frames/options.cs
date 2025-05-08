using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using SchedulingWizard.frames;

namespace SchedulingWizard
{
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();
            //new connector();
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Aqua;
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Aqua;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(0, 0, 64);
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(0, 0, 64);
        }
        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void createAccount(object sender, EventArgs e)
        {
            signup sg = new signup(this);
            this.Hide();
            sg.ShowDialog();
        }

        private void goLogin(object sender, EventArgs e)
        {
            this.Hide();
            new login(this).ShowDialog();
        }

        private void showDetails(object sender, EventArgs e)
        {
            new information().ShowDialog();
        }
    }
}
