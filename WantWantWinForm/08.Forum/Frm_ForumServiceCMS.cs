using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm._08.Forum
{
    public partial class Frm_ForumServiceCMS : Form
    {
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        int nowMode = -1;//追蹤目前模式

        public Frm_ForumServiceCMS()
        {
            InitializeComponent();
        }

        private void btnModifyPost_Click(object sender, EventArgs e)
        {
            nowMode = 1;
            LoadPost();

        }

        private void LoadPost()
        {
            var q = from p in dbContext.ForumPosts
                    select new
                    {
                        發文編號 = p.PostID,
                        發文者ID = p.AccountID,
                        發文者暱稱 = p.MemberAccount.UserName,
                        發文標題 = p.Title,
                        發文內容 = p.PostContent,
                        發文時間 = p.Created,
                        發文更新時間 = p.Updated,
                        發文狀態 = p.ForumStatu.StatusName
                    };
            this.dataGridViewMGR.DataSource = q.ToList();
            this.dataGridViewMGR.Columns["發文標題"].Width = 250;
            this.dataGridViewMGR.Columns["發文內容"].Width = 450;
            this.dataGridViewMGR.Columns["btnDelete"].Visible = true;
            this.dataGridViewMGR.Columns["btnPublished"].Visible = true;
            this.dataGridViewMGR.Columns["btnIsVisible"].Visible = false;
        }

        private void btnCommentMGR_Click(object sender, EventArgs e)
        {
            nowMode = 2;
            LoadComment();

        }

        private void LoadComment()
        {
            var q = from p in dbContext.ForumPostComments
                    select new
                    {
                        留言編號 = p.PostCommentID,
                        留言者ID = p.AccountID,
                        留言者暱稱 = p.MemberAccount.UserName,
                        留言內容 = p.Comment,
                        留言時間 = p.Created,
                        留言更新時間 = p.Updated,
                        留言狀態 = p.ForumStatu.StatusName
                    };
            this.dataGridViewMGR.DataSource = q.ToList();
            this.dataGridViewMGR.Columns["留言內容"].Width = 450;
            this.dataGridViewMGR.Columns["btnDelete"].Visible = true;
            this.dataGridViewMGR.Columns["btnPublished"].Visible = true;
            this.dataGridViewMGR.Columns["btnIsVisible"].Visible = false;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            nowMode = 3;
            LoadCategory();

        }

        private void LoadCategory()
        {
            var q = from p in dbContext.ForumCategories
                    select new
                    {
                        p.CategoryID,
                        p.Title,
                        p.Depiction,
                        p.IsVisible,

                    };
            this.dataGridViewMGR.DataSource = q.ToList();
            this.dataGridViewMGR.Columns["btnDelete"].Visible = false;
            this.dataGridViewMGR.Columns["btnPublished"].Visible = false;
            this.dataGridViewMGR.Columns["btnIsVisible"].Visible = true;

            this.dataGridViewMGR.Columns["btnIsVisible"].Width = 100;
        }

        int selectedEditOrDeleteID;
        private void dataGridViewMGR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nowMode == 1)//PO文
            {
                selectedEditOrDeleteID = Convert.ToInt32(dataGridViewMGR.Rows[e.RowIndex].Cells["發文編號"].Value);

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    string nowColumnName = dataGridViewMGR.Columns[e.ColumnIndex].Name;//抓取現在點取的ColumnName 後面要判斷是修改還刪除
                    if (nowColumnName == "btnPublished")
                    {
                        var status = from p in dbContext.ForumPosts
                                     where p.PostID == selectedEditOrDeleteID
                                     select p;
                        status.FirstOrDefault().Status = 1;
                        status.FirstOrDefault().Updated = DateTime.Now;
                        dbContext.SaveChanges();
                        MessageBox.Show("修改完成");
                        LoadPost();


                    }
                    if (nowColumnName == "btnDelete")
                    {
                        var status = from p in dbContext.ForumPosts
                                     where p.PostID == selectedEditOrDeleteID
                                     select p;
                        status.FirstOrDefault().Status = 3;
                        status.FirstOrDefault().Updated = DateTime.Now;
                        dbContext.SaveChanges();
                        MessageBox.Show("修改完成");
                        LoadPost();

                    }
                }
            }
            if(nowMode == 2)//留言
            {
                selectedEditOrDeleteID = Convert.ToInt32(dataGridViewMGR.Rows[e.RowIndex].Cells["留言編號"].Value);

                string nowColumnName = dataGridViewMGR.Columns[e.ColumnIndex].Name;//抓取現在點取的ColumnName 後面要判斷是修改還刪除
                if (nowColumnName == "btnPublished")
                {
                    var status = from p in dbContext.ForumPostComments
                                 where p.PostCommentID == selectedEditOrDeleteID
                                 select p;
                    status.FirstOrDefault().Status = 1;
                    status.FirstOrDefault().Updated = DateTime.Now;
                    dbContext.SaveChanges();
                    MessageBox.Show("修改完成");

                    LoadComment();

                }
                if (nowColumnName == "btnDelete")
                {
                    var status = from p in dbContext.ForumPostComments
                                 where p.PostCommentID == selectedEditOrDeleteID
                                 select p;
                    status.FirstOrDefault().Status = 3;
                    status.FirstOrDefault().Updated = DateTime.Now;
                    dbContext.SaveChanges();
                    MessageBox.Show("修改完成");
                    LoadComment();

                }
            }
            if (nowMode == 3)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    bool onOff = !(bool)this.dataGridViewMGR.Rows[e.RowIndex].Cells["isVisible"].Value;
                    selectedEditOrDeleteID = Convert.ToInt32(dataGridViewMGR.Rows[e.RowIndex].Cells["CategoryID"].Value);
                    var isVisible = from p in dbContext.ForumCategories
                                    where p.CategoryID == selectedEditOrDeleteID
                                    select p;
                    isVisible.FirstOrDefault().IsVisible = onOff;
                    dbContext.SaveChanges();
                    MessageBox.Show("修改完成");
                    LoadCategory();

                }
            }
        }
    }
}
