using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
    public partial class FrmBackServiceContact : Form
    {
        public FrmBackServiceContact()
        {
            InitializeComponent();
        }


        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();


        private void FrmBackServiceContact_Load(object sender, EventArgs e)
        {
            loadData();
        }


        #region 讀取資料()
        private void loadData()
        {
            var q = from s in dbContext.ServiceContacts
                    select new
                    {
                        會員帳號 = s.MemberAccount.Email,
                        會員名稱 = s.MemberAccount.Name,
                        會員訊息編號 = s.ServiceContactID,
                        會員訊息標題 = s.ComplaintTitle,
                        會員訊息內容 = s.ComplaintContent,
                        處理狀態 = s.ProcessStatus ? "處理完畢" : "處理中",
                    };

            this.dataGridView1.DataSource = q.ToList();
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView2.Controls.Clear();
                checkSearch(txtEmail.Text);

                var q = from s in dbContext.ServiceContacts
                        where s.MemberAccount.Email.Contains(txtEmail.Text)
                        select new
                        {
                            會員訊息編號 = s.ServiceContactID,
                            會員訊息標題 = s.ComplaintTitle,
                            會員訊息內容 = s.ComplaintContent,
                            處理狀態 = s.ProcessStatus ? "處理完畢" : "處理中",
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
            this.dataGridView2.Controls.Clear();

            string selectID;

            // 如果 dataGridView2的內容等於0時退出這個判斷式
            if (dataGridView2.Columns.Count == 0)
            {
                return;
            }
            else
            {
                // 取得 dataGridView2資料列的會員訊息編號
                selectID = this.dataGridView2.CurrentRow.Cells["會員訊息編號"].Value.ToString();
            }

            // 1. 當狀態選擇大於0的時候
            if (comboBox1.Text.Length > 0)
            {

                // 2. 把狀態選擇的comboBox取到的值  
                bool SCReasonID = comboBox1.Text == "處理中" ? true : false;

                // 3. 狀態處理完畢 Update 到資料表 ServiceContact 裡面
                ServiceContact q = (from s in this.dbContext.ServiceContacts
                                    where s.ServiceContactID.ToString() == selectID.ToString()
                                    select s).FirstOrDefault();

                q.ProcessStatus = SCReasonID;

                // 4. 把資料update ServiceContact
                this.dbContext.SaveChanges();

                // 5. 查詢的資料欄位
                var q2 = from s in dbContext.ServiceContacts

                             // 會員訊息編號 等於 dataGridView2資料列的會員訊息編號
                         where s.ServiceContactID.ToString() == selectID.ToString()
                         select new
                         {
                             會員訊息編號 = s.ServiceContactID,
                             會員訊息標題 = s.ComplaintTitle,
                             會員訊息內容 = s.ComplaintContent,
                             處理狀態 = s.ProcessStatus ? "處理中" : "處理完畢",
                         };

                // 6.更新到dataGridView2
                this.dataGridView2.DataSource = q2.ToList();

                MessageBox.Show("處理成功！");

            }
            else
            {
                MessageBox.Show("請選取下拉式選單");
            }

        }
        #endregion


        #region dataGridView2選到的資料        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // textBox的值大於0時，
            if (txtEmail.Text.Length > 0)
            {
                // dataGridView2 得到的 會員訊息編號
                int selectID = (int)this.dataGridView2.CurrentRow.Cells["會員訊息編號"].Value;

                // 查詢的資料欄位
                var q = from s in dbContext.ServiceContacts

                        // 會員訊息編號 等於 dataGridView2 得到的 會員訊息編號
                        where s.ServiceContactID == selectID
                        select new
                        {
                            會員帳號 = s.MemberAccount.Email,
                            會員名稱 = s.MemberAccount.Name,
                            會員訊息編號 = s.ServiceContactID,
                            會員訊息標題 = s.ComplaintTitle,
                            會員訊息內容 = s.ComplaintContent,
                            處理狀態 = s.ProcessStatus ? "處理完畢" : "處理中",

                        };
            }

            else
            {
                MessageBox.Show("請輸入帳號");
            }
        }
        #endregion

    }
}

