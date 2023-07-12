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
    public partial class FrmExpertCase : Form
    {
        public FrmExpertCase()
        {
            InitializeComponent();
        }
        int member = CMember.AccountID;
        int caserid { get { return (int)this.Tag; } }
        private void btnSave_Click(object sender, EventArgs e)
        {

            //先找履歷的專家名字ID
            var qe = (from r in db.Resumes
                      join a in db.MemberAccounts on r.AccountID equals a.AccountID
                      where r.ResumeID == caserid
                      select a.AccountID).FirstOrDefault();


            TaskList task = new TaskList()
            {
                WorkPlace = cbPlace.Text,
                TaskStart = this.dateTimePicker1.Value.ToString(),
                TaskEnd = this.dateTimePicker2.Value.ToString(),
                PayFrom = this.txtSalary.Text,
                TaskDetail = this.txtTaskDetail.Text,
                AccountID = qe,
                TaskNameID = 10,
                DataCreateDate=DateTime.Now.ToString(),
            };

            this.db.TaskLists.Add(task);
            db.SaveChanges();
            //-----
            int newcaseid = task.CaseID;
            //======
           ExpertApplication ea = new ExpertApplication()
            {
                CaseID = newcaseid,
                AccountID = member,
                CaseStatusID = 15,
            };
          
            this.db.ExpertApplications.Add(ea);
          db.SaveChanges();
            MessageBox.Show("成功委託。");
            this.Close();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FrmExpertViewResume er = new FrmExpertViewResume();
            er.Show();
        }
        NewIspanProjectEntities db = new NewIspanProjectEntities();
        private void ExpertCase_Load(object sender, EventArgs e)
        {
            //先找履歷的專家名字
            var qe = (from r in db.Resumes
                     join a in db.MemberAccounts on r.AccountID equals a.AccountID
                     where r.ResumeID == caserid
                     select a.Name).FirstOrDefault();

            this.txtExpert.Text = qe.ToString();

            // 找委託者名字         
           string q = db.MemberAccounts.Where(x => x.AccountID == member).Select(x=>x.Name).FirstOrDefault();
                   
            this.txtMy.Text = q;
        }
    }
}
