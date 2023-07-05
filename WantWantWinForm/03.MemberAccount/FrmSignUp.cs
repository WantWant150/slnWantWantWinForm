using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjWantWantWinForm
{
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }
        CSignUp csu = new CSignUp(); //為使用CSignUp的方法，實作
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (csu.CheckPassword(txtBoxPassword.Text, label5))
                {
                    if (csu.CheckPasswordSame(txtBoxPasswordConfirm.Text, txtBoxPassword.Text, label6))
                    {
                        //在MemberAccount資料表新增一筆資料後
                        MemberAccount newmem = new MemberAccount 
                        {   
                            Email = txtBoxMemberEmail.Text, 
                            Password = txtBoxPasswordConfirm.Text, 
                            CreateTime = DateTime.Now, 
                            AccountStatus = true 
                        };
                        this.dbContext.MemberAccounts.Add(newmem);

                        this.dbContext.SaveChanges();

                        //在MemberRoleConn資料表新增會員對應到的角色(此時只給客服或一般會員)
                        if (newmem.Email.Contains("@want.com")) //客服人員都用公司email註冊
                        {
                            int memID = (from m in dbContext.MemberAccounts
                                        where m.Email == newmem.Email
                                        select m.AccountID).FirstOrDefault();
                            MemberRoleConn memRole = new MemberRoleConn
                            {
                                AccountID = memID,
                                RoleID = 2 //客服人員
                            };
                            this.dbContext.MemberRoleConns.Add(memRole);

                        } 
                        else //不是客服的都會獲得基本會員身分
                        {
                            int memID = (from m in dbContext.MemberAccounts
                                         where m.Email == newmem.Email
                                         select m.AccountID).FirstOrDefault();
                            MemberRoleConn memRole = new MemberRoleConn
                            {
                                AccountID = memID,
                                RoleID = 1 //會員
                            };
                            this.dbContext.MemberRoleConns.Add(memRole);
                        }
                        this.dbContext.SaveChanges();

                        MessageBox.Show("註冊成功");
                        this.Dispose();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("再看一下欄位喔~~");
                    }
                }
                else
                {
                    MessageBox.Show("再看一下欄位喔~~");
                }
            }
                catch 
            {
                MessageBox.Show("此電子信箱已註冊過");
            }
        }
    }
}
