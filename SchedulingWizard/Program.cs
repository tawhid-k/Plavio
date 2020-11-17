using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using SchedulingWizard.frames;
using System.Collections.Generic;

namespace SchedulingWizard
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new options());
        }
    }
}
