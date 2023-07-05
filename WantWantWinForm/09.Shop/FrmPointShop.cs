using prjWantWantWinForm;
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

namespace rjWantWantWinForm
{
    public partial class FrmPointShop : Form
    {
        private Timer timer;
        private int currentPosition;

        // 購物車總金額
        private int totalAmount = 0;
        //會員總點數
        int totalPoint;
        //曝光天數
        int day;
        // 購物車資料表
        private DataTable cartDataTable;

        public FrmPointShop()
        {
            // 初始化購物車資料表
            cartDataTable = new DataTable();
            InitializeComponent();
            // 初始化購物車資料表的欄位
            InitializeCartDataTable();

            // 創建並配置一個TIMER控制項
            timer = new Timer();
            timer.Interval = 10; // 設定間格時間
            timer.Tick += Timer_Tick; // 绑定
            timer.Start(); // 啟動
        }
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        private void coboxCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 清空購物車
            cartDataTable.Rows.Clear();
            if (comboboxCa.SelectedItem == "任務職缺置頂")
            {

                LoadProducts("任務職缺置頂");
                LoadCases();
            }
            else if (comboboxCa.SelectedItem == "專家履歷置頂")
            {
                LoadProducts("專家履歷置頂");
                LoadResumes();
            }
            labelDesc.Text = "產品介紹: ";
            labDay.Text = "曝光天數:";
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // 更新位置
            currentPosition -= 1; // 每次左移一個像素
            if (currentPosition < -label1.Width)
            {
                currentPosition = this.Width; // 超出左邊邊界後，會再從右邊移動
            }

            label2.Location = new Point(currentPosition, label2.Location.Y);
        }

        private void FrmPointShop_Load(object sender, EventArgs e)
        {
            LoadUserPoints();
        }

        //載入案件至COMBOBOX
        private void LoadCases()
        {
            comboboxRC.DataSource = null;
            var cases = dbContext.TaskLists
                .Where(t => t.AccountID == CMember.AccountID)
                .Select(t => new { t.CaseID, t.TaskTitle })
                .ToList();

            comboboxRC.DataSource = cases;
            comboboxRC.DisplayMember = "TaskTitle";
            comboboxRC.ValueMember = "CaseID";
        }
        //載入履歷至COMBOBOX
        private void LoadResumes()
        {
            comboboxRC.DataSource = null;
            var q = dbContext.Resumes
                .Where(r => r.AccountID == CMember.AccountID)
                .Select(r => new { r.ResumeID, ResumeTitle = "您的履歷" })
                .ToList();

            comboboxRC.DataSource = q;
            comboboxRC.DisplayMember = "ResumeTitle";
            comboboxRC.ValueMember = "ResumeId";
        }
        //分類別載入適合履歷或是任務職缺的商品
        private void LoadProducts(string s)
        {
            // 清空已有商品
            flowLayoutPanel1.Controls.Clear();
            var products = from p in dbContext.Products
                           where p.CategoryID == 2 && p.Status == "上架" && p.TopType == s
                           select p;

            foreach (var product in products)
            {
                ucProducts ucProduct = new ucProducts();
                ucProduct.Id = product.ProductID;
                ucProduct.PName = product.ProductName;
                ucProduct.PPrice = product.UnitPoint.ToString() + "點";
                ucProduct.PImage = GetProductImage(product.CoverPhoto);
                ucProduct.onSelect += UcProduct_onSelect;
                ucProduct.onCountChange += UcProduct_onCountChange;

                // 將商品控制項添加到flowLayoutPanel中
                flowLayoutPanel1.Controls.Add(ucProduct);
            }
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

        //載入會員累積點數
        private void LoadUserPoints()
        {
            var q = from p in dbContext.MemberAccounts
                    where p.AccountID == CMember.AccountID
                    select p.MemberTotalPoint;

            totalPoint = q.FirstOrDefault();
            labUserPoints.Text = "會員點數餘額:"+totalPoint + "點";

        }
        private void InitializeCartDataTable()
        {
            // 帶入購物車表
            cartDataTable.Columns.Add("ID", typeof(int));
            cartDataTable.Columns.Add("商品", typeof(string));
            cartDataTable.Columns.Add("數量", typeof(int));
            cartDataTable.Columns.Add("曝光天數", typeof(int));
            cartDataTable.Columns.Add("單價(點數)", typeof(int));
            // 這邊的TotalPoint跟SHOP的不同 這裡是花費 那邊是得到
          
            cartDataTable.Columns.Add("總點數", typeof(int));

            dataGridView1.DataSource = cartDataTable;

            // 設定寬度
            dataGridView1.Columns["ID"].Width = 40;
            dataGridView1.Columns["商品"].Width = 120;
            dataGridView1.Columns["數量"].Width = 100;
            dataGridView1.Columns["曝光天數"].Width = 100;
            dataGridView1.Columns["單價(點數)"].Width = 100;    
            dataGridView1.Columns["總點數"].Width = 120;

        }

        // 選擇商品出現產品介紹和庫存
        private void UcProduct_onSelect(object sender, EventArgs e)
        {

            ucProducts selectedProduct = (ucProducts)sender;
            var product = dbContext.Products.FirstOrDefault(p => p.ProductID == selectedProduct.Id);

            if (product != null)
            {
                labelDesc.Text = "產品介紹: " + product.ProductDesc;
                labDay.Text = "曝光天數:" + product.TopDate;
            }
            // 重新計算並更新購物車總金額
            CalculateTotalAmount();
          
        }
        //計算購物車總金額
        private void CalculateTotalAmount()
        {
            totalAmount = 0;

            foreach (DataRow row in cartDataTable.Rows)
            {
                totalAmount += Convert.ToInt32(row["總點數"]);
            }

            labTotal.Text = "購物車內商品點數: " + totalAmount.ToString() + "點";
        }
        //計算曝光天數
        private void CalculateTotalDAy() 
        {
            day = 0;
            foreach (DataRow row in cartDataTable.Rows)
            {
                day += Convert.ToInt32(row["曝光天數"]);
            }
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
                        CalculateTotalDAy();
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
                        newRow["曝光天數"] = selectedProduct.PCount * product.TopDate;
                        newRow["單價(點數)"] = product.UnitPoint;
                        newRow["總點數"] = selectedProduct.PCount * product.UnitPoint;

                        cartDataTable.Rows.Add(newRow);
                    }
                    else
                    {
                        // 更新購物車中該商品的數量.總價
                        existingRow["數量"] = selectedProduct.PCount;
                        existingRow["總點數"] = selectedProduct.PCount * product.UnitPoint;
                        existingRow["曝光天數"]= selectedProduct.PCount * product.TopDate;
                    }

                    // 重新計算並更新購物車總金額
                    CalculateTotalAmount();

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculateTotalDAy();
            // 檢查指定的要加值的職缺或履歷
            if (comboboxRC.SelectedItem==null)
            {
                MessageBox.Show("你沒有指定曝光的職缺或履歷", "警告");
                return;
            }

            if (cartDataTable.Rows.Count == 0)
            {
                MessageBox.Show("購物車中沒有任何商品，無法進行結帳。", "無法結帳");
                return;
            }
            // 商品類別
            string selectedCategory = comboboxCa.SelectedItem.ToString();
            //找到任務ID或履歷ID
            int selectedCaseId = 0;
            string selectedCase = "";
            if (comboboxCa.SelectedItem == "任務職缺置頂")
            {
                selectedCaseId = (int)comboboxRC.SelectedValue;
                selectedCase = comboboxRC.Text;
            }
            else if (comboboxCa.SelectedItem == "專家履歷置頂")
            {
                selectedCaseId = (int)comboboxRC.SelectedValue;
                selectedCase = comboboxRC.Text;
            }


            // 計算總金額
            int totalAmount = 0;
            foreach (DataRow row in cartDataTable.Rows)
            {
                totalAmount += Convert.ToInt32(row["總點數"]);
            }

            if (totalAmount > totalPoint)
            {
                MessageBox.Show("您的總點數不足，請先購買更多點數。", "結帳失敗");
                return;
            }

            // 確認結帳頁面
            DialogResult result = MessageBox.Show($"確定要為 ({selectedCase}) 添購曝光方案嗎？\n總金額為: ({totalAmount,0:c2})", "確認購買", MessageBoxButtons.YesNo);
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
                        CategoryID = 2,
                        OrderUsePoint = totalAmount,                     
                        CreateTime = DateTime.Now,
                        // TODO: 設定 StatusID
                        StatusID = 100,
                        PayWayID=4,

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
                            UnitPoint = Convert.ToInt32(row["單價(點數)"]),
                            TopDate = Convert.ToInt32(row["曝光天數"]),
                                                    

                        };
                        // 根據類別判斷要加入 CASEID 還是 ResumeID
                        if (selectedCategory == "任務職缺置頂")
                        {
                            detail.CaseID = selectedCaseId;
                        }
                        else if (selectedCategory == "專家履歷置頂")
                        {
                            detail.ResumeID = selectedCaseId;
                        }

