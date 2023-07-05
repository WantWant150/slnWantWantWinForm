using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
    public partial class FrmNotPublish : Form
    {
        public FrmNotPublish()
        {
            InitializeComponent();

            var q = from p in dbWantModel.TaskNameLists
                    select p.TaskName;
            this.cmb_TaskNumberID.DataSource = q.ToList();
            this.cmb_TaskNumberID.SelectedItem = null;

            ////依內容自動換行
            //dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //自動調欄寬
            //dataGridView1.AutoResizeColumns();

            //自動調欄高
            dataGridView1.AutoResizeRows();

            // 設定標題的 AutoSizeMode 屬性為 AllCells
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // 設定自動調整模式為 ColumnHeader，以便自動調整標題寬度
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

        }

        NewIspanProjectEntities dbWantModel = new NewIspanProjectEntities();


        void Read_RefreshDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.dbWantModel.TaskLists.ToList();
        }

     
        private void btn_Update_Click(object sender, EventArgs e)
        {
            this.dbWantModel.SaveChanges();
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_Title.Text == "" && txt_Detail.Text == "")    //如果txt是空值，用日期去搜尋
                {
                    dataGridView1.Rows.Clear();
                    var q = from p in dbWantModel.TaskLists.AsEnumerable()
                            join pp in dbWantModel.TaskNameLists on p.TaskNameID equals pp.TaskNameID
                            //join tp in dbWantModel.TaskPhotoes on p.TaskPhotoID equals tp.TaskPhotoID
                            // 
                            //where p.PublishOrNot == "立刻上架" && pp.TaskName == cmb_TaskNumberID.Text

                            //where p.PublishOrNot == "延後上架" && pp.TaskName == cmb_TaskNumberID.Text && p.TaskStart.Contains(dTP_TaskStart.Text)
                            //         || p.PublishOrNot == "延後上架" && pp.TaskName == cmb_TaskNumberID.Text + p.TaskEnd.Contains(dTP_TaskEnd.Text)

                            //where p.PublishOrNot == "延後上架" && pp.TaskName == cmb_TaskNumberID.Text && p.PublishStart.Contains(dTP_PublishStart.Text)
                            //        || p.PublishOrNot == "延後上架" && pp.TaskName == cmb_TaskNumberID.Text && p.PublishEnd.Contains(dTP_PublishEnd.Text)

                            where p.PublishOrNot == "延後上架" &&
                                        pp.TaskName == cmb_TaskNumberID.Text &&
                                        p.CaseStatusID!=5 &&
                                        DateTime.Parse(p.TaskStart) >= dTP_TaskStart.Value &&
                                        DateTime.Parse(p.TaskEnd) <= dTP_TaskEnd.Value

                            select new
                            {
                                p.CaseID,

                                p.TaskStart,
                                p.TaskEnd,

                                p.PublishStart,
                                p.PublishEnd,

                                p.TaskTitle,
                                p.TaskDetail,


                                //tp.TaskPhotoID,
                                //tp.Photo

                            };

                    dataGridView1.Rows.Clear(); // 清空 dataGridView1 中的資料

                    foreach (var item in q)
                    {
                        dataGridView1.Rows.Add(

                            item.CaseID,

                            item.TaskStart,
                            item.TaskEnd,

                            item.PublishStart,
                            item.PublishEnd,

                            item.TaskTitle,
                            item.TaskDetail

                    //   item.TaskPhotoID                        
                    );

                        //if (item.Photo != null)    //如果有傳照片的話
                        //{
                        //    Image image;
                        //    using (MemoryStream ms = new MemoryStream(item.Photo))
                        //    {
                        //        image = Image.FromStream(ms);
                        //    }

                        //    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                        //    imageCell.Value = image;

                        //    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["column7"] = imageCell;

                        //byte[] photoData = dbWantModel.TaskPhotoes.FirstOrDefault(tp => tp.TaskPhotoID == tp.TaskPhotoID)?.Photo;

                        //if (photoData != null)
                        //{
                        //    Image image;
                        //    using (MemoryStream ms = new MemoryStream(photoData))
                        //    {
                        //        image = Image.FromStream(ms);
                        //    }

                        //PictureBox pic = new PictureBox();
                        //pic.Image = image;
                        //pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        //pic.Width = pictureBox1.Width;
                        //pic.Height = pictureBox1.Height;
                        //this.pictureBox1.Controls.Add(pic);

                    }
                }


                else if (txt_Title.Text != "" || txt_Detail.Text != "")
                {
                    dataGridView1.Rows.Clear();

                    var q = from p in dbWantModel.TaskLists.AsEnumerable()
                            join pp in dbWantModel.TaskNameLists on p.TaskNameID equals pp.TaskNameID

                            join tp in dbWantModel.TaskPhotoes on p.TaskPhotoID equals tp.TaskPhotoID

                            where p.PublishOrNot == "延後上架" && pp.TaskName == cmb_TaskNumberID.Text && p.TaskTitle.Contains(txt_Title.Text)
                            where p.PublishOrNot == "延後上架" && pp.TaskName == cmb_TaskNumberID.Text && p.TaskDetail.Contains(txt_Detail.Text)

                            select new
                            {
                                p.CaseID,

                                p.TaskStart,
                                p.TaskEnd,

                                p.PublishStart,
                                p.PublishEnd,

                                p.TaskTitle,
                                p.TaskDetail

                                //tp.TaskPhotoID,
                                //tp.Photo

                            };

                    dataGridView1.Rows.Clear();

                    foreach (var item in q)
                    {
                        dataGridView1.Rows.Add(

                            item.CaseID,

                            item.TaskStart,
                            item.TaskEnd,

                            item.PublishStart,
                            item.PublishEnd,

                            item.TaskTitle,
                            item.TaskDetail);

                        //if (item.Photo != null)
                        //{
                        //    Image image;
                        //    using (MemoryStream ms = new MemoryStream(item.Photo))
                        //    {
                        //        image = Image.FromStream(ms);
                        //    }

                        //    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                        //    imageCell.Value = image;

                        //    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["column7"] = imageCell;

                        //PictureBox pic = new PictureBox();
                        //pic.Image = image;
                        //pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        //pic.Width = pictureBox1.Width;
                        //pic.Height = pictureBox1.Height;
                        //this.pictureBox1.Controls.Add(pic);
                    }
                }
                else
                {
                    MessageBox.Show("請輸入搜尋條件");
                }
            }
            catch  (Exception ex)
                { 
                MessageBox.Show(ex.Message);
                }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            FrmNotPublish_New 未上架new = new FrmNotPublish_New();
            未上架new.ID = id;
            未上架new.未上架 = this;
            未上架new.Show();
        }
    }
}
