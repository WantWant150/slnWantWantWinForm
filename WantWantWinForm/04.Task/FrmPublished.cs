using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjWantWantWinForm
{
    public partial class 已上架 : Form
    {
        public 已上架()
        {
            InitializeComponent();
            var q = from p in dbWantModel.TaskNameLists   //任務類型
                    select p.TaskName;
            this.cmb_TaskNumberID.DataSource = q.ToList();
            this.cmb_TaskNumberID.SelectedItem = null;

            ////依內容自動換行
            //dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            ////自動調欄寬
            //dataGridView1.AutoResizeColumns();

            //自動調欄高
            dataGridView1.AutoResizeRows();

            // 設定標題的 AutoSizeMode 屬性為 AllCells
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // 設定自動調整模式為 ColumnHeader，以便自動調整標題寬度
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

        }

        NewIspanProjectEntities dbWantModel = new NewIspanProjectEntities();



        private void btn_Search1_Click_1(object sender, EventArgs e)
        {
            //標題跟內文兩個都是空值
            if (txt_Title.Text == "" && txt_Detail.Text == "")    //如果txt是空值，用日期去搜尋
            {
                dataGridView1.Rows.Clear();
                var q = from p in dbWantModel.TaskLists.AsEnumerable()
                        join pp in dbWantModel.TaskNameLists on p.TaskNameID equals pp.TaskNameID
                        // join tp in dbWantModel.TaskPhotoes on p.TaskPhotoID equals tp.TaskPhotoID
                        // 
                        //where p.PublishOrNot == "立刻上架" && pp.TaskName == cmb_TaskNumberID.Text

                        //where p.PublishOrNot == "立刻上架" && pp.TaskName == cmb_TaskNumberID.Text && p.TaskStart.Contains(dTP_TaskStart.Text)
                        //         || p.PublishOrNot == "立刻上架" && pp.TaskName == cmb_TaskNumberID.Text && p.TaskEnd.Contains(dTP_TaskEnd.Text)

                        //where p.PublishOrNot == "立刻上架" && pp.TaskName == cmb_TaskNumberID.Text && p.PublishStart.Contains(dTP_PublishStart.Text)
                        //        || p.PublishOrNot == "立刻上架" && pp.TaskName == cmb_TaskNumberID.Text && p.PublishEnd.Contains(dTP_PublishEnd.Text)

                        where p.PublishOrNot == "立刻上架" && 
                        pp.TaskName == cmb_TaskNumberID.Text &&
                        DateTime.Parse(p.TaskStart)>=dTP_TaskStart.Value && 
                        DateTime.Parse( p.TaskEnd )<=dTP_TaskEnd.Value


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
                //MessageBox.Show("1");

                //int i = 0;
                //q.ToList() ;

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

                //item.TaskPhotoID
                );
                    //MessageBox.Show("2");
                    //byte[] photoData = dbWantModel.TaskPhotoes.FirstOrDefault(tp => tp.TaskPhotoID == tp.TaskPhotoID)?.Photo;

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


            //標題跟內文其中一個不是空值
            else if (txt_Title.Text != "" || txt_Detail.Text != "")
            {
                dataGridView1.Rows.Clear();

                var q = from p in dbWantModel.TaskLists.AsEnumerable()
                        join pp in dbWantModel.TaskNameLists on p.TaskNameID equals pp.TaskNameID

                        //join tp in dbWantModel.TaskPhotoes on p.TaskPhotoID equals tp.TaskPhotoID

                        where p.PublishOrNot == "立刻上架" && pp.TaskName == cmb_TaskNumberID.Text && p.TaskTitle.Contains(txt_Title.Text)
                        where p.PublishOrNot == "立刻上架" && pp.TaskName == cmb_TaskNumberID.Text && p.TaskDetail.Contains(txt_Detail.Text)

            
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
                        item.TaskDetail

                        //item.TaskPhotoID
                        );

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

                    //    //PictureBox pic = new PictureBox();
                    //    //pic.Image = image;
                    //    //pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    //    //pic.Width = pictureBox1.Width;
                    //    //pic.Height = pictureBox1.Height;
                    //    //this.pictureBox1.Controls.Add(pic);

                    //}
                }
            }
            else
            {
                MessageBox.Show("請輸入搜尋條件");
            }
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            var q = from p in dbWantModel.TaskLists
                 
                    select p;

            this.dbWantModel.SaveChanges();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // 取得點擊的按鈕資料行名稱
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                // 取得所選資料行的資料
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string TaskStart = selectedRow.Cells["TaskStart"].Value.ToString();
                string TaskEnd = selectedRow.Cells["TaskEnd"].Value.ToString();
                string PublishStart = selectedRow.Cells["PublishStart"].Value.ToString();
                string PublishEnd = selectedRow.Cells["PublishEnd"].Value.ToString();
                string TaskTitle = selectedRow.Cells["TaskTitle"].Value.ToString();
                string TaskDetail = selectedRow.Cells["TaskDetail"].Value.ToString();

                // 取得其他所需的欄位資料...

                if (columnName == "unPub")
                {
                  //var q = from p in dbWantModel.TaskLists
                  //        where p.CaseStatusID=="延後上架"
                }
                else if (columnName == "Update")
                {
                    // 執行刪除操作，例如從資料庫中刪除此筆資料
                    // ...
                }
                else if (columnName == "Delete")
                {
                    // 執行下架操作，例如將狀態設定為下架並儲存到資料庫
                    // ...
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id=( int )dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            FrmPublished_New 已上架new=new FrmPublished_New();
            已上架new.ID = id;
            已上架new.已上架 = this;
            已上架new.Show();

        }
    }
}

        
    



