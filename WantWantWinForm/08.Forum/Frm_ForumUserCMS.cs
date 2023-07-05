using prjWantWantWinForm._08.Forum;
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

namespace prjWantWantWinForm
{
    public partial class Frm_ForumUserCMS : Form
    {
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        int clickRowIndex = -1;//追蹤現在按到哪個row
        int nowMode = -1;//追蹤目前模式
        int nowSelectedPostStatus;//追蹤選擇的發文狀態
        int postID;//要傳過去Frm_EditPost用的


        public Frm_ForumUserCMS()
        {
            InitializeComponent();
        }


        //管理留言部分
        private void btnCommentMGR_Click(object sender, EventArgs e)
        {
            this.dataGridViewMGR.Show();
            nowMode = 2;
            LoadCommentData();
        }
        private void LoadPost()
        {
            string _selecttdComboBox= comboxPostStatus.SelectedItem.ToString();
            if(_selecttdComboBox=="已發布發文")
            {
                nowSelectedPostStatus = 1;
            }
            else if(_selecttdComboBox == "未發布草稿") 
            {
                nowSelectedPostStatus = 2;
            }

            var q = from p in dbContext.ForumPosts
                    where p.AccountID == CMember.AccountID && p.Status == nowSelectedPostStatus
                    select new { 文章標題 = p.Title, 文章內容 = p.PostContent, p.Status, p.PostID };

            dataGridViewMGR.DataSource = q.ToList();
            dataGridViewMGR.Columns["PostID"].Visible = false;
            dataGridViewMGR.Columns["Status"].Visible = false;

            dataGridViewMGR.Columns["文章標題"].Width = 350;
            dataGridViewMGR.Columns["文章標題"].ReadOnly = true;
            dataGridViewMGR.Columns["文章內容"].Width = 800;
            dataGridViewMGR.Columns["文章內容"].ReadOnly = true;
        }

        private void LoadCommentData()
        {
            var q = from p in dbContext.ForumPostComments
                    where p.AccountID == CMember.AccountID && p.Status == 1
                    select new { 文章標題 = p.ForumPost.Title, 留言內容 = p.Comment, p.Status, p.Updated, p.PostCommentID };
            DataTable dt = new DataTable();//因為不能直接修改q出來的東西，所以用個DataTable先暫存
            dt.Columns.Add("文章標題");
            dt.Columns.Add("留言內容");
            dt.Columns.Add("PostCommentID");
            dt.Columns.Add("Updated");
            dt.Columns.Add("Status");
            foreach (var item in q)
            {
                dt.Rows.Add(item.文章標題, item.留言內容, item.PostCommentID, item.Updated, item.Status);
            }
            this.dataGridViewMGR.DataSource = dt;
            dataGridViewMGR.Columns["文章標題"].Width = 350;
            dataGridViewMGR.Columns["文章標題"].ReadOnly = true;
            dataGridViewMGR.Columns["留言內容"].Width = 800;
            dataGridViewMGR.Columns["留言內容"].ReadOnly = true;

            dataGridViewMGR.Columns["PostCommentID"].Visible = false;
            dataGridViewMGR.Columns["Updated"].Visible = false;
            dataGridViewMGR.Columns["Status"].Visible = false;
        }

        //datagridview的cell點擊事件

        DataGridViewRow clickRow;//抓現在按到哪個row 公用
        DataGridViewCell clickCell;//抓現在按到哪個Cell 給後面的確認有沒有修改過留言用的
        string noEditComment;//先存原本的留言 如果使用者修改留言後按下取消要對照，如果有修改要把它還原成沒有修改時 好 我錯了 使用者如果一直按會被蓋掉
        int selectedEditOrDeleteID;
        private void dataGridViewMGR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (nowMode == 1)
            {
                selectedEditOrDeleteID = Convert.ToInt32(dataGridViewMGR.Rows[e.RowIndex].Cells["PostID"].Value);
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    clickRow = dataGridViewMGR.Rows[e.RowIndex];//抓現在按到哪個row
                    clickCell = clickRow.Cells[e.ColumnIndex];//抓現在按到哪個Column
                    string nowColumnName = dataGridViewMGR.Columns[e.ColumnIndex].Name;//抓取現在點取的ColumnName 後面要判斷是修改還刪除
                    //修改貼文
                    if (nowColumnName == "btnModify")
                    {
                        this.dataGridViewMGR.Hide();
                        Frm_EditPost frm_EditPost = new Frm_EditPost(selectedEditOrDeleteID);
                        frm_EditPost.TopLevel = false;

                        panel2.Controls.Add(frm_EditPost);
                        frm_EditPost.Show();

                    }
                    //刪除貼文
                    if (nowColumnName == "btnDelete")
                    {
                        DialogResult result = MessageBox.Show($"是否要刪除此篇發文", "刪除發文", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            DialogResult lastWarning = MessageBox.Show($"刪除後不可復原，您確定要刪除?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (lastWarning == DialogResult.OK)
                            {
                                var status = from p in dbContext.ForumPosts
                                             where p.PostID == selectedEditOrDeleteID
                                             select p;
                                status.FirstOrDefault().Status = 3;
                                status.FirstOrDefault().Updated =DateTime.Now;
                                dbContext.SaveChanges();
                            }
                        }
                    }
                }

            }