                        // 將detail物件儲存到資料庫的OrderDetail中
                        dbContext.OrderDetails.Add(detail);
                        orderDetails.Add(detail);
                    } 
                    
                    // 將order物件儲存到資料庫的Order中
                    dbContext.Orders.Add(order);
                    dbContext.SaveChanges();

                    MessageBox.Show("購買成功！", "結帳成功");

                    //購買後更新曝光天數到指定的地方
                    if (comboboxCa.SelectedItem == "任務職缺置頂")
                    {
                        int caseId = (int)comboboxRC.SelectedValue;
                        var taskList = dbContext.TaskLists.FirstOrDefault(t => t.AccountID == CMember.AccountID && t.CaseID == caseId);
                        if (taskList != null)
                        {
                            taskList.OnTop += day;
                        }
                    }
                    else if (comboboxCa.SelectedItem == "專家履歷置頂")
                    {
                        int resumeId = (int)comboboxRC.SelectedValue;
                        var resume = dbContext.Resumes.FirstOrDefault(r => r.AccountID == CMember.AccountID && r.ResumeID == resumeId);
                        if (resume != null)
                        {
                            resume.OnTop += day;
                        }
                    }

                    dbContext.SaveChanges();

                    // 更新會員總點數
                    var memberAccount = dbContext.MemberAccounts.FirstOrDefault(m => m.AccountID == CMember.AccountID);

                    if (memberAccount != null)
                    {
                        memberAccount.MemberTotalPoint -=totalAmount;
                        dbContext.SaveChanges();
                    } 
                    
                    // 清空購物車
                    cartDataTable.Rows.Clear();
                    CalculateTotalAmount();
                    //刷新會員總點數
                    LoadUserPoints();

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

                    string failedProductIDs = string.Join(", ", $"編號為{failedProducts.FirstOrDefault()}");
                    MessageBox.Show($"庫存不足，無法購買以下編號的商品：{failedProductIDs}", "結帳失敗");
                }


            }

        }
    }
}
