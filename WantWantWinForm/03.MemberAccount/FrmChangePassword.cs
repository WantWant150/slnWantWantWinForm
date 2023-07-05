using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjIspanWinForms
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        private void btnSaveNewPassword_Click(object sender, EventArgs e)
        {
            //TODO 確保所有錯誤都會被警告同時顯示
            Boolean result = CChangePassword.checkPassword(txtBoxOriginalPassword, label6) && //驗證原本密碼
                CChangePassword.checkChangeNew(txtBoxNewPassword, label5) && //新密碼不能與舊密碼相同
                CChangePassword.checkPasswordsSame(txtBoxNewPassword, txtBoxNewPasswordConfirm, label5, label7); //新密碼二次確認
            if (result)
            {
                //如果三個條件皆符合，就將新密碼Update至MemberAccount資料表
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
