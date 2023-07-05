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
    public partial class Frm_CreatePost : Form
    {
        int loggedInUserID = CMember.AccountID;

        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        private int categoryID; // 存CategoryID變數

        public Frm_CreatePost()
        {
            InitializeComponent();
        }

        public Frm_CreatePost(int categoryID)
        {
            InitializeComponent();
            this.categoryID = categoryID;
            LoadCategory();
        }

        private void LoadCategory()
        {
            var q=from p in dbContext.ForumCategories
                  where p.CategoryID == categoryID
                  select p;
            labShowNowCategory.Text = $"您目前在討論區:::{q.FirstOrDefault().Title.ToString()}:::"; //有成功傳數值進來了
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"確定取消嗎?確定即關閉此頁面", "取消?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }



        private void btnSendPost_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string content = txtContent.Text;


            if (!(string.IsNullOrEmpty(txtTitle.Text)) && (!string.IsNullOrEmpty(txtContent.Text)))
            {
                //先存ForumPost的資料
                ForumPost newPost = new ForumPost
                {
                    AccountID = loggedInUserID,
                    Title = title,
                    PostContent = content,
                    Created = DateTime.Now,
                    Status = 1
                };

                dbContext.ForumPosts.Add(newPost);
                dbContext.SaveChanges();



                int postID = newPost.PostID;

                //再抓取PostID存入
                ForumPostCategory newPostCategory = new ForumPostCategory
                {
                    CategoryID = categoryID,
                    PostID = postID
                };
                dbContext.ForumPostCategories.Add(newPostCategory);
                dbContext.SaveChanges();

                MessageBox.Show("發表成功!將關閉此頁");

                this.Dispose();
            }
            else
            {
                MessageBox.Show("有欄位沒有填寫喔~", "錯誤",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnSaveDraft_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string content = txtContent.Text;

            if (!(string.IsNullOrEmpty(txtTitle.Text)) && (!string.IsNullOrEmpty(txtContent.Text)))
            {
                //先存ForumPost的資料
                ForumPost newPost = new ForumPost
            {
                AccountID = loggedInUserID,
                Title = title,
                PostContent = content,
                Created = DateTime.Now,
                Status = 2
            };

            dbContext.ForumPosts.Add(newPost);
            dbContext.SaveChanges();



            int postID = newPost.PostID;

            //再抓取PostID存入
            ForumPostCategory newPostCategory = new ForumPostCategory
            {
                CategoryID = categoryID,
                PostID = postID
            };
            dbContext.ForumPostCategories.Add(newPostCategory);
            dbContext.SaveChanges();

            MessageBox.Show("草稿儲存成功!將關閉此頁");

            this.Dispose();
            }
            else
            {
                MessageBox.Show("有欄位沒有填寫喔~", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
