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
    public partial class FrmNotPublish_New : Form
    {
        public FrmNotPublish 未上架
        {
            get; set;
        }

        public int ID
        {
            get; set;
        }



        public FrmNotPublish_New()
        {
            InitializeComponent();
        }

        NewIspanProjectEntities dbWantModel = new NewIspanProjectEntities();

        private void 未上架newform_Load(object sender, EventArgs e)
        {
            
            var q = dbWantModel.TaskLists.FirstOrDefault(n => n.CaseID == ID);
                
                dTP_TaskStart.Text = q.TaskStart;
                dTP_TaskEnd.Text = q.TaskEnd;
                cmb_TaskNumberID.Text = q.TaskNameList.TaskName.ToString();
                txt_Title.Text = q.TaskTitle;
                txt_Detail.Text = q.TaskDetail;            

        }

        private void btn_Pub_Click(object sender, EventArgs e)
        {
            try
            {
                var q =( from p in dbWantModel.TaskLists
                        where p.PublishOrNot == "延後上架" && p.CaseID == ID
                        select p).FirstOrDefault();

                q.PublishOrNot = "立刻上架";

                this.dbWantModel.SaveChanges();

                MessageBox.Show("儲存成功");

                this.Hide();
                
            }

            catch (Exception ex) 
            {
            MessageBox.Show("發生錯誤：" + ex.Message);
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                var q = (from p in dbWantModel.TaskLists                           
                             where p.PublishOrNot == "延後上架" && p.CaseID == ID
                             select p).FirstOrDefault();
                             
                q.TaskStart = dTP_TaskStart.Text;
                q.TaskEnd = dTP_TaskEnd.Text;
                q.TaskTitle = txt_Title.Text;
                q.TaskDetail = txt_Detail.Text;
                
                this.dbWantModel.SaveChanges();

                MessageBox.Show("儲存成功");

                this.Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：" + ex.Message);
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                //delete one product
                var q = (from p in this.dbWantModel.TaskLists
                        where p.PublishOrNot == "延後上架" && p.CaseID == ID
                        select p).FirstOrDefault();

                q.CaseStatusID = 5;

                //foreach (var item in q)
                //{
                //    item.CaseID = ID;
                //    item.CaseStatusID =5;
                //    item.TaskStart = dTP_TaskStart.Text;
                //    item.TaskEnd = dTP_TaskEnd.Text;
                //    item.TaskTitle = txt_Title.Text;
                //    item.TaskDetail = txt_Detail.Text;
                //}

                this.dbWantModel.SaveChanges();

                MessageBox.Show("儲存成功");

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：" + ex.Message);
            }

        }
    }
}
