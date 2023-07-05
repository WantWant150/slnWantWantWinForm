using Microsoft.Build.Framework.XamlTypes;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace prjWantWantWinForm._08.Forum
{
    public partial class Frm_EditPost : Form
    {
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        private int postID;


        public Frm_EditPost()
        {
            InitializeComponent();
        }

        public Frm_EditPost(int _postID)
        {
            InitializeComponent();
            postID = _postID;
            loadEditPost();
        }

        private void loadEditPost()
        {
            var q=from p in dbContext.ForumPosts
                  where p.PostID == postID
                  select new { p.Title,p.PostContent,p.Status,p.ForumPostCategories.FirstOrDefault().ForumCategory};
                

            labShowNowCategory.Text = $"您目前在討論區:::{q.FirstOrDefault().ForumCategory.Title}:::";
            txtTitle.Text = q.FirstOrDefault().Title;
            txtContent.Text = q.FirstOrDefault().PostContent;
        }

        private void btnSendPost_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string content = txtContent.Text;

            if (!(string.IsNullOrEmpty(txtTitle.Text)) && (!string.IsNullOrEmpty(txtContent.Text)))
            {
                    var editPost = from p in dbContext.ForumPosts
                                 where p.PostID == postID
                                 select p;

                editPost.FirstOrDefault().Title = title;
                editPost.FirstOrDefault().PostContent = content;
                editPost.FirstOrDefault().Updated= DateTime.Now;
                editPost.FirstOrDefault().Status = 1;

                dbContext.SaveChanges();

                MessageBox.Show("發表成功!");
            }
            else
            {
                MessageBox.Show("有欄位沒有填寫喔~", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveDraft_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string content = txtContent.Text;

            if (!(string.IsNullOrEmpty(txtTitle.Text)) && (!string.IsNullOrEmpty(txtContent.Text)))
            {
                var editPost = from p in dbContext.ForumPosts
                               where p.PostID == postID
                               select p;

                if (editPost.FirstOrDefault().Status == 1) 
                {
                    MessageBox.Show("已發布文章不可儲存為草稿");
                }
                else
                {
                    editPost.FirstOrDefault().Title = title;
                    editPost.FirstOrDefault().PostContent = content;
                    editPost.FirstOrDefault().Updated = DateTime.Now;
                    editPost.FirstOrDefault().Status = 2;

                    dbContext.SaveChanges();

                    MessageBox.Show("儲存成功");
                }
                

            }
            else
            {
                MessageBox.Show("有欄位沒有填寫喔~", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
