using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
    public partial class FrmApproved : Form
    {
        public FrmApproved()
        {
            InitializeComponent();
        }

        NewIspanProjectEntities dbWantModel = new NewIspanProjectEntities();

        private void cmb_YesOrNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (cmb_YesOrNo.Text == "錄取")
                {
                    var q = from app in dbWantModel.ApplicationLists.AsEnumerable()

                             join task in dbWantModel.TaskLists on app.CaseID equals task.CaseID

                            join resume in dbWantModel.Resumes on task.TaskNameID equals resume.TaskNameID

                            join resumeskill in dbWantModel.ResumeSkills on resume.ResumeID equals resumeskill.ResumeID
                            join skill in dbWantModel.Skills on resumeskill.SkillID equals skill.SkillID

                            join resumecer in dbWantModel.ResumeCertificates on resume.ResumeID equals resumecer.ResumeID
                            join cer in dbWantModel.Certificates on resumecer.CertificateID equals cer.CertificateID

                            join member in dbWantModel.MemberAccounts on resume.AccountID equals member.AccountID

                            where app.CaseStatusID == 1

                            select new
                            {
                                member.Name,
                                skill.SkillName,
                                cer.CertificateName,
                                resume.Autobiography,

                                task.PublishStart,
                                task.TaskStart,
                                task.TaskTitle,
                                task.TaskDetail
                            };

                    this.flowLayoutPanel1.Controls.Clear();

                    foreach (var item in q)
                    {

                        WithoutButton without = new WithoutButton();

                        without.RealName = item.Name;
                        without.UserSkill = item.SkillName.ToString();
                        without.UserCert = item.CertificateName.ToString();
                        without.UserAuto = item.Autobiography;

                        without.PublishDate = item.PublishStart;
                        without.TaskDate = item.TaskStart;
                        without.TaskTitle = item.TaskTitle;
                        without.TaskDetail = item.TaskDetail;

                        without.flowLayoutPanel1 = flowLayoutPanel1;

                        this.flowLayoutPanel1.Controls.Add(without);
                    }

                }

                else
                {
                    var q = from app in dbWantModel.ApplicationLists.AsEnumerable()

                            join task in dbWantModel.TaskLists on app.CaseID equals task.CaseID

                            join resume in dbWantModel.Resumes on task.TaskNameID equals resume.TaskNameID

                            join resumeskill in dbWantModel.ResumeSkills on resume.ResumeID equals resumeskill.ResumeID
                            join skill in dbWantModel.Skills on resumeskill.SkillID equals skill.SkillID

                            join resumecer in dbWantModel.ResumeCertificates on resume.ResumeID equals resumecer.ResumeID
                            join cer in dbWantModel.Certificates on resumecer.CertificateID equals cer.CertificateID

                            join member in dbWantModel.MemberAccounts on resume.AccountID equals member.AccountID

                            where app.CaseStatusID == 2

                            select new
                            {
                                member.Name,
                                skill.SkillName,
                                cer.CertificateName,
                                resume.Autobiography,

                                task.PublishStart,
                                task.TaskStart,
                                task.TaskTitle,
                                task.TaskDetail
                            };

                    this.flowLayoutPanel1.Controls.Clear();

                    foreach (var item in q)
                    {

                        WithoutButton without = new WithoutButton();

                        without.RealName = item.Name;
                        without.UserSkill = item.SkillName.ToString();
                        without.UserCert = item.CertificateName.ToString();
                        without.UserAuto = item.Autobiography;

                        without.PublishDate = item.PublishStart;
                        without.TaskDate = item.TaskStart;
                        without.TaskTitle = item.TaskTitle;
                        without.TaskDetail = item.TaskDetail;

                        without.flowLayoutPanel1 = flowLayoutPanel1;

                        this.flowLayoutPanel1.Controls.Add(without);

                    }
                }                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
