using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsMidSora
{
    public partial class Frm_ForumTopic : Form
    {
        int loggedInUserID = CMember.AccountID;


        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        private string selectedPostTitle;
        private int thisPostID;
        public event Action OnGoBack;


        public Frm_ForumTopic()
        {
            InitializeComponent();
        }

        public Frm_ForumTopic(string selectPostTitle)
        {
            InitializeComponent();//不要忘記初始化，沒有初始化就是空白表單
            this.selectedPostTitle = selectPostTitle;

            loadFirstFloor();
        }

        private void loadFirstFloor()
        {
            var q = from p in dbContext.ForumPosts
                    where p.Title == selectedPostTitle
                    select p;

            labShowTitle.Text = selectedPostTitle;
            labAuthorName.Text = $"作者: {q.FirstOrDefault()?.MemberAccount.UserName}";
            labPostTime.Text = $"發表時間: {q.FirstOrDefault()?.Created}";
            rtxtFirstFloorContext.Text = q.FirstOrDefault()?.PostContent;
            thisPostID = (int)q.FirstOrDefault()?.PostID;

            //q2選comment，ID為本篇PO文

            rtxtFirstReply.Clear();


            var q2 = from p in dbContext.ForumPostComments.Include("MemberAccount")//這邊還不太懂為什麼使用Include就不會有使用者如果是第一次留言重讀頁面時會出錯的問題
                     where p.PostID == thisPostID &&p.Status==1 //只顯示已發布，不顯示刪除
                     select p;


            if (q2.Any())//Any()是用來檢查是否包含任何元素
            {
                try
                {
                    foreach (var c in q2)
                    {
                        rtxtFirstReply.Text += $"{c.MemberAccount.UserName}\t發表時間:{c.Created:yyyy/MM/dd HH:mm}\n" +
                            $"{c.Comment}\n" +
                            $"-----------------------------------------------------------------------------------------------------------------------\n";
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                rtxtFirstReply.Text = "尚未有回覆喔";
            }



        }

        //設置上一頁按鈕委派功能
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            OnGoBack?.Invoke();
            this.Refresh();

        }

        bool reply = true;//回覆留言開關
        private void btnReplyComment_Click(object sender, EventArgs e)
        {
            panelReplyComment.Visible = reply;
            reply = !reply;
        }

        private void btnReplyCommentOK_Click(object sender, EventArgs e)
        {
            string comment = this.txtReplyComment.Text;

            if (string.IsNullOrEmpty(txtReplyComment.Text))
            {
                MessageBox.Show("請輸入回覆", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { 
            ForumPostComment newReplyComment = new ForumPostComment
            {
                PostID = thisPostID,
                AccountID = loggedInUserID,
                Comment = comment,
                Created = DateTime.Now,
                Status = 1
            };

            dbContext.ForumPostComments.Add(newReplyComment);
            dbContext.SaveChanges();

            MessageBox.Show("留言成功");
            this.txtReplyComment.Text = "";
            loadFirstFloor();
            this.panelReplyComment.Visible = false;
            if (reply != true)
            {
                reply = true;
            }
            }
        }
    }
}
