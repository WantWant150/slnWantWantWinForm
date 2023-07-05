using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
    public partial class FrmJobDetail : Form
    {
        public Frm_找工作_DataGridView_ findjob
        {
            get; set;
        }

        public int ID
        {
            get; set;
        }
        public FrmJobDetail()
        {
            InitializeComponent();          
        }

        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        private void Frm_工作詳細頁面_Load(object sender, EventArgs e)
        {
            var q = dbContext.TaskLists.FirstOrDefault(n => n.CaseID == ID);
            textBox1.Text = q.TaskDetail;
            textBox2.Text = q.TaskTitle;
            textBox3.Text = q.PayFrom;
            //textBox4.Text = q.PayTo;
            textBox5.Text = q.RequiredNum;
        }

        bool Flag = false;
        private void button1_Click(object sender, EventArgs e)      //應徵
        {
            //Process.Start("https://www.facebook.com");
            //    if (Flag)
            //    {
            //        button1.Text = "立即應徵";
            //        var q = (from t in dbContext.TaskList
            //                 where t.CaseID == ID
            //                 select t).FirstOrDefault();

            //        q.CaseStatusID = 20;
            //        dbContext.SaveChanges();
            //        MessageBox.Show("已取消應徵");
            //    }
            //    else
            //    {
            //        button1.Text = "✓已應徵";
            //        var q = (from t in dbContext.TaskList
            //                 where t.CaseID == ID
            //                 select t).FirstOrDefault();

            //        q.CaseStatusID = 19;                  //6 已收藏 7 未收藏 19 已應徵 20 未應徵
            //        dbContext.SaveChanges();
            //        MessageBox.Show("應徵成功");
            //    }
            //    Flag = !Flag;
            //    

            //var q = (from al in dbContext.ApplicationList
            //        select al).FirstOrDefault();

            //q.ResumeID = q.Resume.ResumeID;
            //q.CaseID = ID;
            //q.CaseStatusID = 21;    //狀態轉換為應徵中

            var q = (from r in dbContext.Resumes
                    where r.AccountID == CMember.AccountID
                    select r.ResumeID).FirstOrDefault();

            ApplicationList applicationList = new ApplicationList()
            {
                ResumeID = q,
                CaseID = ID,
                CaseStatusID = 21           //狀態轉換為應徵中
            };
            dbContext.ApplicationLists.Add(applicationList);
            dbContext.SaveChanges();

            MessageBox.Show("已投遞履歷");
            button1.Enabled = false;
        }

        //bool Flag2 = false;
        private void button2_Click(object sender, EventArgs e)
        {     
            
            //if (Flag2)
            //{
            //    button2.Text = "❤️收藏";

            //    //var q = (from t in dbContext.TaskList
            //    //         where t.CaseID == ID
            //    //         select t).FirstOrDefault();
            //    //q.CaseStatusID = 7;
                
            //    var q = (from mc in dbContext.MemberCollection
            //            where mc.CaseID == ID && mc.AccountID == CMember.AccountID
            //            select mc).FirstOrDefault();
                
            //    this.dbContext.MemberCollection.Remove(q);
            //    dbContext.SaveChanges();
            //}
            //else
            //{
                //button2.Text = "❤已收藏";

                //var q = (from t in dbContext.TaskList
                //         where t.CaseID == ID
                //         select t).FirstOrDefault();
                //q.CaseStatusID = 6;

                MemberCollection memberCollection = new MemberCollection()
                {
                    AccountID = CMember.AccountID,
                    CaseID = ID,
                    
                };
                this.dbContext.MemberCollections.Add(memberCollection);
                dbContext.SaveChanges();
            MessageBox.Show("已收藏");
            button2.Enabled = false;
            //}
            //Flag2 = !Flag2;
        }
    }
}
