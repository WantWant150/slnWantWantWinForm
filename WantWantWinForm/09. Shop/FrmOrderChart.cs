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
using System.Windows.Forms.DataVisualization.Charting;

namespace prjWantWantWinForm
{
   
    public partial class FrmOrderChart : Form
    {
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        public FrmOrderChart()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.Columns.Clear();

            int memberId = Convert.ToInt32(comboboxID.SelectedValue);

            var orders = from o in dbContext.Orders
                         where o.AccountID == memberId
                         select new
                         {
                             訂單編號 = o.OrderID,
                             訂單類別 = o.Category.CategoryName,
                             總金額或點數 = (o.CategoryID == 1) ? o.OrderPrice : o.OrderUsePoint,
                             付款方式 = o.PayWay.PayWayName,
                             購買日期 = o.CreateTime
                         };

            dataGridView2.DataSource = orders.ToList();
        }

        private void FrmOrderChart_Load(object sender, EventArgs e)
        {
            //載入會員
            var q = from m in dbContext.MemberAccounts
                    select new { 編號 = m.AccountID, 名稱 ="編號:"+ m.AccountID + " - " + m.Name };
            this.comboboxID.DataSource = q.ToList();
            this.comboboxID.DisplayMember = "名稱";  // 顯示編號和名稱
            this.comboboxID.ValueMember = "編號";    // 儲存編號
            this.comboboxID.SelectedIndex = 0;

            //載入訂單編號
            var q2 = from o in dbContext.Orders
                    select o.OrderID ;
            this.comboBox1.DataSource = q2.ToList();
            
            //載入類別
            var q3 = from c in dbContext.Categories
                    select c.CategoryName;
            this.comboBox2.DataSource = q3.Distinct().ToList();
            this.comboBox2.SelectedIndex = 0;

            //載入商品
            var q4 =from p in dbContext.Products
                    select p.ProductName;
            this.comboBox3.DataSource= q4.Distinct().ToList();
            this.comboBox3.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.Columns.Clear();
            int orderId = Convert.ToInt32(comboBox1.SelectedValue);

            var orders = from o in dbContext.Orders
                         where o.OrderID == orderId
                         select new
                         {
                             訂單編號 = o.OrderID,
                             訂單類別 = o.Category.CategoryName,
                             總金額或點數 = (o.CategoryID == 1) ? o.OrderPrice : o.OrderUsePoint,
                             付款方式 = o.PayWay.PayWayName,
                             購買日期 = o.CreateTime
                         };

            dataGridView2.DataSource = orders.OrderBy(o => o.訂單編號).ToList();
            var orderDetails = from od in dbContext.OrderDetails
                               where od.OrderID == orderId
                               select new
                               {
                                   產品名稱 = od.Product.ProductName,
                                   數量 = od.Quantity,
                                   單價or點數 = (od.Order.CategoryID == 1) ? od.UnitPrice : od.UnitPoint,
                                   獲得點數 = od.GetPoint,
                                   總價 = (od.Order.CategoryID == 1) ? od.UnitPrice * od.Quantity : od.UnitPoint * od.Quantity,
                               };

            dataGridView1.DataSource = orderDetails.OrderBy(od => od.產品名稱).ToList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int orderId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["訂單編號"].Value);
                LoadOrderDetails(orderId);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            var q =from o in dbContext.Orders
                    select new
                   {
                        訂單編號 = o.OrderID,
                        訂單類別 = o.Category.CategoryName,
                        總金額或點數 = (o.CategoryID == 1) ? o.OrderPrice : o.OrderUsePoint,
                        付款方式 = o.PayWay.PayWayName,
                        購買日期 = o.CreateTime
                    };
            dataGridView2.DataSource =q.ToList();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            string selectedCategory = comboBox2.SelectedItem.ToString();

            var orderDetails = from od in dbContext.OrderDetails
                               where od.Order.Category.CategoryName == selectedCategory
                               select new
                               {
                                   產品名稱 = od.Product.ProductName,
                                   數量 = od.Quantity,
                                   單價or點數 = (od.Order.CategoryID == 1) ? od.UnitPrice : od.UnitPoint,
                                   獲得點數 = od.GetPoint,
                                   總價 = (od.Order.CategoryID == 1) ? od.UnitPrice * od.Quantity : od.UnitPoint * od.Quantity,
                               };

            dataGridView2.DataSource = orderDetails.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var q = dbContext.OrderDetails.ToList();

            var q2 = q.GroupBy(od => od.Product.ProductName)
                        .Select(g => new
                        {
                            產品名稱 = g.Key,
                            銷量 = g.Sum(od => od.Quantity)
                        }).ToList();

            this.chart1.Series.Clear(); // 清除原有的資料序列

            this.chart1.DataSource = q2.ToList();
            this.chart1.Series.Add("銷量"); // 新增銷量的資料序列
            this.chart1.Series[0].XValueMember = "產品名稱";
            this.chart1.Series[0].YValueMembers = "銷量";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            this.chart1.Series[0].BorderWidth = 4;
            this.chart1.Series[0].ToolTip = "銷量: #VALY\n百分比: #PERCENT";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var q = dbContext.OrderDetails.ToList();

