using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new FrmMainFrm());

            //Application.Run(new FrmMemberMain());
            //Application.Run(new FrmMemberInfo());
            //Application.Run(new FrmLogin());
            //Application.Run(new FrmMember());
            Application.Run(new FrmIndex());
            //Application.Run(new FrmLogin());

        }
    }
}
