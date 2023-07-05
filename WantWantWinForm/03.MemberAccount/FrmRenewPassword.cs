using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
    public partial class FrmRenewPassword : Form
    {
        public FrmRenewPassword()
        {
            InitializeComponent();

        }
        public FrmRenewPassword(string str) //為了將使用者Email帶過來此表單
         {        
             InitializeComponent();
            txtBoxMemberEmail.Text = str;
            this.ControlBox = false; // 禁用控制框
        }

        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        private void btnSaveNewPassword_Click(object sender, EventArgs e)
        {
            //TODO 確保所有錯誤都會被警告同時顯示
            Boolean result = CChangePassword.checkChangeNew(txtBoxNewPassword, label5) && //新密碼不能與舊密碼相同
                CChangePassword.checkPasswordsSame(txtBoxNewPassword, txtBoxNewPasswordConfirm, label5, label7); //新密碼二次確認

            if (result)
            {
                MemberAccount loginInfo = (from m in dbContext.MemberAccounts
                                           where m.AccountID == CMember.AccountID
                                           select m).FirstOrDefault();
                loginInfo.Password = txtBoxNewPassword.Text;
                this.dbContext.SaveChanges();
                MessageBox.Show("密碼修改成功");
                this.Close();
            }
        }
    }
}
