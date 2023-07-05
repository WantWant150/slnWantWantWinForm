using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjWantWantWinForm
{
    public partial class FrmTask : Form
    {
        public FrmTask()
        {
            InitializeComponent();

            //this.pic_1.AllowDrop = true;
            //this.pic_1.DragEnter += PictureBox1_DragEnter;
            //this.pic_1.DragDrop += PictureBox1_DragDrop;
            //this.pic_1.SizeMode = PictureBoxSizeMode.StretchImage;

            var q1 = from p in dbWantModel.TaskNameLists    //任務類型
                     select p.TaskName;
            this.cmb_TaskNumberID.DataSource = q1.ToList();
            this.cmb_TaskNumberID.SelectedItem = null;

            //var q2 = from p in dbWantModel.CaseStatusList   //案件狀態    //用集合裡的字串
            //         select p.CaseStatus;
            //this.cmb_Publish.DataSource = q2.ToList();
            //this.cmb_Publish.SelectedItem = null;

            var q3 = from p in dbWantModel.Cities    //台北市
                     select p.City1;
            this.cmb_City.DataSource = q3.ToList();
            this.cmb_City.SelectedItem = null;

            var q4 = from p in dbWantModel.Towns    //中山區
                     select p.Town1;
            this.cmb_Town.DataSource = q4.ToList();
            this.cmb_Town.SelectedItem = null;

        }

        //private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        //{
        //    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        //    this.pic_1.Image = Image.FromFile(files[0]);
        //}

        //private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Copy;
        //}


        NewIspanProjectEntities dbWantModel = new NewIspanProjectEntities();


        void Read_RefreshDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.dbWantModel.TaskLists.ToList();
            //this.dataGridView1.DataSource = this.dbWantModel.CaseStatusList.ToList();
            //this.dataGridView1.DataSource = this.dbWantModel.TaskNameList.ToList();
           // this.dataGridView2.DataSource = this.dbWantModel.WorkingTimes.ToList();
        }

        
            //private void btn_ChoosePic_Click(object sender, EventArgs e)
            //{
            
            //if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        this.pic_1.Image = Image.FromFile(this.openFileDialog1.FileName);
            //    }
            //}


        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            try
            {
                {
                    //var q = from p in dbWantModel.CaseStatusLists.AsEnumerable()   //案件狀態
                    //        where p.CaseStatus == cmb_Publish.Text         
                    //        select p.CaseStatusID;
                    //int CaseNameID = q.FirstOrDefault();

                    //this.dbWantModel.SaveChanges();
                    //this.Read_RefreshDataGridView();

                    var q2 = from p in dbWantModel.TaskNameLists.AsEnumerable()   //任務類別
                             where p.TaskName == cmb_TaskNumberID.Text
                             select p.TaskNameID;
                    int TaskNameID = q2.FirstOrDefault();

                    //var q3 = from p in dbWantModel.TaskPhoto.AsEnumerable()
                    //         where p.Photo == pic_1.by
                    //         select p.Photo;

                    var q3 = from p in dbWantModel.Cities.AsEnumerable()
                             where p.City1 == cmb_City.Text
                             select p.CityID;
                    int CityID = q3.FirstOrDefault();

                    var q4 = from p in dbWantModel.Towns.AsEnumerable()
                             where p.Town1 == cmb_Town.Text
                             select p.TownID;
                    int TownID = q4.FirstOrDefault();

                    //this.dbWantModel.SaveChanges();
                    //this.Read_RefreshDataGridView();


                    //if (cmb_WorkPlace.Text == "在家兼職")
                    //{
                    //    TownID = ;
                    //    CityID = 0;
                    //    //txt_WorkPlace = null;
                    //};

                    TaskList giveJob = new TaskList
                    {
                        AccountID = CMember.AccountID,

                        TaskTitle = txt_Title.Text,
                        TaskDetail = txt_Detail.Text,

                        TaskStart = dTP_TaskDateStart.Text,   //任務期間
                        TaskEnd = dTP_TaskDateEnd.Text,
                        //任務時段在workinghour表

                        TownID = TownID,
                        Address = txt_WorkPlace.Text,   //任務地址

                        PayFrom = txt_PayFrom.Text,
                        RequiredNum = txt_People.Text,   //需求人數

                        PublishStart = dTP_Start.Text,    //刊登時間
                        PublishEnd = dTP_End.Text,

                        //CaseStatusID = CaseNameID,        //案件狀態

                        TaskNameID = TaskNameID,      //任務類型                     
                                                      //WorkPlace=cmb_WorkPlace.Text,   //任務地點，在家兼職或指定地點

                        PublishOrNot = cmb_Publish.Text    //立即上架或延後上架

                    };

                    WorkingTime workingTime = new WorkingTime
                    {
                        //WorkingDateFrom = dTP_TaskDateStart.Text,   //任務期間
                        //WorkingDateTo = dTP_TaskDateEnd.Text,
                        WorkingHoursFrom = txt_TimeStart.Text,      //任務時段
                        WorkingHoursTo = txt_TimeEnd.Text,
                    };

                    //City city = new City
                    //{
                    //    City1 = cmb_City.Text
                    //};

                    //Town town = new Town
                    //{
                    //    Town1 = cmb_Town.Text
                    //};

                    //bool hasPhoto = (pic_1.Image != null);

                    //if ( hasPhoto )
                    //{

                    //    byte[] bytes;
                    //    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    //    this.pic_1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //    bytes = ms.GetBuffer();

                    //    TaskPhoto taskPhoto = new TaskPhoto
                    //    {                            
                    //        Photo = bytes
                    //    };

                    //    this.dbWantModel.TaskPhotoes.Add( taskPhoto );
                    //}

                    this.dbWantModel.TaskLists.Add(giveJob);
                    this.dbWantModel.WorkingTimes.Add(workingTime);

                    //this.dbWantModel.City.Add(city);
                    //this.dbWantModel.Town.Add(town);

                    this.dbWantModel.SaveChanges();
                    this.Read_RefreshDataGridView();

                    // this.splitContainer1.Panel2.Controls.Clear();
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string errorMessage = $"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}";
                        MessageBox.Show(errorMessage);
                    }
                }
            }
        }

        private void cmb_City_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
            var q4 = from p in dbWantModel.Towns.AsEnumerable()
                         where cmb_City.Text == p.City.City1
                         select p.Town1;
                this.cmb_Town.DataSource = q4.ToList();
            
        }

        private void txt_TimeStart_Click_1(object sender, EventArgs e)
        {
                if (txt_TimeStart.Text == "開始時間")
                {
                    txt_TimeStart.Clear();
                }
            
        }

        private void txt_TimeEnd_Click_1(object sender, EventArgs e)
        {
                            if (txt_TimeEnd.Text == "結束時間")
                {
                    txt_TimeEnd.Clear();
                }
            
        }

        private void txt_WorkPlace_Click_1(object sender, EventArgs e)
        {
            
            if (txt_WorkPlace.Text == "例：台北市大安區")
                {
                    txt_WorkPlace.Clear();
                }
            
        }

        private void txt_PayFrom_Click_1(object sender, EventArgs e)
        {
            if (txt_PayFrom.Text == "請輸入金額")
            {
                txt_PayFrom.Clear();
            }
        }

        private void txt_People_Click_1(object sender, EventArgs e)
        {
            if (txt_People.Text == "請輸入人數")
            {
                txt_People.Clear();
            }
        }
    }
}


    

