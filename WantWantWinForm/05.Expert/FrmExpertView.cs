using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using prjIspanWinForms;

namespace prjIspanWinForms
{

    public partial class FrmExpertView : Form
    {
        public FrmExpertView()
        {
            InitializeComponent();

            LoadData();
            workShow();
            LetSelect();
            NowResumes();
        }

        bool modify = false;//為了判別修改新增控制項顯示
        NewIspanProjectEntities db = new NewIspanProjectEntities();

        int member = CMember.AccountID;
        int resumes { get; set; }
        void NowResumes()
        {
            resumes = db.Resumes.Where(x => x.ExpertResume.Introduction != null).Select(x => x.ResumeID).First();
        }

        int nowR;
        void ShowOrNot()
        {
            #region 控制項

            txtIntroduction.Enabled = modify;
            txtPay.Enabled = modify;
            txtWebsite.Enabled = modify;
            txtPayment.Enabled = modify;
            txtQA.Enabled = modify;
            txtService.Enabled = modify;
            cbcdetaill.Enabled = modify;
            cbCall.Enabled = modify;
            cbCity.Enabled = modify;
            cbTown.Enabled = modify;
            cbskillall.Enabled = modify;
            cbskilldetail.Enabled = modify;
            btnSave.Enabled = modify;
            #endregion
        }



