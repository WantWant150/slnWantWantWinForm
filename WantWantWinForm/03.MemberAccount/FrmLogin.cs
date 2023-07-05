using prjIspanWinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjIspanWinForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.ControlBox = false; // 禁用控制框
        }
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        //LoginHistory
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                dbContext = new NewIspanProjectEntities();

                //以會員帳號(email)來抓取登入中會員
                MemberAccount loginInfo = (from m in this.dbContext.MemberAccounts
                                           where m.Email == txtMemberEmail.Text
                                           select m).FirstOrDefault();

                //如果登入中會員有帳號&&密碼同輸入
                if (loginInfo != null && txtMemberPassword.Text == loginInfo.Password)
                {
                    //如果會員狀態為啟用
                    if (loginInfo.AccountStatus == true)
                    {
                        this.DialogResult = DialogResult.OK;
                        CMember.getMemberID(loginInfo); //取得登入的會員資訊
                                                        //將資料匯入"LoginHistory"'資料表
                        LoginHistory loghis = new LoginHistory();
                        CLoginInfo.setLogHis(loghis, true);
                        this.dbContext.LoginHistories.Add(loghis);
                        this.dbContext.SaveChanges();
                    }
                    else //會員被停權
                    {
                        MessageBox.Show("帳號已被停權，請聯繫客服", "Prompt message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //當會員輸入密碼錯誤時，還是要記錄到資料表LoginHistory
                {
                    CMember.getMemberID(loginInfo);

                    LoginHistory loghis = new LoginHistory();
                    CLoginInfo.setLogHis(loghis, false);
                    this.dbContext.LoginHistories.Add(loghis);
                    this.dbContext.SaveChanges();

                    MessageBox.Show("帳號密碼不符", "Prompt message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //如果連續五次的話，會強制修改密碼
                    if(loghis.PasswordFailCount >= 5)
                    {
                        FrmForgetPassword frmfp = new FrmForgetPassword(false);
                        frmfp.ShowDialog();

                        frmfp.MdiParent = this.MdiParent;
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("尚未註冊帳號");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void labSingUp_Click(object sender, EventArgs e)
        {
            (new FrmSignUp()).ShowDialog();
        }

        private void labForgetPassword_Click(object sender, EventArgs e)
        {
            FrmForgetPassword frmfp = new FrmForgetPassword();
            frmfp.ShowDialog();
            frmfp.MdiParent = this.MdiParent;
        }
    }
}
