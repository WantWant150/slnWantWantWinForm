using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
    internal static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (System.Environment.OSVersion.Version.Major >= 6) { SetProcessDPIAware(); }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new FrmMainFrm());

            //Application.Run(new FrmMemberMain());
            //Application.Run(new FrmMemberInfo());
            //Application.Run(new FrmLogin());
            //Application.Run(new FrmMember());
          Application.Run(new FrmIndex());
            //Application.Run(new FrmExpertViewResume());

        }
    }
}
