using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace prjWantWantWinForm
{
    public partial class FrmExpertNew : Form
    {
        public FrmExpertNew()
        {
            InitializeComponent();
            LetSelect();
           
        }

        NewIspanProjectEntities db = new NewIspanProjectEntities();
        int member = CMember.AccountID;
      
        private void expertR1_Load(object sender, EventArgs e)
        {
            //會員姓名
            var qname = from x in db.MemberAccounts.AsEnumerable()
                        where x.AccountID == member
                        select new { name = x.Name };
            
        }
        void LetSelect()//這是修改專家資料的時候下拉是選單要動
        {
            #region 下拉式選單大項
            try
            {
                //城市
                var qcity = from x in db.Cities.AsEnumerable()
                            select x.City1;
                cbCity.Items.Clear();
                foreach (var i in qcity)
                {
                    cbCity.Items.Add(i.ToString());

                }
                //專長
                var qskill = from x in db.SkillTypes.AsEnumerable()
                             select x.SkillTypeName;
                cbskillall.Items.Clear();
                foreach (var i in qskill)
                {
                    cbskillall.Items.Add(i.ToString());

                }
                //證照
                var qc = from x in db.CertificateTypes.AsEnumerable()
                         select x.CertificateTypeName;
                cbCall.Items.Clear();
                foreach (var i in qc)
                {
                    cbCall.Items.Add(i.ToString());

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            #endregion
        }
        #region 改變下拉是選單
        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)//城市改變地區資料要跟著改變
        {
            cbTown.Items.Clear();
            cbTown.Text = null;
            var qtown = from x in db.Towns.AsEnumerable()
                        where x.City.City1 == cbCity.Text
                        select x.Town1;

            foreach (var i in qtown)
            {
                cbTown.Items.Add(i.ToString());

            }
            cbTown.Text = qtown.First().ToString();
        }
        private void cbskillall_SelectedIndexChanged(object sender, EventArgs e)//專長改變專長明細資料要跟著改變
        {
            cbskilldetail.Items.Clear();
            cbskilldetail.Text = null;
            var qskilldetail = from x in db.Skills.AsEnumerable()
                               where x.SkillType.SkillTypeName == cbskillall.Text
                               select x.SkillName;

            foreach (var i in qskilldetail)
            {
                cbskilldetail.Items.Add(i.ToString());
            }
            cbskilldetail.Text = qskilldetail.First().ToString();
        }
        private void cbCall_SelectedIndexChanged(object sender, EventArgs e)//證照改變證照明細資料要跟著改變
        {
            cbcdetaill.Items.Clear();
            cbcdetaill.Text = null;
            var qcdetail = from x in db.Certificates.AsEnumerable()
                           where x.CertificateType.CertificateTypeName == cbCall.Text
                           select x.CertificateName;

            foreach (var i in qcdetail)
            {
                cbcdetaill.Items.Add(i.ToString());

            }
            cbcdetaill.Text = qcdetail.First().ToString();
        }
        #endregion
        int townid, skillid, certid;
      
      
        private void btnBeExpert_Click(object sender, EventArgs e)
        {
            if (cbCall.Text == "請選擇" || cbcdetaill.Text == "請選擇" || cbCity.Text == "請選擇" || cbTown.Text == "請選擇" || cbskillall.Text == "請選擇" || cbskilldetail.Text == "請選擇")
            { MessageBox.Show("地區或專長或證照沒有選擇喔"); }
            else
            {
                MemberRoleConn mrc = new MemberRoleConn()
                {
                    AccountID = member,
                    RoleID = 3
                };
                this.db.MemberRoleConns.Add(mrc);

                var qt = db.Towns.Where(x => x.Town1 == cbTown.Text && x.City.City1 == cbCity.Text).Select(x => x.TownID).First();
                var qs = db.Skills.Where(x => x.SkillName == cbskilldetail.Text && x.SkillType.SkillTypeName == cbskillall.Text).Select(x => x.SkillID).First();
                var qc = db.Certificates.Where(x => x.CertificateName == cbcdetaill.Text && x.CertificateType.CertificateTypeName == cbCall.Text).Select(x => x.CertificateID).First();
                townid = qt;                skillid = qs;                certid = qc;
                Resume resume = new Resume { AccountID = member, TownID = townid };
                this.db.Resumes.Add(resume);
                this.db.SaveChanges();


                var qr = db.Resumes.Where(x => x.AccountID == member).OrderByDescending(x=>x.ResumeID).Select(x => x.ResumeID).First();
                MessageBox.Show(qr+"");
                int resumeid = qr;

                ExpertAccount ea = new ExpertAccount() { ResumeID=qr};
                this.db.ExpertAccounts.Add(ea);
                ResumeCertificate rc = new ResumeCertificate { ResumeID = qr,CertificateID = certid };
                this.db.ResumeCertificates.Add(rc);
                ResumeSkill rs = new ResumeSkill { ResumeID = qr, SkillID = skillid };
                this.db.ResumeSkills.Add(rs);

                ExpertResume expertResume = new ExpertResume
                {
                    ResumeID = qr,
                    Introduction = txtIntroduction.Text,
                    PaymentMethod = txtPayment.Text,
                    WorksUrl = txtWebsite.Text,
                    Problem = txtQA.Text,
                    CommonPrice = Convert.ToDecimal(txtPay.Text),
                    ServiceMethod = txtService.Text
                };
                this.db.ExpertResumes.Add(expertResume);


                //===========
                this.db.SaveChanges();
                
         
                MessageBox.Show("新增成功");
            }
        }
           

        
    }
}