            if (nowMode == 2)
            {
                selectedEditOrDeleteID = Convert.ToInt32(dataGridViewMGR.Rows[e.RowIndex].Cells["PostCommentID"].Value);
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    clickRow = dataGridViewMGR.Rows[e.RowIndex];//抓現在按到哪個row
                    clickCell = clickRow.Cells[e.ColumnIndex];//抓現在按到哪個Column
                    string nowColumnName = dataGridViewMGR.Columns[e.ColumnIndex].Name;//抓取現在點取的ColumnName 後面要判斷是修改還刪除

                    //這個是修改留言
                    if (nowColumnName == "btnModify")
                    {
                        clickRowIndex = e.RowIndex;
                        DialogResult result = MessageBox.Show($"按下確定即可於右方留言內容欄修改留言\n按取消停止修改", "修改留言", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            dataGridViewMGR.Columns["留言內容"].ReadOnly = true;
                            clickRow.Cells["留言內容"].ReadOnly = false;//只修改點擊的那行
                        }
                        else
                        {
                            clickRow.Cells["留言內容"].ReadOnly = true;
                        }
                    }

                    //這個是刪除留言
                    if (nowColumnName == "btnDelete")
                    {
                        DialogResult result = MessageBox.Show($"是否要刪除留言", "刪除留言", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            DialogResult lastWarning = MessageBox.Show($"刪除後不可復原，您確定要刪除?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (lastWarning == DialogResult.OK)
                            {
                                var status = from p in dbContext.ForumPostComments
                                             where p.PostCommentID == selectedEditOrDeleteID
                                             select p;
                                status.FirstOrDefault().Status = 3;
                                status.FirstOrDefault().Updated = DateTime.Now;
                                dbContext.SaveChanges();
                                LoadCommentData();
                            }
                        }
                    }
                }
            }



        }

        #region
        //當使用dataGridView1_CellEndEdit事件，且用滑鼠從儲存格A移至儲存格，會導致A還未完成編輯時，又進入B的情況，導致迴圈發生。
        //可改用CellValueChanged事件代替，但可能會一直亂觸發
        //或者不要用clickRow(自己記憶的參數)，直接用e.RowIndex(因為現在有綁定一次只能修改單行，其他會關閉)
        //屁哩沒有用 總之 小心 不要 不小心 換到別行

        #endregion

        //這裡是修改留言內容
        int editCommentID;
        private void dataGridViewMGR_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (nowMode == 2)
                {
                    editCommentID = Convert.ToInt32(dataGridViewMGR.Rows[e.RowIndex].Cells["PostCommentID"].Value);

                    if (e.ColumnIndex == dataGridViewMGR.Columns["留言內容"].Index)
                    {
                        DialogResult result = MessageBox.Show($"是否更新留言內容?\n按\"是\"儲存目前留言\n按\"否\"繼續修改留言\n按\"取消\"取消修改", "修改留言", MessageBoxButtons.YesNoCancel);
                        DataGridViewCell editedCell = dataGridViewMGR.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        string editedComment = clickRow.Cells[e.ColumnIndex].Value.ToString();//修改過後的留言
                        if (result == DialogResult.Yes)
                        {
                            if (editedComment.Length > 100)
                            {
                                MessageBox.Show("字數過多，請刪減後再試");
                            }
                            else if (editedComment.Length <= 0)
                            {
                                MessageBox.Show("請輸入留言");

                            }
                            else
                            {
                                var comment = from p in dbContext.ForumPostComments
                                              where p.PostCommentID == editCommentID
                                              select p;
                                comment.FirstOrDefault().Comment = editedComment;
                                comment.FirstOrDefault().Updated = DateTime.Now;
                                dbContext.SaveChanges();

                                MessageBox.Show("儲存成功");
                                editedCell.ReadOnly = true;
                            }

                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("繼續修改");
                        }
                        else
                        {
                            MessageBox.Show("取消修改");
                            editedCell.ReadOnly = true;
                            LoadCommentData();
                        }
                    }
                }
            }
 catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //儲存原本的留言用
        private void dataGridViewMGR_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewMGR.Columns["留言內容"].Index)
            {
                noEditComment = dataGridViewMGR.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void btnModifyPost_Click(object sender, EventArgs e)
        {
            this.dataGridViewMGR.Show();
            nowMode = 1;
            if (comboxPostStatus.SelectedItem.ToString() == "已發布發文")
            {
                LoadPost();
            }
            if (comboxPostStatus.SelectedItem.ToString() == "未發布草稿")
            {
                LoadPost();
            }





        }



    }
}
