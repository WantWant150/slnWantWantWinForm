using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prjWantWantWinForm
{
    public partial class Applicant : UserControl
    {
               public Applicant()
        {
            InitializeComponent();          
        }

        NewIspanProjectEntities dbWantModel = new NewIspanProjectEntities();


        public string RealName
        {
            get { return txt_RealName.Text; }
            set { txt_RealName.Text = value; }
        }

        public string UserSkill
        {
            get { return txt_UserSkill.Text; }
            set { txt_UserSkill.Text = value; }
        }

        public string UserCert
        {
            get { return txt_UserCert.Text; }
            set { txt_UserCert.Text = value; }
        }

        public string UserAuto
        {
            get { return txt_UserAuto.Text; }
            set { txt_UserAuto.Text = value; }
        }

        public string PublishDate
        {
            get { return txt_PublishDate.Text; }
            set { txt_PublishDate.Text = value; }
        }

        public string TaskDate
        {
            get { return txt_TaskDate.Text; }
            set { txt_TaskDate.Text = value; }
        }

        public string TaskTitle
        {
            get { return txt_TaskTitle.Text; }
            set { txt_TaskTitle.Text = value; }
        }

        public string TaskDetail
        {
            get { return txt_TaskDetail.Text; }
            set { txt_TaskDetail.Text = value; }
        }

        public FlowLayoutPanel flowLayoutPanel1
        {
            get; set;
        }              

        public void btn_Yes_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show("恭喜錄取");
            //MessageBox.Show(this.Tag.ToString());

            //string TAG = this.Tag.ToString();
            //char[] chars = new char[] { '/' };
            //string [] aaa =TAG.Split(chars) ;

         
            Button button = (Button)sender;         
            Applicant applicant = (Applicant)button.Parent;

            //// 從容器中移除自訂控制項
            this.flowLayoutPanel1.Controls.Remove(applicant);
           
            var q = from p in dbWantModel.TaskLists.AsEnumerable()
                        //join pp in dbWantModel.Resumes on p.TaskNameID equals pp.TaskNameID
                        //join ppp in dbWantModel.CaseStatusLists on p.CaseStatusID equals ppp.CaseStatusID

                    where p.TaskNameID == (int)this.Tag && p.CaseStatusID == null

                    select p;

            foreach (var item in q)
            {
                item.CaseStatusID = 1;
                //item.Value = 2;
                //MessageBox.Show(item.CaseStatusID);
            }
            this.dbWantModel.SaveChanges();
           // MessageBox.Show(dbWantModel.CaseStatusLists.ToString());
            //this.Read_RefreshDataGridView();
            q.ToList();

        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show("恭喜錄取");
            //MessageBox.Show(this.Tag.ToString());
           
            Button button = (Button)sender;
            Applicant applicant = (Applicant)button.Parent;

            this.flowLayoutPanel1.Controls.Remove(applicant);

            var q = from p in dbWantModel.TaskLists.AsEnumerable()
                        //join pp in dbWantModel.Resumes on p.TaskNameID equals pp.TaskNameID
                        //join ppp in dbWantModel.CaseStatusLists on p.CaseStatusID equals ppp.CaseStatusID

                    where p.TaskNameID == (int)this.Tag && p.CaseStatusID == null

                    select p;

            foreach (var item in q)
            {
                item.CaseStatusID = 2;              
            }
            this.dbWantModel.SaveChanges();
        }
    }
}
