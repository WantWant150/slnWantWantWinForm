using Microsoft.Build.Framework.XamlTypes;
using prjWantWantWinForm;
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

    public partial class FrmOrders : Form
    {
        //private int accountId;
        private NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        //public int AccountId
        //{
        //    get { return accountId; }
        //    set { accountId = value; }
        //}

        public FrmOrders()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;

        }
        private bool showAllOrders = true;  // 記錄是否要顯示所有訂單

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            LoadOrders();
            var q = from p in dbContext.PayWays     
                    select p.PayWayName;
            this.coboPay.DataSource = q.ToList();
            this.coboPay.SelectedIndex = 0;

        }

        private void LoadOrders()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            var orders = from o in dbContext.Orders
                        where o.AccountID == CMember.AccountID
                        select new
                        {
                            訂單編號 = o.OrderID,
                            訂單類別 = o.Category.CategoryName,       
                            總金額或點數 = (o.CategoryID == 1) ? o.OrderPrice : o.OrderUsePoint,
                            付款方式 = o.PayWay.PayWayName,
                            購買日期 = o.CreateTime,
                        };

            dataGridView2.DataSource = orders.ToList();
        }
    
        private void LoadCategoryOrders(int categoryId)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            var orders = from o in dbContext.Orders
                         where o.AccountID == CMember.AccountID && o.CategoryID == categoryId
                         select new
                         {
                             訂單編號 = o.OrderID,
                             訂單類別 = o.Category.CategoryName,
                             總金額或總點數 = categoryId == 1 ? o.OrderPrice : o.OrderUsePoint,
                             付款方式 = o.PayWay.PayWayName,
                             購買日期 = o.CreateTime,
                         };

            dataGridView2.DataSource = orders.ToList();


        }

        private void LoadOrderDetails(int orderId)
        {

            {
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                var orderDetails = from od in dbContext.OrderDetails
                                   where od.OrderID == orderId && od.Order.CategoryID == 1
                                   select new
                                   {
                                       產品名稱 = od.Product.ProductName,
                                       數量 = od.Quantity,
                                       單價or點數 = (od.Order.CategoryID == 1) ? od.UnitPrice : od.UnitPoint,
                                       獲得點數 = od.GetPoint,          
                                       總價 = (od.Order.CategoryID == 1) ? od.UnitPrice * od.Quantity : od.UnitPoint * od.Quantity,
                                   };


                var orderDetails2 = from od in dbContext.OrderDetails
                                   where od.OrderID == orderId && od.Order.CategoryID == 2
                                   select new
                                   {
                                       產品名稱 = od.Product.ProductName,
                                       數量 = od.Quantity,
                      
                                       單價or點數 = (od.Order.CategoryID == 1) ? od.UnitPrice : od.UnitPoint,
                                       曝光天數 = od.TopDate,
                                       總價 = (od.Order.CategoryID == 1) ? od.UnitPrice * od.Quantity : od.UnitPoint * od.Quantity,
                                   };




                if (orderDetails.Any())
                {
                  
                    dataGridView1.DataSource = orderDetails.ToList();
                }

                else if (orderDetails2.Any()) 
                {
               
                    dataGridView1.DataSource = orderDetails2.ToList();
                }

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int orderId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["訂單編號"].Value);
                LoadOrderDetails(orderId);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            showAllOrders = false;
            LoadCategoryOrders(1);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            showAllOrders = false;
            LoadCategoryOrders(2);
        }

        private void btnAllOrder_Click(object sender, EventArgs e)
        {
            showAllOrders = true;
            LoadOrders();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var q = from o in dbContext.Orders
                    where o.CreateTime >= this.dateTimePicker1.Value && o.CreateTime <= this.dateTimePicker2.Value
                    select o;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;

            if (showAllOrders)
            {
                // 顯示所有訂單並按日期排序
                var orders = from o in dbContext.Orders
                             where o.AccountID == CMember.AccountID
                             orderby o.CreateTime
                             select new
                             {
                                 訂單編號 = o.OrderID,
                                 訂單類別 = o.Category.CategoryName,
                                 總金額或點數 = (o.CategoryID == 1) ? o.OrderPrice : o.OrderUsePoint,
                                 付款方式 = o.PayWay.PayWayName,
                                 購買日期 = o.CreateTime,
                             };

                dataGridView2.DataSource = orders.ToList();
            }
            else
            {
                // 只顯示 Order.CategoryID == 1 的訂單並按日期排序
                var orders = from o in dbContext.Orders
                             where o.AccountID == CMember.AccountID && o.CategoryID == 1
                             orderby o.CreateTime
                             select new
                             {
                                 訂單編號 = o.OrderID,
                                 訂單類別 = o.Category.CategoryName,
                                 總金額或點數 = o.OrderPrice,
                                 付款方式 = o.PayWay.PayWayName,
                                 購買日期 = o.CreateTime,
                             };

                dataGridView2.DataSource = orders.ToList();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string selectedPayWay = coboPay.SelectedItem.ToString();  // 取得所選的付款方式

            var orders = from o in dbContext.Orders
                         where o.AccountID == CMember.AccountID && o.PayWay.PayWayName == selectedPayWay
                         select new
                         {
                             訂單編號 = o.OrderID,
                             訂單類別 = o.Category.CategoryName,
                             總金額或點數 = (o.CategoryID == 1) ? o.OrderPrice : o.OrderUsePoint,
                             付款方式 = o.PayWay.PayWayName,
                             購買日期 = o.CreateTime,
                         };

            dataGridView2.DataSource = orders.ToList();
        }
    }
    
    }

