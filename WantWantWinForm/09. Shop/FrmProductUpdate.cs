using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prjShop
{
    public partial class FrmProductUpdate : Form
    {
        //從ProductList 接ID過來
        public int ProductID { get; set; }
        public FrmProductList ProductListForm { get; set; }

        public FrmProductUpdate()
        {
            InitializeComponent();

        }
        //用於追蹤是否有修改圖片。
        private bool isImageModified = false;

        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        byte[] imageBytes = null;
        private void FrmProductUpdate_Load(object sender, EventArgs e)
        {

            var product = dbContext.Products.FirstOrDefault(p => p.ProductID == ProductID);
            byte[] imageBytes = product.CoverPhoto;
            Image image;

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                image = Image.FromStream(ms);
            }
            picboxPro.Image = image;

            txtName.Text = product.ProductName;
            txtDesc.Text = product.ProductDesc;
            comboBoxStatus.Text = product.Status;
            txtCount.Text = product.UnitsInStock.ToString();
            txtGetPoint.Text = product.GetPoint.ToString();

            var q = from c in dbContext.Categories
                    select c.CategoryName;
            this.comboBoxCategory.DataSource = q.Distinct().ToList();
            comboBoxCategory.Text = product.Category.CategoryName;
            comboBox1.Text = product.TopType;
            comboBox2.Text = product.TopDate.ToString();

            // 使用三元判斷價格要用UnitPrice 或是UnitPoint
            txtPrice.Text = (product.Category.CategoryID == 1) ? product.UnitPrice.ToString() : product.UnitPoint.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string Category = comboBoxCategory.Text;
            string desc = txtDesc.Text;
            string status = comboBoxStatus.Text;       
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

            // 從Category選的名字轉成ID
            var q = from c in dbContext.Categories
                    where c.CategoryName == Category
                    select c.CategoryID;
            int categoryId = q.FirstOrDefault();

            // 檢查欄位是否為必填
            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(comboBoxCategory.Text) ||
                string.IsNullOrEmpty(txtDesc.Text) ||
                string.IsNullOrEmpty(comboBoxStatus.Text) ||
                string.IsNullOrEmpty(txtPrice.Text) ||
                string.IsNullOrEmpty(txtCount.Text))
            {
                MessageBox.Show("所有欄位都為必填，尚有疏漏，請檢查。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var category = dbContext.Categories.FirstOrDefault(c => c.CategoryName == Category);
            if (category != null && category.CategoryName == "點數商品")
            {
                // 如果選擇的Category是"點數"
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
            // 從資料庫中找到要修改的商品
            var product = dbContext.Products.FirstOrDefault(p => p.ProductID == ProductID);

            if (product != null)
            {
                // 檢查新的 ProductName 是否需要進行重複檢查
                if (txtName.Text != product.ProductName)
                {
                    // 檢查新的 ProductName 是否與其他現有商品的名稱重複
                    bool isDuplicateName = dbContext.Products.Any(p => p.ProductID != ProductID && p.ProductName == txtName.Text);
                    if (isDuplicateName)
                    {
                        MessageBox.Show("商品名稱已存在，請輸入不同的名稱。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 更新商品資料
                product.ProductName = name;
                product.ProductDesc = desc;
                product.Status = status;
                product.CategoryID = categoryId;
                product.GetPoint = getpoint;
                product.UnitsInStock = stock;

                if (isImageModified)
                {
                    product.CoverPhoto = imageBytes;
                }

                if (categoryId == 1)
                {
                    product.UnitPrice = price;
                }
                
                else 
                {
                    product.UnitPoint = price;
                }

                // 保存修改
                dbContext.SaveChanges();
                MessageBox.Show("商品修改成功");
                ProductListForm?.loadProduct();
                FrmProductList frmProductList = Application.OpenForms["FrmProductList"] as FrmProductList;
            

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.picboxPro.Image = Image.FromFile(this.openFileDialog1.FileName);
                isImageModified = true;
                Image selectedImage = Image.FromFile(this.openFileDialog1.FileName);

                // 將圖片轉換為二進位資料
                using (MemoryStream ms = new MemoryStream())
                {
                    // 根據需要指定圖片格式
                    selectedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("你確定要刪除此筆資料嗎?", "刪除紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var product = dbContext.Products.FirstOrDefault(p => p.ProductID == ProductID);

                    if (product != null)
                    {
                        dbContext.Products.Remove(product);
                        dbContext.SaveChanges();
                    }
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ProductListForm?.loadProduct();
           
            this.Close();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex == 1)
            {
                comboBox2.Visible = true;
                comboBox1.Visible = true;
                labDate.Visible = true;
                labToptype.Visible = true;
                txtGetPoint.Visible = false;
                labPoint.Visible = false;
                txtGetPoint.Text = null;
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

