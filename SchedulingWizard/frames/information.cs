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
    public partial class information : Form
    {
        public information()
        {
            InitializeComponent();
        }

        private void closeWindow(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
