using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjWantWantWinForm
{
    public partial class FrmMember : Form
    {
        public FrmMember()
        {
            InitializeComponent();
            loadData();
            loadReason();
            loadAccountStatus();
        }
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        private void loadData()
        {
            this.dataGridView1.Controls.Clear();

            var q = from m in dbContext.MemberAccounts
                    select new
                    {
                        會員編號 = m.AccountID,
                        會員帳號 = m.Name,
                        會員信箱 = m.Email,
                        帳號狀態 = m.AccountStatus ? "帳號正常" : "帳號停權",
                    };

            this.dataGridView1.DataSource = q.ToList();
        }

        private void loadAccountStatus()
        {
            comboBox1.Items.Add("停權");
            comboBox1.Items.Add("啟用");
        }

        private void loadReason() // 載入停權原因
        {
            try
            {
                NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
                var q = (from r in dbContext.StatusChangeReasons
                         select r.StatusChangeReason1).ToList();

                foreach (var m in q)
                {
                    comboBox2.Items.Add(m);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void checkSearch(string serach) //搜尋僅能使用英文、數字、特殊自元
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9\p{P}\p{S}]+$");
            if (!regex.IsMatch(serach))
            {
                MessageBox.Show("請填入英文數字特殊字元");
            }
        }



        private void btnSerach_Click(object sender, EventArgs e)
        {            
            try
            {
                this.dataGridView2.Controls.Clear();
                checkSearch(txtEmail.Text);

                var q = from m in dbContext.MemberAccounts
                        where m.Email.Contains(txtEmail.Text)
                        select new
                        {
                            會員編號 = m.AccountID,
                            會員帳號 = m.Name,
                            會員信箱 = m.Email,
                            會員電話 = m.PhoneNo,
                            會員性別 = m.Gender,
                            會員暱稱 = m.UserName,
                            會員生日 = m.BitrhDay,
                            會員點數 = m.MemberTotalPoint,
                            會員建立時間 = m.CreateTime,
                            帳號狀態 = m.AccountStatus ? "帳號正常" : "帳號停權",
                        };

                this.dataGridView2.DataSource = q.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void saveAccountStatus()
        {
            try
            {
                int selectID = (int)this.dataGridView2.CurrentRow.Cells["會員編號"].Value;
                var q = this.dbContext.MemberAccounts.Where(m => m.AccountID == selectID).FirstOrDefault();
                if (q != null)
                {
                    if (comboBox1.Text == "啟用")
                    {
                        q.AccountStatus = true;
                    }
                    else if (comboBox1.Text == "停權")
                    {
                        q.AccountStatus = false;
                    }

                    this.dbContext.SaveChanges();
                    loadData();
                    MessageBox.Show("已更新");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int selectID;

            if (dataGridView2.Columns.Count == 0)
            {
                return;
            }
            else
            {
                selectID = (int)this.dataGridView2.CurrentRow.Cells["會員編號"].Value;
            }

            // 1.限制「理由選單一定要有選項」
            if (comboBox1.Text.Length > 0 && comboBox2.Text.Length > 0)
            {
                //var product = (from p in this.dbContext.Products
                //               where p.ProductName.Contains("Test")
                //               select p).FirstOrDefault();


                // 2.把資料insert 進 member states change list

                // 3.把狀態member AcoountStatus 0或1 Update 到資料表member account 裡面
                int SCReasonID = (from s in dbContext.StatusChangeReasons
                                  where s.StatusChangeReason1 == comboBox2.Text
                                  select s.StatusChangeReasonID).FirstOrDefault();

                MemberStatusList memberStatusList = new MemberStatusList
                {
                    AccountID = selectID,
                    //TODO: CMember.AccountID
                    UpdateUser = CMember.AccountID,
                    UpdateTime = DateTime.Now,
                    StatusChangeReasonID = SCReasonID
                };

                this.dbContext.MemberStatusLists.Add(memberStatusList);

                // 4.做完要跳更新成功
                // 5.更新到datagrid view
                saveAccountStatus();
            }
            else
            {
                MessageBox.Show("請選取下拉式選單");
            }
        }
        private void loadLoginStatus()
        {
            int selectID = (int)this.dataGridView2.CurrentRow.Cells["會員編號"].Value;
            var q = from l in dbContext.LoginHistories
                     where l.AccountID == selectID
                     select new
                     {
                         登入編號 = l.LoginID,
                         會員名稱 = l.MemberAccount.Name,
                         登入狀態 = l.LoginS_F ? "成功登入" : "登入失敗",
                         登入時間 = l.LoginTime,
                         密碼失敗次數 = l.PasswordFailCount,
                         是否填寫基本資料 = l.MemberInfoFinished ? "已填寫基本資料" : "未填寫基本資料",

                     };

            this.dataGridView3.DataSource = q.ToList();
            var q2 = from s in dbContext.MemberStatusLists
                     where s.AccountID == selectID
                     select new
                     {
                         狀態變更編號 = s.StatusChangeID,
                         客服人員 = s.UpdateUser,
                         客服更新時間 = s.UpdateTime,
                         狀態變更理由 = s.StatusChangeReason.StatusChangeReason1,
                     };
            this.dataGridView4.DataSource = q2.ToList();

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            loadLoginStatus();
        }
    }
}