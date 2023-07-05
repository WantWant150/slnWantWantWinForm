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
    public partial class Frm_ForumEnterCategory : Form
    {
        //共用的各種參數區
        private Frm_ForumEnterCategory currentForumEnterCategory;

        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        private string selectedCategoryTitle;//還沒想到會不會在建構函式外用到，先宣告起來放，如果不用的話下面的建構函式的參數可以直接代入
        private int selectedCategoryId;

        //因為main的splitContainer1.Panel2保護層級限制不能直接在這對他做設定，所以要用委派定義點擊文章標題時的動作
        //使用委派是一種解決保護層級限制的方式，它允許不同層級的表單進行通信和操作
        public Action<string> OnPostTitleClick { get; set; }//這邊是定義委派(Action<string>是委派)給他名稱OnPostTitleClick 為了開啟Frm_ForumTopic
                                                            //這個委派方法接受一個string參數，並且沒有返回值
        public Action<Form> OnCreatePostFormOpen { get; set; }//為了開啟Frm_CreatePost


        public Frm_ForumEnterCategory()
        {
            InitializeComponent();
        }

        public Frm_ForumEnterCategory(string selectTitle, int selectCategoryId)
        {
            InitializeComponent();

            selectedCategoryTitle = selectTitle;
            selectedCategoryId = selectCategoryId;//這兩個不一定會用到，先宣告起來放而已

            this.Text = selectTitle;//所以這邊也可以直接用建構函式的selectTitle來代入，不用另外宣告類別參數來存(如果外面都沒要用的話)
            labShow_CategoryTitle.Text =$":::{selectedCategoryTitle}:::";

            //選擇對應的討論區，並且不顯示非父文章的回文、不是發文狀態的貼文也不顯示
            var posts = from p in dbContext.ForumPosts
                        where p.ForumPostCategories.Any(pc => pc.CategoryID == selectedCategoryId) && p.ParentID == null && p.Status == 1
                        select new
                        {
                            p.Title,
                            p.MemberAccount.UserName,
                            ParentIDCount = dbContext.ForumPostComments.Count(fp => fp.PostID == p.PostID)//抓取回文的數量
                        };


            foreach (var post in posts)
            {
                // 建立顯示文章主題的 Label
                Label lblPostTitle = new Label();
                lblPostTitle.AutoSize = true;
                lblPostTitle.Margin = new Padding(5);
                lblPostTitle.Text = post.Title;
                lblPostTitle.Click += lblPostTitle_Click;

                // 建立顯示作者的 Label
                Label lblPostAuthor = new Label();
                lblPostAuthor.AutoSize = true;
                lblPostAuthor.Margin = new Padding(5);
                lblPostAuthor.Text = post.UserName.ToString();

                // 建立顯示回覆數的 Label
                Label lblReplyCount = new Label();
                lblReplyCount.AutoSize = true;
                lblReplyCount.Margin = new Padding(5);
                lblReplyCount.Text = post.ParentIDCount.ToString();

                // 將項目加入 TableLayoutPanel
                tableLayoutPanel1.RowCount++;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableLayoutPanel1.Controls.Add(lblPostTitle, 0, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(lblPostAuthor, 1, tableLayoutPanel1.RowCount - 1);
                tableLayoutPanel1.Controls.Add(lblReplyCount, 2, tableLayoutPanel1.RowCount - 1);
            }
        }

        //進入PO文的label點擊事件
        private void lblPostTitle_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;//確定是哪個標題標籤按進來的
            string selectedPostTitle = clickedLabel.Text;

            OnPostTitleClick?.Invoke(selectedPostTitle);//使用委派方法 ?.確保OnPostTitleClick不為null，避免NullReferenceException的發生
        }


        //發文按鈕
        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            Frm_CreatePost createPostForm = new Frm_CreatePost(selectedCategoryId);//代入參數
            createPostForm.TopLevel = false;
            createPostForm.Dock = DockStyle.Fill;
            OnCreatePostFormOpen?.Invoke(createPostForm);
        }


    }
}