            var q2 = q.GroupBy(od => od.Product.ProductName)
                        .Select(g => new
                        {
                            產品名稱 = g.Key.Substring(0, Math.Min(6, g.Key.Length)), // 只取前6個字
                            銷量 = (double)g.Sum(od => od.Quantity),
                            銷售額 = (double)g.Sum(od => od.Quantity * od.UnitPrice) // 計算銷售額
                        }).ToList();

            this.chart1.Series.Clear(); // 清除原有的資料序列

            this.chart1.DataSource = q2.ToList();
            this.chart1.Series.Add("銷量"); // 新增銷量的資料序列
            this.chart1.Series[0].XValueMember = "產品名稱";
            this.chart1.Series[0].YValueMembers = "銷量";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[0].BorderWidth = 4;

            this.chart1.Series.Add("銷售額"); // 新增銷售額的資料序列
            this.chart1.Series[1].XValueMember = "產品名稱";
            this.chart1.Series[1].YValueMembers = "銷售額";
            this.chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chart1.Series[1].BorderWidth = 4;

            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1); // 將結束日期調整為當天的最後一秒

            var orderDetails = dbContext.OrderDetails
                .Where(od => od.Order.CreateTime >= startDate && od.Order.CreateTime <= endDate)
                .ToList();

            var salesData = orderDetails
                .GroupBy(od => od.Order.CreateTime.Value.Date)
                .Select(g => new
                {
                    日期 = g.Key,
                    銷售量 = g.Sum(od => od.Quantity),
                    銷售額 = g.Sum(od => od.Quantity * od.UnitPrice)
                })
                .ToList();

            // 清除圖表的數據
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // 新增一個圖表區域
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // 新增一個系列用於表示銷售量
            Series series1 = new Series();
            series1.Name = "銷售量";
            series1.ChartType = SeriesChartType.Line;
            series1.XValueType = ChartValueType.Date;
            chart1.Series.Add(series1);

            // 新增一個系列用於表示銷售額
            Series series2 = new Series();
            series2.Name = "銷售額";
            series2.ChartType = SeriesChartType.Line;
            series2.XValueType = ChartValueType.Date;
            chart1.Series.Add(series2);

            // 將銷售量和銷售額的數據加入到相應的系列中
            foreach (var data in salesData)
            {
                if (data.銷售量 != 0)
                {
                    series1.Points.AddXY(data.日期, data.銷售量);
                }

                if (data.銷售額 != 0)
                {
                    series2.Points.AddXY(data.日期, data.銷售額);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string selectedProduct = comboBox3.SelectedItem.ToString();
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1); // 將結束日期調整為當天的最後一秒

            var orderDetails = dbContext.OrderDetails
                .Where(od => od.Order.CreateTime >= startDate && od.Order.CreateTime <= endDate &&
                             od.Product.ProductName == selectedProduct)
                .ToList();

            var salesData = orderDetails
                .GroupBy(od => od.Order.CreateTime.Value.Date)
                .Select(g => new
                {
                    日期 = g.Key,
                    銷售量 = g.Sum(od => od.Quantity),
                    銷售額 = g.Sum(od => od.Quantity * od.UnitPrice)
                })
                .ToList();

            // 清除圖表的數據
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // 新增一個圖表區域
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // 新增一個系列用於表示銷售量
            Series series1 = new Series();
            series1.Name = "銷售量";
            series1.ChartType = SeriesChartType.Line;
            series1.XValueType = ChartValueType.Date;
            chart1.Series.Add(series1);

            // 新增一個系列用於表示銷售額
            Series series2 = new Series();
            series2.Name = "銷售額";
            series2.ChartType = SeriesChartType.Line;
            series2.XValueType = ChartValueType.Date;
            chart1.Series.Add(series2);

            // 將銷售量和銷售額的數據加入到相應的系列中
            foreach (var data in salesData)
            {
                series1.Points.AddXY(data.日期, data.銷售量);
                series2.Points.AddXY(data.日期, data.銷售額);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string selectedProduct = comboBox3.SelectedItem.ToString();

            var orderDetails = dbContext.OrderDetails
                .Where(od => od.Product.ProductName == selectedProduct)
                .ToList();

            var salesData = orderDetails
                .GroupBy(od => od.Order.CreateTime.Value.Date)
                .Select(g => new
                {
                    日期 = g.Key,
                    銷售量 = g.Sum(od => od.Quantity),
                    銷售額 = g.Sum(od => od.Quantity * od.UnitPrice)
                })
                .ToList();

            // 清除圖表的數據
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // 新增一個圖表區域
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // 新增一個系列用於表示銷售量
            Series series1 = new Series();
            series1.Name = "銷售量";
            series1.ChartType = SeriesChartType.Column; // 將圖表類型改為柱狀圖
            series1.XValueType = ChartValueType.Date;
            chart1.Series.Add(series1);

            // 新增一個系列用於表示銷售額
            Series series2 = new Series();
            series2.Name = "銷售額";
            series2.ChartType = SeriesChartType.Column; // 將圖表類型改為柱狀圖
            series2.XValueType = ChartValueType.Date;
            chart1.Series.Add(series2);

            // 將銷售量和銷售額的數據加入到相應的系列中
            foreach (var data in salesData)
            {
                series1.Points.AddXY(data.日期, data.銷售量);
                series2.Points.AddXY(data.日期, data.銷售額);
            }
        }
        }
    }

