using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjShop
{
    public partial class FrmMember : Form
    {
        private int accountId;
        public FrmMember()
        {
            InitializeComponent();
          /*  accountId = 12; */// 資料庫有一筆 accountId = 9的資料，假設這是登入的ACCOUNTID
        }
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

       
        private void button1_Click(object sender, EventArgs e)
        {
            //傳送給FrmShop，FrmShop也要有getset來接
            FrmShop frmShop = new FrmShop();
            //frmShop.AccountId = CMember.AccountID;
            frmShop.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmOrders F = new FrmOrders();
            //F.CMEBER = CMember.AccountID;
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPointShop frmShop = new FrmPointShop();
            //frmShop.AccountId = accountId;
            frmShop.Show();
        }
    }
}
