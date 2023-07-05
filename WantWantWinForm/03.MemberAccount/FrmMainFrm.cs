using prjIspanWinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjIspanWinForms
{
    public partial class FrmMainFrm : Form
    {
        public FrmMainFrm()
        {
            InitializeComponent();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            (new FrmMemberMain()).ShowDialog();
            //this.Dispose();
            //this.Close();
        }

        private void FrmMainFrm_Load(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                login.Dispose();
                if (!CLoginInfo.memInfoFinished)
                {
                    MessageBox.Show("請填寫個人資料");
                    FrmMemberInfo MemInfo = new FrmMemberInfo();
                    MemInfo.ShowDialog();
                    if (MemInfo.DialogResult == DialogResult.OK)
                    {
                        MemInfo.Dispose();
                    }
                }
                CMember.getMemInfo(CMember.AccountID);
                if (CMember.Name != null)
                {
                    this.label1.Text = $"歡迎光臨，{CMember.Name[0]}**";
                }
                else
                {
                    this.label1.Text = $"請填寫個人資料";
                }
            }

            else if (login.DialogResult == DialogResult.Cancel)
            {
                login.Dispose();
                this.Close(); //會直接結束程式
                return;
            }
        }

    }
}
