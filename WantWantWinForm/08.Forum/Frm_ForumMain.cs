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

namespace prjWantWantWinForm
{
    public partial class Frm_ForumMain : Form
    {
        //大家一起共用的參數們
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        string selectTitle = "";
        int selectCategoryID;
        private Frm_ForumEnterCategory currentForum; //因為想要讓使用者可以回到上一頁或者將內容呈現到splitContainer1.Panel2

        public Frm_ForumMain()
        {
            InitializeComponent();
            LoadFormCategoryTitle();//讀取論壇討論區標題
            this.btnServiceCMS.Visible = false;
            var role = from p in dbContext.MemberRoleConns
                       where p.AccountID == CMember.AccountID
                       select p;
            if(role.FirstOrDefault().RoleID==2)
                this.btnServiceCMS.Visible = true;
        }

        private void LoadFormCategoryTitle()
        {
            var q=from p in dbContext.ForumCategories
                  where p.IsVisible == true//這邊選取顯示非隱藏的討論區
                  select p.Title;
            this.comboxDisplay_CategoryTitle.DataSource=q.ToList();
        }

        //combox選取事件
        private void comboxDisplay_CategoryTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectTitle = comboxDisplay_CategoryTitle.SelectedItem.ToString();

            var q = from p in dbContext.ForumCategories
                    where p.Title == selectTitle
                    where p.IsVisible == true
                    select p.Depiction;

            var q2 = from p in dbContext.ForumCategories
                    where p.Title == selectTitle
                    where p.IsVisible == true
                    select p.CategoryID;

            labShow_FormCateDes.Text = q.FirstOrDefault();
            selectCategoryID = q2.FirstOrDefault();//為了把ID帶到Frm_ForumEnterCategory設的參數
        }

        //開啟論壇Frm_ForumEnterCategory
        private void btnGotoForum_Click(object sender, EventArgs e)
        {
            if (currentForum != null)            // 判斷是否有表單已經開啟
            {
                currentForum.Close();                // 關閉之前開啟的表單
            }
            //把這一邊選擇的標題及ID帶到Frm_ForumEnterCategory的建構函式內，這樣就可以很方便知道使用者到底要去哪個討論區
            Frm_ForumEnterCategory enterForum = new Frm_ForumEnterCategory(selectTitle, selectCategoryID);
            currentForum = enterForum;//要進入某討論區的新創頁面
            enterForum.TopLevel = false;//要放入子容器中就是不可以TOP

            splitContainer1.Panel2.Controls.Clear();//把上面原本的東西清掉，要不然會疊一起
            splitContainer1.Panel2.Controls.Add(enterForum);
            enterForum.Show();


            enterForum.OnCreatePostFormOpen = form =>
            {
                splitContainer1.Panel2.Controls.Clear();//把上面原本的東西清掉，要不然會疊一起
                splitContainer1.Panel2.Controls.Add(form);
                form.Show();
            };

            //顯示PO文內文
            enterForum.OnPostTitleClick = selectedPostTitle =>
            {
                ShowForumTopicForm(selectedPostTitle);
            };


        }

        //顯示PO文內文的方法
        private void ShowForumTopicForm(string postTitle)
        {
            Frm_ForumTopic forumTopicForm = new Frm_ForumTopic(postTitle);

            forumTopicForm.TopLevel = false;
            forumTopicForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(forumTopicForm);

            forumTopicForm.OnGoBack += GoBackToForumEnterCategory; // 設定回到上一頁的事件

            forumTopicForm.Show();
        }

        
        //回上一頁的方法
        public void GoBackToForumEnterCategory()
        {
            if (currentForum != null)
            {
                splitContainer1.Panel2.Controls.Clear();
                splitContainer1.Panel2.Controls.Add(currentForum);
                currentForum.Show();
            }
        }

        private void btnRevisePost_Click(object sender, EventArgs e)
        {
            Frm_ForumUserCMS frmUserCMS = new Frm_ForumUserCMS();
            frmUserCMS.TopLevel = false;
            frmUserCMS.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(frmUserCMS);
            frmUserCMS.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_ForumServiceCMS frmServiceCMS = new Frm_ForumServiceCMS();
            frmServiceCMS.TopLevel = false;
            frmServiceCMS.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(frmServiceCMS);
            frmServiceCMS.Show();
        }
    }



}
