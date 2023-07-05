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
using System.Xml.Linq;

namespace prjWantWantWinForm
{
    public partial class FrmExpertViewResume : Form
    {
        public FrmExpertViewResume()
        {
            InitializeComponent();
            //Load();
            //Work(workindex);

        }
        NewIspanProjectEntities db = new NewIspanProjectEntities();
        
      int rid { get { return CExpert.FindR; } }
   
        int member = CMember.AccountID;
        void Load()
        {
          
            var q = from r in db.Resumes
                    where r.ResumeID == rid
                    join a in db.MemberAccounts on r.AccountID equals a.AccountID
                    join t in db.Towns on r.TownID equals t.TownID
                    join c in db.Cities on t.CityID equals c.CityID
                    join er in db.ExpertResumes on r.ResumeID equals er.ResumeID
                    select new { name = a.Name, location = c.City1 + t.Town1, introduction = er.Introduction, Service = er.ServiceMethod, QA = er.Problem };
            var result = q.First();
            labName.Text = result.name;
            labLocation.Text = result.location;
           
            this.txtIntroduction.Text = result.introduction;
            this.txtService.Text = result.Service;
            this.txtQA.Text = result.QA;
            var qPhoto = from r in db.MemberAccounts
                         where r.AccountID == member
                         select r.MemberPhoto;
            if (qPhoto.First()!=null) {
                Byte[] bytes = qPhoto.First();
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                this.pictureBox1.Image = Image.FromStream(ms);
                //**8**
            }


        }
        int workindex = 0;
        void Work(int index) 
        {
            
                var q = from r in db.Resumes
                        where r.ResumeID == rid
                        join a in db.MemberAccounts on r.AccountID equals a.AccountID
                        join er in db.ExpertResumes on r.ResumeID equals er.ResumeID
                        join wl in db.ExpertWorkLists on er.ResumeID equals wl.ResumeID
                        join wk in db.ExpertWorks on wl.WorksID equals wk.WorksID
                        orderby wk.WorksID
                        select wk.WorksPhoto;
            if (q.Count() > (index + 5) && index > 0)
            {
                var resultpicture = q.Skip(index).Take(5);
                int i = 0;
                PictureBox[] pictureBoxArray = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

                foreach (var w in resultpicture)
                {

                    Byte[] bytes = w;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                    pictureBoxArray[i].Image = Image.FromStream(ms);
                    pictureBoxArray[i].Refresh();
                    if (i < 5) i++;

                }
                panel6.Refresh();
            }

            else if (index+5 <= q.Count())
            {
                index = q.Count()-5;
                var resultpicture = q.Skip(index).Take(5);
                int i = 0;
                PictureBox[] pictureBoxArray = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

                foreach (var w in resultpicture)
                {

                    Byte[] bytes = w;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                    pictureBoxArray[i].Image = Image.FromStream(ms);
                    pictureBoxArray[i].Refresh();
                    if (i < 5) i++;
                  
                }

              
            }

            else {
                index = 0;
                var resultpicture = q.Skip(index).Take(5);
                int i = 0;
                PictureBox[] pictureBoxArray = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };

                foreach (var w in resultpicture)
                {

                    Byte[] bytes = w;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                    pictureBoxArray[i].Image = Image.FromStream(ms);
                    pictureBoxArray[i].Refresh();
                    if (i < 5) i++;

                }


                //    for (int j = 0; j < 5; j++)
                //    {
                //        if (pictureBoxArray[i] != null)
                //        {
                //            pictureBoxArray[i].Refresh();
                //        }
           // }
        }
    }


        private void btnback_Click(object sender, EventArgs e)
        {
           
           FrmExpertSearch es = new FrmExpertSearch();
         es.Show();
            this.Close();
          
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
            ea.Tag =rid;
            ea.Show();
        }
    }
}
