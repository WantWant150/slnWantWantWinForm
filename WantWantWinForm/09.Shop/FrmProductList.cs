using Microsoft.Build.Framework.XamlTypes;
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

namespace rjWantWantWinForm
{
    public partial class FrmProductList : Form
    {
        public event Action ProductUpdated;
        public FrmProductList()
        {
            InitializeComponent();
            // 訂閱事件
            ProductUpdated += FrmProductList_ProductUpdated;

        }

        private void FrmProductList_ProductUpdated()
        {
            loadProduct();

        }

        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                int id = (int)(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                // 將ID傳給Update傳給表單
                FrmProductUpdate frmProductUpdate = new FrmProductUpdate();
                frmProductUpdate.ProductListForm = this;
                frmProductUpdate.ProductID = id;
                frmProductUpdate.ShowDialog();
            }

            if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("你確定要刪除此筆資料嗎?", "刪除紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = (int)(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        var product = dbContext.Products.FirstOrDefault(p => p.ProductID == id);

                        if (product != null)
                        {
                            dbContext.Products.Remove(product);
                            dbContext.SaveChanges();

                            loadProduct();

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("由於商品已經有訂單產生，為了後續處理需要，無法進行刪除。\n如果您確定不需要使用該商品，" +
                        "請利用下架功能。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        //新增一個LoadProduct的方法
        int currentCategoryId = 0;
        public void loadProduct()
        {
            try
            {
                dataGridView1.Rows.Clear();

                var q = from n in dbContext.Products
                        where currentCategoryId == 0 || n.CategoryID == currentCategoryId
                        select new
                        {
                            n.ProductID,
                            n.ProductName,
                            Price = (n.CategoryID == 1) ? n.UnitPrice : n.UnitPoint,
                            n.UnitsInStock,
                            n.Status,
                            n.PostStartDate,
                            n.GetPoint,
                            n.Category.CategoryName
                        };

                foreach (var item in q)
                {
                    dataGridView1.Rows.Add(
                        item.ProductID,
                        item.ProductName,
                        item.CategoryName,
                        item.Price,
                        item.UnitsInStock,
                        item.Status,
                        item.PostStartDate
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("載入商品失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            loadProduct();
            LoadCategory();
            LoadStatus();
        }


        private void btnSerch_Click(object sender, EventArgs e)
        {
            if (txtSerch.Text != "")
            {
                //模糊查詢 都轉成轉成小寫
                dataGridView1.Rows.Clear();
                var q = from n in dbContext.Products
                        where n.ProductName.ToLower().Contains(txtSerch.Text.ToLower()) &&
                            (currentCategoryId == 0 || n.CategoryID == currentCategoryId)
                        select new
                        {
                            n.ProductID,
                            n.ProductName,
                            Price = (n.CategoryID == 1) ? n.UnitPrice : n.UnitPoint,
                            n.UnitsInStock,
                            n.Status,
                            n.PostStartDate,
                            n.GetPoint,
                            n.Category.CategoryName
                        };

                foreach (var item in q)
                {
                    dataGridView1.Rows.Add(
                        item.ProductID,
                        item.ProductName,
                        item.CategoryName,
                        item.Price,
                        item.UnitsInStock,
                        item.Status,
                        item.PostStartDate
                    );
                }
            }
            else
            {
                loadProduct();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            frm.ProductListForm = this; // 將 FrmProductList 的g给 FrmProduct 的 ProductListForm 屬性
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentCategoryId = 0;
            loadProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentCategoryId = 1;
            loadProduct();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentCategoryId = 2;
            loadProduct();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentCategoryId = 0;
            loadProduct();
        }

        private void LoadCategory()
        {
            var q = from c in dbContext.Categories
                    select c.CategoryName;
            this.coboCA.DataSource = q.Distinct().ToList();
            this.coboCA.SelectedIndex = 0;

        }

        private void btnCaSerch(object sender, EventArgs e)
        {
            if (coboCA.SelectedIndex == 0)
            {
                currentCategoryId = 1;
                loadProduct();
            }

            if (coboCA.SelectedIndex == 1)
            {
                currentCategoryId = 2;
                loadProduct();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadProduct();
            if (coboSta.Text == "上架")
            {
                SerchStatus("上架");
            }
            if (coboSta.Text == "下架")
            {
                SerchStatus("下架");
            }

        }

        private void LoadStatus()
        {
            var q = from p in dbContext.Products
                    select p.Status;
            this.coboSta.DataSource = q.Distinct().ToList();
            this.coboSta.SelectedIndex = 0;

        }
        private void SerchStatus(string s)
        {
            dataGridView1.Rows.Clear();
            var q = from p in dbContext.Products
                    where p.Status == s
                    select new
                    {
                        p.ProductID,
                        p.ProductName,
                        Price = (p.CategoryID == 1) ? p.UnitPrice : p.UnitPoint,
                        p.UnitsInStock,
                        p.Status,
                        p.PostStartDate,
                        p.GetPoint,
                        p.Category.CategoryName
                    };

            foreach (var item in q)
            {
                dataGridView1.Rows.Add(
                    item.ProductID,
                    item.ProductName,
                    item.CategoryName,
                    item.Price,
                    item.UnitsInStock,
                    item.Status,
                    item.PostStartDate
                );
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                int unitsInStock1 = int.Parse(textBox1.Text);
                int unitsInStock2 = int.Parse(textBox2.Text);

                var q = from p in dbContext.Products
                        where p.UnitsInStock > unitsInStock1 && p.UnitsInStock < unitsInStock2
                        select new
                        {
                            p.ProductID,
                            p.ProductName,
                            Price = (p.CategoryID == 1) ? p.UnitPrice : p.UnitPoint,
                            p.UnitsInStock,
                            p.Status,
                            p.PostStartDate,
                            p.GetPoint,
                            p.Category.CategoryName
                        };

                foreach (var item in q)
                {
                    dataGridView1.Rows.Add(
                        item.ProductID,
                        item.ProductName,
                        item.CategoryName,
                        item.Price,
                        item.UnitsInStock,
                        item.Status,
                        item.PostStartDate
                    );
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentCategoryId = 0;
            loadProduct();
            dataGridView1.Rows.Clear();
            DateTime d = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1);

            var q = from p in dbContext.Products
                    where p.PostStartDate >= d && p.PostStartDate <= d2
                    select new
                    {
                        p.ProductID,
                        p.ProductName,
                        Price = (p.CategoryID == 1) ? p.UnitPrice : p.UnitPoint,
                        p.UnitsInStock,
                        p.Status,
                        p.PostStartDate,
                        p.GetPoint,
                        p.Category.CategoryName
                    };

            foreach (var item in q)
            {
                dataGridView1.Rows.Add(
                    item.ProductID,
                    item.ProductName,
                    item.CategoryName,
                    item.Price,
                    item.UnitsInStock,
                    item.Status,
                    item.PostStartDate
                );
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
