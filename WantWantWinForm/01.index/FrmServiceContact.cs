using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjWantWantWinForm
{
    public partial class FrmServiceContact : Form
    {
        public FrmServiceContact()
        {
            InitializeComponent();
        }


        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();


        private void btnSend_Click(object sender, EventArgs e)
        {
            // 要新增會員ID、客服訊息標題、客服訊息內容
            ServiceContact serviceContact = new ServiceContact
            {
                AccountID = CMember.AccountID,
                ComplaintTitle = txtTitle.Text,
                ComplaintContent = txtContent.Text,
            };

            // 把資料 insert ServiceContact
            this.dbContext.ServiceContacts.Add(serviceContact);

            // 儲存資料
            this.dbContext.SaveChanges();

            MessageBox.Show("成功送出！");

            // 關閉視窗
            this.Dispose();
        }


        // 取消退出
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ($"確定取消嗎?確定即關閉此頁面", "取消?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

    }
}

