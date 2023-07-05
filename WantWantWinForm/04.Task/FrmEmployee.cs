using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace prjWantWantWinForm
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();

            var q = from p in dbWantModel.TaskNameLists   //任務類型
                         select p.TaskName;
            this.cmb_TaskNumberID.DataSource = q.ToList();
            this.cmb_TaskNumberID.SelectedItem = null;
        }

        NewIspanProjectEntities dbWantModel = new NewIspanProjectEntities();


        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            try
            { //string selectedTaskName = cmb_TaskNumberID.Text; // 從 ComboBox 中獲取選取的任務類別

                //DateTime selectedStartDate = monthCalendar1.SelectionStart; // 從 MonthCalendar 中獲取選取的開始日期
                //DateTime selectedEndDate = monthCalendar1.SelectionEnd; // 從 MonthCalendar 中獲取選取的結束日期


                var q = from task in dbWantModel.TaskLists.AsEnumerable()

                            // join app in dbWantModel.ApplicationLists on task.CaseStatusID equals app.CaseStatusID

                        join taskname in dbWantModel.TaskNameLists on task.TaskNameID equals taskname.TaskNameID

                        join resume in dbWantModel.Resumes on task.TaskNameID equals resume.TaskNameID

                        join resumeskill in dbWantModel.ResumeSkills on resume.ResumeID equals resumeskill.ResumeID
                        join skill in dbWantModel.Skills on resumeskill.SkillID equals skill.SkillID

                        join resumecer in dbWantModel.ResumeCertificates on resume.ResumeID equals resumecer.ResumeID
                        join cer in dbWantModel.Certificates on resumecer.CertificateID equals cer.CertificateID

                        join member in dbWantModel.MemberAccounts on resume.AccountID equals member.AccountID

                        //where task.TaskNameList.TaskName== cmb_TaskNumberID.Text

                        where //task.PublishOrNot == "立刻上架" 
                              //app.CaseStatusID==21  &&
                          task.CaseStatusID == null
                        && task.TaskNameList.TaskName == cmb_TaskNumberID.Text

                        //||  (DateTime.MinValue== )

                        // (selectedStartDate == DateTime.MinValue || task.PublishStart.Date >= selectedStartDate) &&
                        // (selectedEndDate == DateTime.MinValue || task.PublishEnd.Date <= selectedEndDate)


                        select new
                        {

                            task.CaseID,
                            resume.ResumeID,
                            task.TaskNameID,
                            // app.CaseStatusID,

                            member.Name,
                            skill.SkillName,
                            cer.CertificateName,
                            resume.Autobiography,

                            task.PublishStart,
                            task.TaskStart,
                            task.TaskTitle,
                            task.TaskDetail

                        };

                //this.dataGridView1.DataSource = q.ToList();
                //var result = q.ToList();
                this.flowLayoutPanel1.Controls.Clear();

                foreach (var item in q)
                {

                    Applicant applicant = new Applicant();

                    applicant.Tag = item.TaskNameID;

                    applicant.RealName = item.Name;
                    applicant.UserSkill = item.SkillName.ToString();
                    applicant.UserCert = item.CertificateName.ToString();
                    applicant.UserAuto = item.Autobiography;

                    applicant.PublishDate = item.PublishStart;
                    applicant.TaskDate = item.TaskStart;
                    applicant.TaskTitle = item.TaskTitle;
                    applicant.TaskDetail = item.TaskDetail;

                    applicant.flowLayoutPanel1 = flowLayoutPanel1;

                    this.flowLayoutPanel1.Controls.Add(applicant);

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}       
    


