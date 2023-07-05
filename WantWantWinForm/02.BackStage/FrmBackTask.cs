using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
    public partial class FrmBackTask : Form
    {
        public FrmBackTask()
        {
            InitializeComponent();
            loadData();
            loadReason();
        }

        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();


        #region 讀取資料
        private void loadData()
        {
            this.dataGridView1.Controls.Clear();

            var q = from m in dbContext.MemberAccounts
                    select new
                    {
                        會員編號 = m.AccountID,
                        會員帳號 = m.Name,
                        會員信箱 = m.Email,
                        
                    };

            this.dataGridView1.DataSource = q.ToList();
        }
        #endregion


        #region 載入任務下架原因
        private void loadReason()
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
        #endregion


        #region 搜尋僅能使用英文、數字、特殊自元
        public void checkSearch(string serach)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9\p{P}\p{S}]+$");
            if (!regex.IsMatch(serach))
            {
                MessageBox.Show("請填入英文數字特殊字元");
            }
        }
        #endregion


        #region 搜尋按鈕
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
        #endregion


        #region 儲存按鈕
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int selectID;

                if (dataGridView2.Columns.Count == 0)
                {
                    return;
                }
                else
                {
                    // 取得 dataGridView2資料列的會員訊息編號
                    selectID = (int)this.dataGridView2.CurrentRow.Cells["會員編號"].Value;
                }

                // 1. 限制「理由選單一定要有選項」
                if (comboBox1.Text.Length > 0 && comboBox2.Text.Length > 0)
                {
                    // 2.把狀態member AcoountStatus 0或1 Update 到資料表member account 裡面
                    int SCReasonID = (from s in dbContext.StatusChangeReasons
                                          // 取得comboBox2的停權原因
                                      where s.StatusChangeReason1 == comboBox2.Text
                                      select s.StatusChangeReasonID).FirstOrDefault();

                    // 3. 把資料insert 進 member states change list              
                    MemberStatusList memberStatusList = new MemberStatusList
                    {
                        AccountID = selectID,
                        UpdateUser = CMember.AccountID,
                        UpdateTime = DateTime.Now,
                        StatusChangeReasonID = SCReasonID
                    };

                    this.dbContext.MemberStatusLists.Add(memberStatusList);

                    #region 做完要跳更新成功，更新到dataGridView1

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
                else
                {
                    MessageBox.Show("請選取下拉式選單");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }
        #endregion       


        #region 讀取登入狀態資料表
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
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

            //this.dataGridView3.DataSource = q.ToList();
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
        #endregion

    }
}
