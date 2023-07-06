using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjWantWantWinForm
{
    public partial class FrmProduct : Form
    {
        public FrmProductList ProductListForm { get; set; }
        public FrmProduct()
        {
            InitializeComponent();

        }
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var q = from c in dbContext.Categories
                    select c.CategoryName;
            this.comboBoxCategory.DataSource = q.Distinct().ToList();
            this.comboBoxCategory.SelectedIndex = 0;
            this.comboBoxStatus.SelectedIndex = 0;
        }
        // 儲存圖片的二進位資料
        byte[] imageBytes = null;
        private void button2_Click(object sender, EventArgs e)
        {
            if (picboxPro.Image == null)
            {
                MessageBox.Show("請選擇商品圖片", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 終止新增操作
            }

            if (string.IsNullOrEmpty(txtName.Text) ||
        string.IsNullOrEmpty(comboBoxCategory.Text) ||
        string.IsNullOrEmpty(txtDesc.Text) ||
        string.IsNullOrEmpty(comboBoxStatus.Text) ||
        string.IsNullOrEmpty(txtPrice.Text) ||
            string.IsNullOrEmpty(txtCount.Text)

        )        
            {
                MessageBox.Show("所有欄位都為必填，尚有疏漏，請檢查。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 終止新增操作
            }
           
            //變數
            string name = txtName.Text;
            string Category = comboBoxCategory.Text;
            string TopType = comboBox1.Text;
            bool isTopdateValid = int.TryParse(comboBox2.Text, out int topDate);
            string desc = txtDesc.Text;
            string status = comboBoxStatus.Text;
            DateTime dateTimeStart = DateTime.Now;
            DateTime dateTimeEnd = DateTime.MaxValue;
            int price;
            bool isPriceValid = int.TryParse(txtPrice.Text, out price);
            if (!isPriceValid)
            {
                MessageBox.Show("請輸入有效價格。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int stock;
            bool isStockValid = int.TryParse(txtCount.Text, out stock);
            if (!isStockValid)
            {
                MessageBox.Show("請輸入有效庫存。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int getpoint;
            bool isGetPoint = int.TryParse(txtGetPoint.Text, out getpoint);
            if (!isGetPoint && comboBox2.Visible != true)
            {
                MessageBox.Show("請輸入有效點數。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var category = dbContext.Categories.FirstOrDefault(c => c.CategoryName == Category);
            // 如果選擇的Category是"點數商品"
            if (category != null && category.CategoryName == "點數商品")
            {

                if (comboBox2.SelectedIndex == -1 || comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("點數商品請填選擇曝光管道與天數", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // 終止新增操作
                }
            }
            else if (string.IsNullOrEmpty(txtGetPoint.Text))
            {
                MessageBox.Show("請填寫此商品可獲得幾點", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // 终止新增操作
            }

            //從選擇的Category選的名字轉成ID
            var q = from c in dbContext.Categories
                    where c.CategoryName == Category
                    select c.CategoryID;
            int categoryId = q.FirstOrDefault();

            //判斷刊登結束時間
            switch (status)
            {
                case "上架":
                    // 不需要設定 dateTimeEnd，預設為 DateTime.MaxValue
                    break;
                case "下架":
                    dateTimeEnd = DateTime.Now;
                    break;
            }
  

            bool isDataExists = dbContext.Products.Any(p => p.ProductName == name);

            if (isDataExists)
            {
                // 商品名已存在，顯示警告訊息
                MessageBox.Show("該商品已存在，無法新增重複資料，請重新檢查。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // 商品名不存在，執行新增操作
                Product product = new Product
                {
                    ProductName = name,
                    CategoryID = categoryId,
                    ProductDesc = desc,
                    UnitsInStock = stock,
                    Status = status,
                    PostStartDate = dateTimeStart,
                    PostEndDate = dateTimeEnd,
                    CoverPhoto = imageBytes,
                    TopDate = topDate,
                    TopType = TopType,
                    GetPoint = getpoint

                };
                //如果是產品是花費點數就紀錄點數，如果是產品是現金就是紀錄現金
                if (categoryId == 1)
                {
                    product.UnitPrice = price;
                }
                
                else 
                {
                    product.UnitPoint= price;
                }
                this.dbContext.Products.Add(product);
                this.dbContext.SaveChanges();             
                MessageBox.Show("商品新增成功");

                ProductListForm.loadProduct();
                this.Close();
         
            }
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.picboxPro.Image = Image.FromFile(this.openFileDialog1.FileName);

                Image selectedImage = Image.FromFile(this.openFileDialog1.FileName);

                // 將圖片轉換為二進位資料
                using (MemoryStream ms = new MemoryStream())
                {
                    selectedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // 根據需要指定圖片格式
                    imageBytes = ms.ToArray();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           //商品類別選擇點數商品後新增曝光管道和天數
            if (comboBoxCategory.SelectedIndex == 1)
            {
                comboBox2.Visible = true;
                comboBox1.Visible = true;
                labDate.Visible = true;
                labToptype.Visible = true;
                txtGetPoint.Visible = false;
                labPoint.Visible = false;
                txtGetPoint.Text= null;
            }
            else
            {
                comboBox2.Visible = false;
                comboBox2.SelectedIndex = -1;
                comboBox1.Visible = false;
                comboBox1.SelectedIndex = -1;
                labDate.Visible = false;
                labToptype.Visible = false;
                labPoint.Visible = true;
                txtGetPoint.Visible = true;
            }
           
        }

      
    }
}
