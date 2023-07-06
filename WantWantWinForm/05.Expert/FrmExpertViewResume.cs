using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prjWantWantWinForm
{
    public partial class FrmExpertViewResume : Form
    {
        public FrmExpertViewResume()
        {
            InitializeComponent();
            Load();
            Work(workindex);
            this.timer1.Start();

        }
        NewIspanProjectEntities db = new NewIspanProjectEntities();

        int resumesid { get { return CExpert.FindR; } }

        int member = CMember.AccountID;
        void Load()
        {
            try
            {
                //LOAD傳入資料
                var q = from r in db.Resumes
                        where r.ResumeID == resumesid
                        join a in db.MemberAccounts on r.AccountID equals a.AccountID
                        join t in db.Towns on r.TownID equals t.TownID
                        join c in db.Cities on t.CityID equals c.CityID
                        join er in db.ExpertResumes on r.ResumeID equals er.ResumeID
                        select new { name = a.Name, location = c.City1 + t.Town1, introduction = er.Introduction, Service = er.ServiceMethod, QA = er.Problem };
                var result = q.ToList();
                labName.Text = result.FirstOrDefault().name;
                labLocation.Text = result.FirstOrDefault().location;
                this.txtIntroduction.Text = result.FirstOrDefault().introduction;
                this.txtService.Text = result.FirstOrDefault().Service;
                this.txtQA.Text = result.FirstOrDefault().QA;
                //傳入自拍照片
                var qPhoto = from r in db.MemberAccounts
                             where r.AccountID == member
                             select r.MemberPhoto;
                //if (qPhoto.First() != null)
                //{
                //    Byte[] bytes1 = qPhoto.First();
                //    System.IO.MemoryStream ms1 = new System.IO.MemoryStream(bytes1);
                //    this.pictureBox1.Image = Image.FromStream(ms1);

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        int workindex = 0;
        int indexCount = 0;//作品數量
        List<byte[]> picturelist;
        void Work(int index)
        {
            //傳入作品
            var q = from r in db.Resumes
                    where r.ResumeID == resumesid
                    join a in db.MemberAccounts on r.AccountID equals a.AccountID
                    join er in db.ExpertResumes on r.ResumeID equals er.ResumeID
                    join wl in db.ExpertWorkLists on er.ResumeID equals wl.ResumeID
                    join wk in db.ExpertWorks on wl.WorksID equals wk.WorksID
                    orderby wk.WorksID
                    select wk.WorksPhoto;
            indexCount = q.Count();

            //搜尋

            picturelist = new List<byte[]>();
            foreach (var w in q.ToList())
            {
                byte[] bytes = w;
                picturelist.Add(bytes);
            }



            //List<Byte[]> picturelist = new List<Byte[]>(); ;
            //foreach (var w in q.ToList())
            //{
            //    Byte[] bytes = w;
            //    picturelist.Add(bytes); 

            //}
            //PictureBox[] pictureBoxArray = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };


            //using (System.IO.MemoryStream ms = new System.IO.MemoryStream(picturelist[workindex]))
            //{
            //    //for (int j = 0; j < p.Length; j++)
            //    //{
            //    //    pictureBoxArray[i].Image = Image.FromStream(ms);
            //    //    pictureBoxArray[i].Refresh();
            //    //}
            //    foreach (var p in picturelist)
            //    {
            //        int i = 0;

            //        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(p[i]))
            //        {
            //            for (int j = 0; j < p.Length; j++)
            //            {
            //                pictureBoxArray[i].Image = Image.FromStream(ms);
            //                pictureBoxArray[i].Refresh();
            //            }


            //        }
            //        if (i < indexCount) i++;
            //    }

            //}





            //foreach (var p in picturelist)
            //{
            //    int i = 0;

            //    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(p[i])) 
            //    {
            //        for(int j = 0; j < p.Length; j++) {
            //            pictureBoxArray[i].Image = Image.FromStream(ms);
            //            pictureBoxArray[i].Refresh();
            //        }


            //    }
            //    if (i < indexCount) i++;
            //}





            //if (q.Count() > (index + 5) && index > 0)
            //{
            //    var resultpicture = q.Skip(index).Take(5);
            //    int i = 0;
            //    PictureBox[] pictureBoxArray = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

            //    foreach (var w in resultpicture)
            //    {

            //        Byte[] bytes = w;
            //        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
            //        pictureBoxArray[i].Image = Image.FromStream(ms);
            //        pictureBoxArray[i].Refresh();
            //        if (i < 5) i++;

            //    }
            //    panel6.Refresh();
            //}

            //else if (index+5 <= q.Count())
            //{
            //    index = q.Count()-5;
            //    var resultpicture = q.Skip(index).Take(5);
            //    int i = 0;
            //    PictureBox[] pictureBoxArray = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

            //    foreach (var w in resultpicture)
            //    {

            //        Byte[] bytes = w;
            //        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
            //        pictureBoxArray[i].Image = Image.FromStream(ms);
            //        pictureBoxArray[i].Refresh();
            //        if (i < 5) i++;

            //    }


            //}

            //else {
            //    index = 0;
            //    var resultpicture = q.Skip(index).Take(5);
            //    int i = 0;
            //    PictureBox[] pictureBoxArray = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

            //    foreach (var w in resultpicture)
            //    {

            //        Byte[] bytes = w;
            //        System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
            //        pictureBoxArray[i].Image = Image.FromStream(ms);
            //        pictureBoxArray[i].Refresh();
            //        if (i < 5) i++;

            //    }
            //上面是本來的

            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (pictureBoxArray[i] != null)
            //        {
            //            pictureBoxArray[i].Refresh();
            //        }
            // }
            //}
        }



        private void btnback_Click(object sender, EventArgs e)
        {

            FrmExpertSearch es = new FrmExpertSearch();
            es.Show();
            //this.Close();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            workindex--;
            Work(workindex);
        }

        private void btnFront_Click(object sender, EventArgs e)
        {
            workindex++;
            Work(workindex);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmExpertCase ea = new FrmExpertCase();
            ea.Tag = resumesid;
            ea.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if(workindex + 5 <= indexCount)
            //{
            //    workindex++;
            //    Work(workindex);
            //}
            //else if (workindex + 5> indexCount){ workindex=0; Work(workindex); }

            if (picturelist.Count() > 5)
            {
                PictureBox[] pictureBoxArray = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };



                //foreach (var pictureBox in pictureBoxArray)
                //{

                for (int i = 0; i < 5; i++)
                {
                    byte[] pictureData = picturelist[workindex];
                    using (MemoryStream ms = new MemoryStream(pictureData))
                    {
                        pictureBoxArray[i].Image = Image.FromStream(ms);
                        pictureBoxArray[i].Refresh();
                        ms.Dispose();
                    }

                    if (workindex >= pictureBoxArray.Length)
                    {
                        workindex = 0;
                    }
                    else
                    {
                        workindex++;
                    }
                }

            }
            else if (picturelist.Count() > 0)
            {
                PictureBox[] pictureBoxArray = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

                for (int i = 0; i < picturelist.Count(); i++)
                {
                    byte[] pictureData = picturelist[i];
                    using (MemoryStream ms = new MemoryStream(pictureData))
                    {
                        pictureBoxArray[i].Image = Image.FromStream(ms);
                        pictureBoxArray[i].Refresh();
                        ms.Dispose();
                    }

                    if (workindex >= pictureBoxArray.Length)
                    {
                        workindex = 0;
                    }
                    else
                    {
                        workindex++;
                    }
                }
            }
            else { }
        }
    }
}
