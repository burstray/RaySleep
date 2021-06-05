using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace RaySleep
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.Sleep(10000);
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }
    }
}