        void LoadData()//這是匯入資料
        {
            try
            {

                //會員姓名
                var qname = from x in db.MemberAccounts.AsEnumerable()
                            where x.AccountID == member
                            select new { name = x.Name, };
                if (qname == null) { lbName.Text = "會員尚未填會員姓名!"; }
                else if (qname != null) { lbName.Text = qname.FirstOrDefault().name.ToString(); }
                else { MessageBox.Show("請洽客服"); }

                //城鎮
                var qcity = from x in db.Resumes.AsEnumerable()
                            where x.AccountID == member
                            select new
                            {
                                Mycity = x.Town.City.City1,
                                Mytown = x.Town.Town1,
                            };

                foreach (var i in qcity)
                {
                    cbCity.Text = i.Mycity.ToString();
                    cbTown.Text = i.Mytown.ToString();

                }
                try
                {
                    //自我介紹
                    var introductionq = from x in db.ExpertResumes.AsEnumerable()
                                        where x.Resume.AccountID == member
                                        select new
                                        {
                                            r = x.ResumeID,
                                            IntroDuction = x.Introduction,
                                            contact = x.ContactMethod,
                                            payment = x.PaymentMethod,
                                            Web = x.WorksUrl,
                                            pay = $"{x.CommonPrice:c0}",
                                            service = x.ServiceMethod,
                                            qa = x.Problem,
                                        };

                    if (introductionq == null) { lbName.Text = "尚未填自我介紹!"; }
                    else if (introductionq != null)
                    {
                        nowR = introductionq.FirstOrDefault().r;
                        foreach (var i in introductionq)
                        {
                            txtIntroduction.Text = i.IntroDuction.ToString();
                            txtPay.Text = i.pay.ToString();
                            txtWebsite.Text = i.Web.ToString();
                            txtPayment.Text = i.payment.ToString();
                            txtQA.Text = i.qa.ToString();
                            txtService.Text = i.service.ToString();

                        }
                    }
                    else { MessageBox.Show("請洽客服"); }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }


                //專長證照
                var qskill = from x in db.ResumeSkills.AsEnumerable()
                             where x.Resume.AccountID == member
                             select new
                             {
                                 Myskilldetail = x.Skill.SkillName,
                                 Myskill = x.Skill.SkillType.SkillTypeName
                             };
                foreach (var i in qskill)
                {
                    cbskillall.Text = i.Myskill.ToString();
                    cbskilldetail.Text = i.Myskilldetail.ToString();

                }
                var qCertificate = from x in db.ResumeCertificates.AsEnumerable()
                                   where x.Resume.AccountID == member
                                   select new
                                   {
                                       MyCertificatedetail = x.Certificate.CertificateName,
                                       Mycertificate = x.Certificate.CertificateType.CertificateTypeName
                                   };
                foreach (var i in qCertificate)
                {
                    cbCall.Text = i.Mycertificate.ToString();
                    cbcdetaill.Text = i.MyCertificatedetail.ToString();

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

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


        private void btnModify_Click(object sender, EventArgs e)//按鈕可不可修改
        {
            modify = true;
            ShowOrNot();



        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO金額要清掉decimal
                btnModify.Enabled = false;//TODO...不知道為什麼按鈕不會關掉
                if (modify)
                {

                    MessageBox.Show(resumes + "");
                    //城鎮
                    var qtown = db.Resumes.Where(x => x.ResumeID == resumes).FirstOrDefault();
                    var qtownid = db.Towns.Where(x => x.Town1 == cbTown.Text && x.City.City1 == cbCity.Text).Select(x => x.TownID).FirstOrDefault();
                    qtown.TownID = qtownid;

                    //專長
                    var qskillS = db.ResumeSkills.Where(x => x.ResumeID == resumes).FirstOrDefault();
                    var qskillid = db.Skills.Where(x => x.SkillType.SkillTypeName == cbskillall.Text && x.SkillName == cbskilldetail.Text).Select(x => x.SkillID).FirstOrDefault();
                    qskillS.SkillID = qskillid;
                    //證照
                    var qCertif = db.ResumeCertificates.Where(x => x.ResumeID == resumes).FirstOrDefault();
                    var qCertifid = db.Certificates.Where(x => x.CertificateType.CertificateTypeName == cbCall.Text && x.CertificateName == cbcdetaill.Text).Select(x => x.CertificateID).FirstOrDefault();
                    qCertif.CertificateID = qCertifid;



                    //其他
                    var qer = db.ExpertResumes.Where(x => x.Resume.AccountID == member).FirstOrDefault();
                    //qer.ContactMethod = txtService.Text;
                    qer.Introduction = txtIntroduction.Text;
                    qer.PaymentMethod = txtPayment.Text;
                    qer.WorksUrl = txtWebsite.Text;
                    qer.Problem = txtQA.Text;
                    qer.CommonPrice = Convert.ToDecimal(txtPay.Text);
                    qer.ServiceMethod = txtService.Text;


                    MessageBox.Show("成功");
                    db.SaveChanges();


                    modify = !modify;
                    ShowOrNot();
                    btnModify.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


  
        void workShow()
        {

            this.flowLayoutPanel2.Controls.Clear();

            var qname = db.ExpertWorkLists.Where(x => x.ResumeID == nowR)
               .Select(x => x.ExpertWork);
            int count = qname.Count();
            MessageBox.Show(count+"");
            foreach (var x in qname)
            {
                PictureBox pictureBox = new PictureBox();

                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                Byte[] bytes = null;
                    bytes = x.WorksPhoto;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                pictureBox.Image = Image.FromStream(ms);
     
                pictureBox.Tag = x.Workname;
                pictureBox.Click += PictureBox_Click;

                this.flowLayoutPanel2.Controls.Add(pictureBox);
                flowLayoutPanel2.Refresh();
            }



        }
        string imageName;

        private PictureBox selectedPictureBox;
        private void PictureBox_Click(object sender, EventArgs e)
        {

            PictureBox nowpictureBox = (PictureBox)sender;

            nowpictureBox.Paint -= NowpictureBox_Paint;
            nowpictureBox.BorderStyle = BorderStyle.FixedSingle;
            nowpictureBox.Paint += NowpictureBox_Paint;

            imageName = (string)nowpictureBox.Tag;


        }


        private void NowpictureBox_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            e.Graphics.DrawRectangle(new Pen(Color.Red, 8), 0, 0, pb.Width, pb.Height);
        }
        PictureBox picturebox;
        private void btnPictureUp_Click(object sender, EventArgs e)
        {
            Byte[] bytes=null;

        using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var findq = db.ExpertResumes.Where(x => x.Introduction != null).Select(x => x.ResumeID);
                    string picname = Path.GetFileName(openFileDialog1.FileName);
                    picturebox = new PictureBox();
                   picturebox.Image = Image.FromFile(this.openFileDialog1.FileName);
                    picturebox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    bytes = ms.GetBuffer();
         
                    int nowresumeid = findq.First();
                    this.flowLayoutPanel2.Controls.Clear();
                    ExpertWork works = new ExpertWork
                    {
                        WorksPhoto = bytes,
                        //**8**
                        Workname = picname,
                        DataCreateDate = DateTime.Now


                    };
                    this.db.ExpertWorks.Add(works);
                    db.SaveChanges();
                    int lastid = db.ExpertWorks.OrderByDescending(x => x.WorksID).Select(x => x.WorksID).FirstOrDefault();

                    //var q = db.ExpertWorkLists.Where(x=>x.ExpertResume.Resume.AccountID==member).Select(x=>x.ResumeID).FirstOrDefault();
                    ExpertWorkList workList = new ExpertWorkList
                    {
                        WorksID = lastid,
                        ResumeID = nowR,


                    };
                  
                   
                    this.db.ExpertWorkLists.Add(workList);

                    db.SaveChanges();
                    MessageBox.Show("成功");
                    workShow();
                }

            }

        }
        //private void btnPictureUp_Click(object sender, EventArgs e)
        //{

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        string picname = Path.GetFileName(openFileDialog1.FileName);
        //        picturebox = new PictureBox();

        //        picturebox.Image = Image.FromFile(this.openFileDialog1.FileName);
        //        Byte[] bytes;
        //        System.IO.MemoryStream ms = new System.IO.MemoryStream();
        //        picturebox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        //        bytes = ms.GetBuffer();
        //        var findq = db.ExpertResumes.Where(x => x.Introduction != null).Select(x => x.ResumeID);
        //        int nowresumeid = findq.First();

        //        ExpertWork works = new ExpertWork
        //        {
        //            WorksPhoto = bytes,
        //            //**8**
        //            Workname = picname,
        //            DataCreateDate = DateTime.Now


        //        };
        //        int lastid = db.ExpertWorks.OrderByDescending(x => x.WorksID).Select(x => x.WorksID).FirstOrDefault();

        //        //var q = db.ExpertWorkLists.Where(x=>x.ExpertResume.Resume.AccountID==member).Select(x=>x.ResumeID).FirstOrDefault();
        //        ExpertWorkList workList = new ExpertWorkList
        //        {
        //            WorksID = lastid,
        //            ResumeID = nowR,


        //        };
        //        this.flowLayoutPanel2.Controls.Clear();
        //        this.db.ExpertWorks.Add(works);
        //        this.db.ExpertWorkLists.Add(workList);

        //        db.SaveChanges();
        //        MessageBox.Show("成功");
        //        workShow();
        //    }
        //}

        private void btndelect_Click(object sender, EventArgs e)
        {
            var q = from ew in db.ExpertWorks
                    join ewl in db.ExpertWorkLists on ew.WorksID equals ewl.WorksID
                    where ew.Workname == imageName
                    select ew;
            var q2 = from ew in db.ExpertWorks
                     join ewl in db.ExpertWorkLists on ew.WorksID equals ewl.WorksID
                     where ew.Workname == imageName
                     select ewl;
            if (q != null)
            {
                db.ExpertWorkLists.RemoveRange(q2);
                db.ExpertWorks.RemoveRange(q);
                db.SaveChanges();
                MessageBox.Show("刪除成功");
                workShow();
            }
            else
            {
                MessageBox.Show("找不到要刪除的圖片！");
            }
        }

        #region 細部下拉式選單select選項
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

        private void btnHistoru_Click(object sender, EventArgs e)
        {
            FrmExpertHistory expertHistory = new FrmExpertHistory();
            expertHistory.Show();
        }
    }
}
