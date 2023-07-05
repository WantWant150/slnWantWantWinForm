using prjWantWantWinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
    public partial class FrmOrderDetail : Form
    {
        
        //private int accountId;
        ////public int AccountId
        ////{
        ////    get { return accountId; }
        ////    set { accountId = value; }
        //}
        public FrmOrderDetail()
        {
            InitializeComponent();
           
        }

        public Order Order { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        public void LoadOrderData(Order order)
        {
            if (order.CategoryID == 1)
            {
                dataGridView2.DataSource = null;
                var q = from o in dbContext.Orders
                        join c in dbContext.Categories on o.CategoryID equals c.CategoryID
                        where o.OrderID == order.OrderID
                        select new
                        { 
                            購買日期 = o.CreateTime,
                            訂單編號 = o.OrderID,
                            訂單類別 = c.CategoryName,
                            訂單總金額 = o.OrderPrice,
                            付款方式 = o.PayWay.PayWayName
                        };
                dataGridView2.DataSource = q.ToList();
            }
            else if (order.CategoryID == 2)
            {
                dataGridView2.DataSource = null;
                var q = from o in dbContext.Orders
                        join c in dbContext.Categories on o.CategoryID equals c.CategoryID
                        where o.OrderID == order.OrderID
                        select new
                        {
                            訂單編號 = o.OrderID,
                            訂單類別 = c.CategoryName,
                            訂單總點數 = o.OrderUsePoint,
                            加值項目 = o.OrderDetails.FirstOrDefault().CaseID != null ? o.OrderDetails.FirstOrDefault().TaskList.TaskTitle.ToString() : "您的履歷",
                            付款方式 = o.PayWay.PayWayName,

                        };
                dataGridView2.DataSource = q.ToList();
            }

        }


            public void LoadOrderDetailData(List<OrderDetail> orderDetails)
        {

            var q = orderDetails.Select(od => new
            {
                訂單編號 = od.OrderID,
                產品名稱 = od.Product.ProductName,
                數量 = od.Quantity,
                單價or點數 = (od.Order.CategoryID == 1) ? od.UnitPrice : od.UnitPoint,
              獲得點數 = (od.Order.CategoryID == 1) ? od.GetPoint : (object)null,
                曝光天數 = od.TopDate
            });
            
           
            dataGridView1.DataSource = q.ToList();

        }
             
    }
}
