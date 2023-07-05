using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace prjWantWantWinForm
{
    public partial class FrmShop : Form
    {
        
        ////抓到是哪一個AccountId登入
        //private int accountId;
        //public int AccountId
        //{
        //    get { return accountId; }
        //    set { accountId = value; }
        //}


        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        // 購物車總金額
        private int totalAmount = 0;
        private int totalPoint = 0;
        // 購物車資料表
        private DataTable cartDataTable;
        public FrmShop()
        {
            InitializeComponent();
            // 初始化購物車資料表
            cartDataTable = new DataTable();
            // 初始化購物車資料表的欄位
            InitializeCartDataTable();
            // 載入商品資料
            LoadProducts();

        }
      
        private void InitializeCartDataTable()
        {
            //帶入購物車表
            cartDataTable.Columns.Add("ID", typeof(int));
            cartDataTable.Columns.Add("商品", typeof(string));
            cartDataTable.Columns.Add("數量", typeof(int));
            cartDataTable.Columns.Add("購買點數", typeof(int));
            cartDataTable.Columns.Add("購買總點數", typeof(int));
            cartDataTable.Columns.Add("單價", typeof(int));
            cartDataTable.Columns.Add("總價", typeof(int));
           
            dataGridView1.DataSource = cartDataTable;

            //設定寬度
            dataGridView1.Columns["ID"].Width =80; 
            dataGridView1.Columns["商品"].Width = 100; 
            dataGridView1.Columns["數量"].Width = 100; 
            dataGridView1.Columns["購買點數"].Width = 100;
            dataGridView1.Columns["購買總點數"].Width = 120;
            dataGridView1.Columns["單價"].Width = 100;
            dataGridView1.Columns["總價"].Width = 100; 
        }

        //載入商品
        private void LoadProducts()
        {
            var products = from p in dbContext.Products
                           where p.CategoryID == 1&&p.Status=="上架"
                           select p;
            //var products = dbContext.Products.ToList();
            foreach (var product in products)
            {
                ucProducts ucProduct = new ucProducts();
                ucProduct.Id = product.ProductID;
                ucProduct.PName = product.ProductName;
                ucProduct.PPrice = product.UnitPrice.ToString() + "元";
                ucProduct.PImage = GetProductImage(product.CoverPhoto);
                ucProduct.onSelect += UcProduct_onSelect;
                ucProduct.onCountChange += UcProduct_onCountChange;
                
                // 將商品控制項添加到flowLayoutPanel中
                flowLayoutPanel1.Controls.Add(ucProduct);
            }
        }

        // 選擇商品出現產品介紹和庫存
        private void UcProduct_onSelect(object sender, EventArgs e)
        { 
            
            ucProducts selectedProduct = (ucProducts)sender;
            var product = dbContext.Products.FirstOrDefault(p => p.ProductID == selectedProduct.Id);

            if (product != null)
            {
                labelDesc.Text = "產品介紹: "+product.ProductDesc;
                labStock.Text = "庫存: "+product.UnitsInStock.ToString();
            }
            // 重新計算並更新購物車總金額
            CalculateTotalAmount();
        }

        // 商品數量變更的方法
        private void UcProduct_onCountChange(object sender, EventArgs e)
        {
            ucProducts selectedProduct = (ucProducts)sender;
            var product = dbContext.Products.FirstOrDefault(p => p.ProductID == selectedProduct.Id);

            //
            if (product != null)
            {
                DataRow existingRow = cartDataTable.Rows.Cast<DataRow>()
                    .FirstOrDefault(row => Convert.ToInt32(row["ID"]) == selectedProduct.Id);

                //檢查商品數量是否為0，若為0則從購物車移除該商品
                if (selectedProduct.PCount == 0)
                {
                    if (existingRow != null)
                    {

                        cartDataTable.Rows.Remove(existingRow);
                        CalculateTotalAmount();
                        TotalPoint();
                    }
                }
                else
                {
                    if (existingRow == null)
                    {

                        DataRow newRow = cartDataTable.NewRow();
                        newRow["ID"] = selectedProduct.Id;
                        newRow["商品"] = product.ProductName;
                        newRow["數量"] = selectedProduct.PCount;
                        newRow["購買點數"] = product.GetPoint;
                        newRow["購買總點數"] = selectedProduct.PCount * product.GetPoint;
                        newRow["單價"] = product.UnitPrice;
                        newRow["總價"] = selectedProduct.PCount * product.UnitPrice;
                        cartDataTable.Rows.Add(newRow);
                      
                        
                    }
                    else
                    {
                        // 更新購物車中該商品的數量.總價
                        existingRow["數量"] = selectedProduct.PCount;
                        existingRow["總價"] = selectedProduct.PCount * product.UnitPrice;
                        existingRow["購買總點數"] = selectedProduct.PCount * product.GetPoint;
                    }

                    // 重新計算並更新購物車總金額
                    CalculateTotalAmount();
                    TotalPoint();
                }
            }
         
        }

        //總金額
        private void CalculateTotalAmount()
        {
            totalAmount = 0;

            foreach (DataRow row in cartDataTable.Rows)
            {
                totalAmount += Convert.ToInt32(row["總價"]);

            }

            labTotal.Text = "購物車內總金額: "+totalAmount.ToString() + "元";
        }
        // 總點數
        private void TotalPoint()
        {
            totalPoint = 0;

            foreach (DataRow row in cartDataTable.Rows)
            {
                totalPoint += Convert.ToInt32(row["購買總點數"]);
                labPoint.Text = "總點數: " + totalPoint.ToString() + "點";
               
            }
            
            labPoint.Text = "總點數: " + totalPoint.ToString() + "點";
        }
        //從資料庫抓圖片
        private Image GetProductImage(byte[] imageBytes)
        {
            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(memoryStream);
                }
            }
            return null;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cartDataTable.Rows.Count == 0)
            {
                MessageBox.Show("購物車中沒有任何商品，無法進行結帳。", "無法結帳");
                return;
            }

            // 抓付款方式
            string pay = comboPay.Text;
            var q = from p in dbContext.PayWays
                    where p.PayWayName == pay
                    select p.PayWayID;
            int payWayID = q.FirstOrDefault();

            // 計算總金額
            int totalAmount = 0;
            foreach (DataRow row in cartDataTable.Rows)
            {
                totalAmount += Convert.ToInt32(row["總價"]);
            }

            // 確認結帳頁面
            DialogResult result = MessageBox.Show($"確定要使用 ({pay}) 購買所選商品嗎？\n總金額為: ({totalAmount,0:c2})", "確認購買", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // 檢查庫存
                bool checkStock = true;
                List<int> failedProducts = new List<int>();
                foreach (DataRow row in cartDataTable.Rows)
                {
                    int productID = Convert.ToInt32(row["ID"]);
                    int quantity = Convert.ToInt32(row["數量"]);

                    var product = dbContext.Products.FirstOrDefault(p => p.ProductID == productID);

                    if (product != null && product.UnitsInStock >= quantity)
                    {
                        // 更新資料庫中的庫存
                        product.UnitsInStock -= quantity;
                    }
                    else
                    {
                        // 結帳失敗，庫存不足
                        checkStock = false;
                        failedProducts.Add(productID);
                    }
                }

                if (checkStock)
                {
                    // 創建新的訂單
                    Order order = new Order
                    {
                        AccountID = CMember.AccountID,
                        CategoryID = 1,
                        OrderPrice = totalAmount,
                        OrderGetPoint = totalPoint,
                        CreateTime = DateTime.Now,
                        // TODO: 設定 StatusID
                        StatusID = 10,
                        PayWayID=payWayID
                       
                    };

                    // 將購物車中的商品資訊變成為訂單明細並儲存到OrderDetail表中
                    List<OrderDetail> orderDetails = new List<OrderDetail>();
                    foreach (DataRow row in cartDataTable.Rows)
                    {
                        OrderDetail detail = new OrderDetail
                        {
                            OrderID = order.OrderID,
                            ProductID = Convert.ToInt32(row["ID"]),
                            Quantity = Convert.ToInt32(row["數量"]),
                            UnitPrice = Convert.ToInt32(row["單價"]),
                            GetPoint = Convert.ToInt32(row["購買點數"]),
              
                        };

                        // 將detail物件儲存到資料庫的OrderDetail中
                        dbContext.OrderDetails.Add(detail);
                        orderDetails.Add(detail);
                    }

                    // 將order物件儲存到資料庫的Order中
                    dbContext.Orders.Add(order);
                    dbContext.SaveChanges();

                    MessageBox.Show("購買成功！", "結帳成功");

                    // 更新會員總點數
                    var memberAccount = dbContext.MemberAccounts.FirstOrDefault(m => m.AccountID == CMember.AccountID);

                    if (memberAccount != null)
                    {
                        memberAccount.MemberTotalPoint += totalPoint;
                        dbContext.SaveChanges();
                    }
 
                    // 清空購物車
                    cartDataTable.Rows.Clear();
                    CalculateTotalAmount();
                    TotalPoint();
                    //ucProduct.PCount=0
                    foreach (ucProducts ucProduct in flowLayoutPanel1.Controls.OfType<ucProducts>())
                    {
                        ucProduct.PCount = 0;
                    }

                    // 創建並顯示FrmOrderDetail表單
                    FrmOrderDetail frmOrderDetail = new FrmOrderDetail();
                    frmOrderDetail.LoadOrderData(order);
                    frmOrderDetail.LoadOrderDetailData(orderDetails);
                    frmOrderDetail.ShowDialog();

                   
                }
                else
                {
                   
                    string failedProductIDs = string.Join(", ",$"編號為{failedProducts.FirstOrDefault()}" );
                    MessageBox.Show($"庫存不足，無法購買以下編號的商品：{failedProductIDs}", "結帳失敗");
                }
            }
           


        }

        private void FrmShop_Load(object sender, EventArgs e)
        {
            var q = from p in dbContext.PayWays
                    where p.PayWayID!=4
                    select p.PayWayName;
            this.comboPay.DataSource = q.ToList();
            this.comboPay.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }

}
