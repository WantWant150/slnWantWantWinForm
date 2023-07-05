using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prjWantWantWinForm
{
    public partial class FrmMemberMain : Form
    {
        public FrmMemberMain()
        {
            InitializeComponent();
        }

        private void btnFrmMemberInfo_Click(object sender, EventArgs e)
        {
            (new FrmMemberInfo()).Show();
        }

        private void btnFrmChangePassword_Click(object sender, EventArgs e)
        {
            (new FrmChangePassword()).ShowDialog();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmExpertHistory his = new FrmExpertHistory();
            his.MdiParent = this.MdiParent;
            his.WindowState = FormWindowState.Maximized;
            
            his.Show();
        }
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        private void button13_Click(object sender, EventArgs e)
        {
            var q = from ma in dbContext.MemberAccounts
                    join  mr in dbContext.MemberRoleConns on ma.AccountID equals mr.AccountID
                    where ma.AccountID == CMember.AccountID
                    select mr.RoleID;
            string roleStr = "";
            foreach (var item in q.ToList())
            {
                roleStr += item.ToString();
            }
            if (roleStr.Contains("3"))
            {
                FrmExpertView his = new FrmExpertView();
                his.MdiParent = this.MdiParent;
                his.WindowState = FormWindowState.Maximized;

                his.Show();
            }
            else
            {
                FrmExpertNew his = new FrmExpertNew();
                his.MdiParent = this.MdiParent;
                his.WindowState = FormWindowState.Maximized;

                his.Show();
            }
        }
    }
}
