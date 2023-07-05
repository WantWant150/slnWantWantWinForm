using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjWantWantWinForm
{
    public partial class FrmResume : Form
    {
        int Count = 0;
        bool PictureUpdate = false;
        public FrmResume()
        {
            InitializeComponent();
            #region 拖曳圖片
            this.pictureBox1.AllowDrop = true;
            this.pictureBox1.DragEnter += PictureBox1_DragEnter;
            this.pictureBox1.DragDrop += PictureBox1_DragDrop;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            #endregion

            var q9 = from r in dbContext.Resumes
                     where r.AccountID == CMember.AccountID
                     select r.Photo;
            byte[] photoData = q9.FirstOrDefault();

            if (photoData != null && photoData.Length > 0)        //判斷履歷中有無圖片,資料庫中照片雖然允許空值,但在C#程式中設定一定要輸入圖片才能儲存,所以以圖片有無作為判斷依據
            {
                var q = from r in dbContext.Resumes
                        where r.AccountID == CMember.AccountID
                        select r.Photo;

                byte[] photoData1 = q.FirstOrDefault();  // 取得第一筆資料的二進位圖片資料
                if (photoData1 != null && photoData1.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(photoData1))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }

                //var q1 = from mc in dbContext.MemberCollection
                //         where mc.Resume.AccountID == CMember.AccountID
                //         select mc.MemberAccount.Name;
                //lab_Name.Text = q1.FirstOrDefault();

                var q2 = from r in dbContext.Resumes
                         where r.AccountID == CMember.AccountID
                         select r.Address;
                txtAddress.Text = q2.FirstOrDefault();

                var q3 = from r in dbContext.Resumes
                         where r.AccountID == CMember.AccountID
                         select r.Autobiography;
                txtAutobiography.Text = q3.FirstOrDefault();

                var q4 = from r in dbContext.Resumes
                         where r.TownID == r.Town.TownID && r.AccountID == CMember.AccountID
                         select r.Town.Town1;
                this.cmb_Town.Text = q4.FirstOrDefault().ToString();

                var q5 = from r in dbContext.Resumes
                         where r.TownID == r.Town.TownID && r.AccountID == CMember.AccountID
                         select r.Town.City.City1;
                this.cboCity.Text = q5.FirstOrDefault();

                var q6 = from rs in dbContext.ResumeSkills                   //履歷技能
                         where rs.ResumeID == rs.Resume.ResumeID && rs.Resume.AccountID == CMember.AccountID
                         select rs.Skill.SkillName;
                this.cboResumeSkill.Text = q6.FirstOrDefault().ToString();

                var q7 = from rc in dbContext.ResumeCertificates             //履歷證照                                      
                         where rc.ResumeID == rc.Resume.ResumeID && rc.Resume.AccountID == CMember.AccountID
                         select rc.Certificate.CertificateName;
                this.cboResumeCertificate.Text = q7.FirstOrDefault().ToString();

                var q8 = from r in dbContext.Resumes                         //任務類別
                         where r.TaskNameID == r.TaskNameList.TaskNameID && r.AccountID == CMember.AccountID
                         select r.TaskNameList.TaskName;
                this.comboBox1.Text = q8.FirstOrDefault().ToString();
                
                foreach (Control control in panel2.Controls)
                {
                    if (!(control is Label))
                    {
                        control.Enabled = false;
                    }      
                }
                button1.Enabled = true;
            }
            else
            {
                LoadData();
                button1.Enabled = false;
            }
        }

        private void LoadData()
        {
            var q1 = from c in dbContext.Cities            //載入城市
                     select c.City1;
            this.cboCity.DataSource = q1.ToList();
            this.cboCity.SelectedItem = null;

            var q2 = from t in dbContext.TaskNameLists   //載入任務類型
                     select t.TaskName;
            this.comboBox1.DataSource = q2.ToList();
            this.comboBox1.SelectedItem = null;

            var q3 = from s in dbContext.Skills         //載入履歷技能
                     select s.SkillName;
            this.cboResumeSkill.DataSource = q3.ToList();
            this.cboResumeSkill.SelectedItem = null;

            var q4 = from c in dbContext.Certificates    //載入履歷證照
                     select c.CertificateName;
            this.cboResumeCertificate.DataSource = q4.ToList();
            this.cboResumeCertificate.SelectedItem = null;
        }

        #region 圖片拖曳的對應處理動作
        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.pictureBox1.Image = Image.FromFile(files[0]);
        }

        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        #endregion

        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
                PictureUpdate = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Count == 1)                 //修改
            {
                if (PictureUpdate)
                {
                    byte[] bytes;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.GetBuffer();

                    var q = (from r in dbContext.Resumes                //修改用
                             where r.AccountID == CMember.AccountID
                             select r).FirstOrDefault();
                    q.Photo = bytes;
                }

                if (cboCity.SelectedItem == null)
                {
                    MessageBox.Show("請選擇城市");
                    return;
                }

                //var q1 = from c in dbContext.City
                //         where c.City1 == cboCity.Text
                //         select c.CityID;
                //int cityID = q1.FirstOrDefault();

                var q1 = from t in dbContext.Towns
                         where t.Town1 == cmb_Town.Text
                         select t.TownID;
                int townID = q1.FirstOrDefault();

                var q2 = from t in dbContext.TaskNameLists
                         where t.TaskName == comboBox1.Text
                         select t.TaskNameID;
                int taskNameID = q2.FirstOrDefault();

                var q3 = from s in dbContext.Skills
                         where s.SkillName == cboResumeSkill.Text
                         select s.SkillID;
                int skillID = q3.FirstOrDefault();

                var q4 = from c in dbContext.Certificates
                         where c.CertificateName == cboResumeCertificate.Text
                         select c.CertificateID;
                int certificateID = q4.FirstOrDefault();


                var q5 = (from r in dbContext.Resumes                //修改用
                          where r.AccountID == CMember.AccountID
                          select r).FirstOrDefault();

                q5.Address = txtAddress.Text;
                q5.TownID = townID;
                q5.Autobiography = txtAutobiography.Text;
                q5.TaskNameID = taskNameID;
                q5.AccountID = CMember.AccountID;

                var q6 = (from rs in dbContext.ResumeSkills
                          where rs.ResumeID == rs.Resume.ResumeID
                          select rs).FirstOrDefault();

                q6.ResumeID = q5.ResumeID;
                q6.SkillID = skillID;

                var q7 = (from rc in dbContext.ResumeCertificates
                          where rc.ResumeID == rc.Resume.ResumeID
                          select rc).FirstOrDefault();

                q7.ResumeID = q5.ResumeID;
                q7.CertificateID = certificateID;

                this.dbContext.SaveChanges();

                foreach (Control control in panel2.Controls)
                {
                    if (!(control is Label))
                    {
                        control.Enabled = false;
                    }
                }
                button1.Enabled = true;
                Count = 0;
                MessageBox.Show("修改已儲存");
            }
            else
            {
                if (pictureBox1.Image != null)
                {
                    byte[] bytes;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.GetBuffer();

                    if (cboCity.SelectedItem == null)
                    {
                        MessageBox.Show("請選擇城市");
                        return;
                    }

                    //var q1 = from c in dbContext.City
                    //         where c.City1 == cboCity.Text
                    //         select c.CityID;
                    //int cityID = q1.FirstOrDefault();

                    var q1 = from t in dbContext.Towns
                             where t.Town1 == cmb_Town.Text
                             select t.TownID;
                    int townID = q1.FirstOrDefault();

                    var q2 = from t in dbContext.TaskNameLists
                             where t.TaskName == comboBox1.Text
                             select t.TaskNameID;
                    int taskNameID = q2.FirstOrDefault();

                    var q3 = from s in dbContext.Skills
                             where s.SkillName == cboResumeSkill.Text
                             select s.SkillID;
                    int skillID = q3.FirstOrDefault();

                    var q4 = from c in dbContext.Certificates
                             where c.CertificateName == cboResumeCertificate.Text
                             select c.CertificateID;
                    int certificateID = q4.FirstOrDefault();

                    Resume resume = new Resume()
                    {
                        Photo = bytes,
                        Address = txtAddress.Text,
                        TownID = townID,
                        Autobiography = txtAutobiography.Text,
                        TaskNameID = taskNameID,
                        AccountID = CMember.AccountID,      //MemberAccount
                    };
                    this.dbContext.Resumes.Add(resume);

                    ResumeSkill resumeSkill = new ResumeSkill()
                    {
                        ResumeID = resume.ResumeID,
                        SkillID = skillID
                    };
                    this.dbContext.ResumeSkills.Add(resumeSkill);

                    ResumeCertificate resumeCertificate = new ResumeCertificate()
                    {
                        ResumeID = resume.ResumeID,
                        CertificateID = certificateID
                    };
                    this.dbContext.ResumeCertificates.Add(resumeCertificate);

                    MemberCollection memberCollection = new MemberCollection()
                    {
                        AccountID = CMember.AccountID,
                        ResumeID = resume.ResumeID
                    };
                    this.dbContext.MemberCollections.Add(memberCollection);
                   
                    this.dbContext.SaveChanges();

                    foreach (Control control in panel2.Controls)
                    {
                        if (!(control is Label))
                        {
                            control.Enabled = false;
                        }
                    }
                    button1.Enabled = true;
                    Count = 0;
                    MessageBox.Show("資料新增成功");
                    PictureUpdate = false;
                }
                else
                {
                    MessageBox.Show("請插入圖片");
                }
            }
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            if(txtAddress.Text == "請輸入詳細地址")
            {
                txtAddress.Clear();
            }
        }

        private void txtAutobiography_Click(object sender, EventArgs e)
        {
            if(txtAutobiography.Text == "請簡單的介紹自己，最多400字")
            {
                txtAutobiography.Clear();
            }
        }

        private void txtAutobiography_TextChanged(object sender, EventArgs e)
        {
            if(txtAutobiography.Text.Length == txtAutobiography.MaxLength)
            {
                MessageBox.Show("已到達400字上限");
            }
      }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)    //選擇城市後,載入對應的鄉鎮
        {
            var q = from t in dbContext.Towns
                    where cboCity.Text == t.City.City1
                    select t.Town1;
            this.cmb_Town.DataSource = q.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in panel2.Controls)
            {
                control.Enabled = true;
            }
            LoadData(); 
            button1.Enabled = false;
            Count = 1;
        }
    }
}
