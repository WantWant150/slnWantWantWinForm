using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
    public partial class FrmExpertSearch : Form
    {
        public FrmExpertSearch()
        {
            InitializeComponent();


            LetSelect();

            if (CExpert.storecity != null && CExpert.storeskall != null && CExpert.storeskd != null
                && CExpert.storecall != null && CExpert.storecd != null) {

                cbCity.Text = CExpert.storecity;
                cbskillall.Text=CExpert.storeskall;
                cbskilldetail.Text=CExpert.storeskd;
                cbCall.Text=CExpert.storecall ;
                 cbskilldetail.Text=CExpert.storecd;
                findq();
            }
        }
        NewIspanProjectEntities db = new NewIspanProjectEntities();
       
        void findq()
        {
            this.flowLayoutPanel1.Controls.Clear();
            int qs = db.Skills.Where(x => x.SkillType.SkillTypeName == cbskillall.Text && x.SkillName == cbskilldetail.Text).Select(x => x.SkillID).FirstOrDefault();
            int qt = db.Towns.Where(x => x.City.City1 == cbCity.Text && x.Town1 == cbTown.Text).Select(x => x.TownID).FirstOrDefault();
            int qc = db.Certificates.Where(x => x.CertificateType.CertificateTypeName == cbCall.Text && x.CertificateName == cbcdetaill.Text).Select(x => x.CertificateID).FirstOrDefault();

            bool isskill = qs != 0;
            bool istown = qt != 0;
            bool iscertif = qc != 0;
            var q = from rs in db.ResumeSkills
                    join r in db.Resumes on rs.ResumeID equals r.ResumeID
                    join a in db.MemberAccounts on r.AccountID equals a.AccountID
                    join er in db.ExpertResumes on r.ResumeID equals er.ResumeID
                    join t in db.Towns on r.TownID equals t.TownID
                    join c in db.Cities on t.CityID equals c.CityID
                    where er.Introduction != null &&
                          ((isskill && istown && iscertif && rs.SkillID == qs && t.TownID == qt) ||
                          (isskill && istown && !iscertif && rs.SkillID == qs && t.TownID == qt) ||
                          (isskill && !istown && iscertif && rs.SkillID == qs && r.ResumeCertificates.Any(rc => rc.ResumeCertificateID == qc)) ||
                          (isskill && !istown && !iscertif && rs.SkillID == qs) ||
                          (!isskill && istown && iscertif && t.TownID == qt && r.ResumeCertificates.Any(rc => rc.ResumeCertificateID == qc)) ||
                          (!isskill && istown && !iscertif && t.TownID == qt) ||
                          (!isskill && !istown && iscertif && r.ResumeCertificates.Any(rc => rc.ResumeCertificateID == qc)) ||
                          (!isskill && !istown && !iscertif))
                    select new { Resumesid = r.ResumeID, name = a.Name, price = er.CommonPrice, town = c.City1 + t.Town1 };


            CExpert.storecity = cbCity.Text;
            CExpert.storeskall = cbskillall.Text;
            CExpert.storeskd = cbskilldetail.Text;
            CExpert.storecall = cbCall.Text;
            CExpert.storecd = cbskilldetail.Text;

            foreach (var item in q)
            {

                FrmExpertR x = new FrmExpertR(); ;
                x.Name = item.name;
                x.findresumeid = item.Resumesid;
                x.findlabname = item.name;
                x.findlabprice = item.price.ToString();
                x.findlaLocation = item.town;
                x.finds = item.Resumesid.ToString();
                this.flowLayoutPanel1.Controls.Add(x);
                //this.panel3.Controls.Add(x);

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            findq();
              #region 原來搜尋條件
            //if (cbskillall有直)
            //{
            //    var q = from rs in db.ResumeSkills
            //            join r in db.Resumes on rs.ResumeID equals r.ResumeID
            //            join a in db.MemberAccounts on r.AccountID equals a.AccountID
            //            join er in db.ExpertResumes on r.ResumeID equals er.ResumeID
            //            join t in db.Towns on r.TownID equals t.TownID
            //            join c in db.Cities on t.CityID equals c.CityID
            //            where rs.SkillID == qs && er.Introduction != null
            //            select new { Resumesid = r.ResumeID, name = a.Name, price = er.CommonPrice, town = c.City1 + t.Town1 };
            //}
            //==============正確以下
            //var q = from rs in db.ResumeSkills
            //        join r in db.Resumes on rs.ResumeID equals r.ResumeID
            //        join a in db.MemberAccounts on r.AccountID equals a.AccountID
            //        join er in db.ExpertResumes on r.ResumeID equals er.ResumeID
            //        join t in db.Towns on r.TownID equals t.TownID
            //        join c in db.Cities on t.CityID equals c.CityID
            //        where er.Introduction != null ||
            //              (qs != null ? rs.SkillID == qs : true) ||
            //              (qt != null ? t.TownID == qt : true) ||
            //              (qc != null ? r.ResumeCertificates.Any(rc => rc.ResumeCertificateID == qc) : true)
            //        select new { Resumesid = r.ResumeID, name = a.Name, price = er.CommonPrice, town = c.City1 + t.Town1 };
            #endregion
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
        #region 細部下拉式選單select選項
        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCity.SelectedIndex>=-1)
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
                var firstTown = qtown.FirstOrDefault();
                if (firstTown != null)
                {
                    cbTown.Text = firstTown.ToString();
                }
            }

            
            else
            {
                cbTown.Text = null;
           
            }
          

        }

        private void cbskillall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbskillall.SelectedIndex >= -1)
            {

                cbskilldetail.Items.Clear();
                cbskilldetail.Text = null;
                var qskilldetail = from x in db.Skills.AsEnumerable()
                                   where x.SkillType.SkillTypeName == cbskillall.Text
                                   select x.SkillName;
                if (qskilldetail.Any())
                {
                    foreach (var i in qskilldetail)
                    {
                        cbskilldetail.Items.Add(i.ToString());
                    }
                    cbskilldetail.Text = qskilldetail.First().ToString();
                }
            }
            else
            {
                cbskilldetail.Text = null;
            }

        }

        private void cbCall_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCall.SelectedIndex > -1)
                {

                    cbcdetaill.Items.Clear();
                    cbcdetaill.Text = null;
                    var qcdetail = from x in db.Certificates
                                   where x.CertificateType.CertificateTypeName == cbCall.Text
                                   select x.CertificateName;

                    foreach (var i in qcdetail)
                    {
                        cbcdetaill.Items.Add(i.ToString());

                    }
                    cbcdetaill.Text = qcdetail.First().ToString();
                }
                else
                {
                    cbcdetaill.Text = null;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        #endregion

        private void btnClean_Click(object sender, EventArgs e)
        {
         
            cbCity.SelectedIndex = -1;
            cbCall.SelectedIndex = -1;
            cbskillall.SelectedIndex = -1;
       
        }
     
        }
    }
