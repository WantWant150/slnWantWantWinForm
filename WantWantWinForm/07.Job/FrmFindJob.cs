using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
    public partial class Frm_找工作_DataGridView_ : Form
    {
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        public Frm_找工作_DataGridView_()
        {
            InitializeComponent();

            DateTime defaultDate = DateTime.Today.AddDays(-7);    // 設置DateTimePicker的值為計算得到的日期
            dateTimePicker1.Value = defaultDate;

            var q1 = from c in dbContext.Cities       //載入城市
                     select c.City1;
            this.comboBox8.DataSource = q1.ToList();
            this.comboBox8.SelectedItem = null;

            var q2 = from t in dbContext.TaskNameLists   //載入任務類型
                     select t.TaskName;
            this.comboBox1.DataSource = q2.ToList();
            this.comboBox1.SelectedItem = null;

            var q3 = (from t in dbContext.TaskLists.AsEnumerable()
                      where t.PublishOrNot == "立刻上架"        //載入薪資起
                      orderby int.Parse(t.PayFrom)
                      select t.PayFrom).Distinct();
            this.comboBox4.DataSource = q3.ToList();
            this.comboBox4.SelectedItem = null;

            //var q4 = (from t in dbContext.TaskList.AsEnumerable()     //載入薪資迄
            //          where !string.IsNullOrEmpty(t.PayTo)
            //          orderby int.Parse(t.PayTo)                       //(PayTo型別為nvarchar(50),需要轉型才能排序)
            //          select t.PayTo).Distinct();
            //this.comboBox3.DataSource = q4.ToList();
            //this.comboBox3.SelectedItem = null;

            var q5 = (from t in dbContext.TaskLists.AsEnumerable()      //載入需求人數
                      where t.PublishOrNot == "立刻上架"
                      orderby int.Parse(t.RequiredNum)
                      select t.RequiredNum).Distinct();
            this.comboBox2.DataSource = q5.ToList();
            this.comboBox2.SelectedItem = null;

            //this.pictureBox1.DataBindings.Add("Image", bindingSource1, "Picture", true);
            //this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            var q6 = from t in dbContext.TaskLists              //熱門任務
                     where t.OnTop != null
                     select new
                     {
                         t.CaseID,
                         t.TaskTitle,
                         t.TaskDetail,
                         t.Town.Town1,
                         t.PayFrom,
                         //t.PayTo,
                         t.RequiredNum,
                         t.TaskStart,
                         t.TaskEnd
                     };
            dataGridView1.Rows.Clear();
            foreach (var item in q6)
            {
                dataGridView1.Rows.Add
                    (
                        item.CaseID,
                        item.TaskTitle,
                        item.TaskDetail,
                        item.Town1,
                        item.PayFrom,
                        //item.PayTo,
                        item.RequiredNum,
                        item.TaskStart,
                        item.TaskEnd
                    );
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)   //選擇城市後,載入對應的鄉鎮
        {
            var q = from t in dbContext.Towns
                    where comboBox8.Text == t.City.City1
                    select t.Town1;
            this.comboBox9.DataSource = q.ToList();
        }

        private void ShowDataToDataGridView(IEnumerable<dynamic> q)  //foreach迴圈做成方法
        {
            dataGridView2.Rows.Clear();
            foreach (var item in q)
            {
                dataGridView2.Rows.Add
                    (
                        item.CaseID,
                        item.TaskTitle,
                        item.TaskDetail,
                        item.Town1,
                        item.PayFrom,
                        //item.PayTo,
                        item.RequiredNum,
                        item.TaskStart,
                        item.TaskEnd
                    );
            }
            lab_Count.Text = $"共有{q.Count()}筆資料";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            #region 廢物           
            //var q1 = from t in dbContext.TaskList              //關鍵字模糊搜尋
            //         where t.TaskTitle.Contains(textBox1.Text) || t.TaskDetail.Contains(textBox1.Text)
            //         select new
            //         {
            //             t.CaseID,
            //             t.TaskTitle,
            //             t.TaskDetail,
            //             t.PayFrom,
            //             t.PayTo,
            //             t.RequiredNum,
            //             t.TaskStart,
            //             t.TaskEnd
            //         };
            //this.dataGridView2.Rows.Clear();

            //foreach (var item in q1)
            //{
            //    dataGridView2.Rows.Add(item.CaseID,item.TaskTitle,item.TaskDetail,item.PayFrom,item.PayTo,item.RequiredNum,item.TaskStart,item.TaskEnd);
            //}

            //var q2 = from t in dbContext.TaskList           //以鄉鎮查詢符合的Task
            //        where t.Town.Town1 == comboBox9.Text && t.Town.City.City1 == comboBox8.Text  //單以鄉鎮查詢的話可能會有縣市重複的地名,條件必須包含市
            //        select t;
            //this.dataGridView1.DataSource = q2.ToList();

            #region 模糊搜尋?
            //var q2 = from t in dbContext.TaskList
            //         where t.Town.Town1.Contains(comboBox9.Text)      //Contain == 模糊搜尋?
            //         select t;
            //this.dataGridView1.DataSource = q2.ToList();
            #endregion

            //var q3 = from t in dbContext.TaskList             //以任務類型查詢符合的Task
            //         where t.TaskNameList.TaskName == comboBox1.Text
            //         select new
            //         {
            //             t.CaseID,
            //             t.TaskTitle,
            //             t.TaskDetail,
            //             t.PayFrom,
            //             t.PayTo,
            //             t.RequiredNum,
            //             t.TaskStart,
            //             t.TaskEnd
            //         };
            //this.dataGridView2.DataSource = q3.ToList();

            //if (comboBox4.SelectedItem != null)                 //以薪資區間查詢(或是只有薪資起始值查詢)
            //{
            //    var q4 = from t in dbContext.TaskList.AsEnumerable()
            //             where int.Parse(t.PayFrom) >= int.Parse(comboBox4.Text) || int.Parse(t.PayFrom) >= int.Parse(comboBox4.Text) && int.Parse(t.PayTo) <= int.Parse(comboBox3.Text)
            //             select t;
            //    this.dataGridView2.DataSource = q4.ToList();
            //}


            //var q5 = from t in dbContext.TaskList.AsEnumerable()          //以任務時間區間查詢
            //         where DateTime.Parse(t.TaskStart) >= dateTimePicker1.Value && DateTime.Parse(t.TaskEnd) <= dateTimePicker2.Value         //TaskStart 型別是nvarchar(50)
            //         select t;
            //this.dataGridView1.DataSource = q5.ToList();

            //var q6 = from t in dbContext.TaskList                     //以任務需求人數查詢
            //         where t.RequiredNum == comboBox2.Text
            //         select t;
            //this.dataGridView1.DataSource = q6.ToList();


            //var q7 = from t in dbContext.TaskList.AsEnumerable()
            //         where t.TaskTitle.Contains(textBox1.Text) || t.TaskDetail.Contains(textBox1.Text) &&
            //               t.Town.Town1 == comboBox9.Text && t.Town.City.City1 == comboBox8.Text &&
            //               t.TaskNameList.TaskName == comboBox1.Text &&
            //               int.Parse(t.PayFrom) >= int.Parse(comboBox4.Text) || int.Parse(t.PayFrom) >= int.Parse(comboBox4.Text) && int.Parse(t.PayTo) <= int.Parse(comboBox3.Text) &&
            //               DateTime.Parse(t.TaskStart) >= dateTimePicker1.Value && DateTime.Parse(t.TaskEnd) <= dateTimePicker2.Value &&
            //               t.RequiredNum == comboBox2.Text
            //         select new
            //         {
            //             t.CaseID,
            //             t.TaskTitle,
            //             t.TaskDetail,
            //             t.PayFrom,
            //             t.PayTo,
            //             t.RequiredNum,
            //             t.TaskStart,
            //             t.TaskEnd
            //         };
            //this.dataGridView2.Rows.Clear();

            //var q7 = from t in dbContext.TaskList.AsEnumerable()
            //         where (string.IsNullOrEmpty(textBox1.Text) || t.TaskTitle.Contains(textBox1.Text) || t.TaskDetail.Contains(textBox1.Text)) &&
            //               (string.IsNullOrEmpty(comboBox9.Text) || t.Town.Town1 == comboBox9.Text) &&
            //               (string.IsNullOrEmpty(comboBox8.Text) || t.Town.City.City1 == comboBox8.Text) &&
            //               (string.IsNullOrEmpty(comboBox1.Text) || t.TaskNameList.TaskName == comboBox1.Text) &&
            //               (string.IsNullOrEmpty(comboBox4.Text) || int.Parse(t.PayFrom) >= int.Parse(comboBox4.Text)) &&
            //               (string.IsNullOrEmpty(comboBox3.Text) || int.Parse(t.PayTo) <= int.Parse(comboBox3.Text)) &&
            //               (dateTimePicker1.Value == null || DateTime.Parse(t.TaskStart) >= dateTimePicker1.Value) &&
            //               (dateTimePicker2.Value == null || DateTime.Parse(t.TaskEnd) <= dateTimePicker2.Value) &&
            //               (string.IsNullOrEmpty(comboBox2.Text) || t.RequiredNum == comboBox2.Text)
            //         select new
            //         {
            //             t.CaseID,
            //             t.TaskTitle,
            //             t.TaskDetail,
            //             t.PayFrom,
            //             t.PayTo,
            //             t.RequiredNum,
            //             t.TaskStart,
            //             t.TaskEnd
            //         };

            //this.dataGridView2.Rows.Clear();

            //foreach (var item in q7)
            //{
            //    dataGridView2.Rows.Add(item.CaseID, item.TaskTitle, item.TaskDetail, item.PayFrom, item.PayTo, item.RequiredNum, item.TaskStart, item.TaskEnd);
            //}
            #endregion
            //if (comboBox8.Text == null)
            //{
            var q = from t in dbContext.TaskLists           //關鍵字模糊搜尋
                    where t.PublishOrNot == "立刻上架" && t.Town.Town1 == comboBox9.Text && t.Town.City.City1 == comboBox8.Text
                    select new
                    {
                        t.CaseID,
                        t.TaskTitle,
                        t.TaskDetail,
                        t.Town.Town1,
                        t.PayFrom,
                        //t.PayTo,
                        t.RequiredNum,
                        t.TaskStart,
                        t.TaskEnd
                    };
            ShowDataToDataGridView(q);
            //}
            //else if (textBox1.Text == null)
            //    {
            //    var q1 = from t in dbContext.TaskLists           //關鍵字模糊搜尋
            //             where t.PublishOrNot == "立刻上架" && (t.TaskTitle.Contains(textBox1.Text) || t.TaskDetail.Contains(textBox1.Text)) && t.Town.Town1 == comboBox9.Text && t.Town.City.City1 == comboBox8.Text
            //             select new
            //             {
            //                 t.CaseID,
            //                 t.TaskTitle,
            //                 t.TaskDetail,
            //                 t.Town.Town1,
            //                 t.PayFrom,
            //                 //t.PayTo,
            //                 t.RequiredNum,
            //                 t.TaskStart,
            //                 t.TaskEnd
            //             };
            //    ShowDataToDataGridView(q1);
            //}
            //else
            //{
            //    var q1 = from t in dbContext.TaskLists           //關鍵字模糊搜尋
            //            where t.PublishOrNot == "立刻上架" && (t.TaskTitle.Contains(textBox1.Text) || t.TaskDetail.Contains(textBox1.Text)) && t.Town.Town1 == comboBox9.Text && t.Town.City.City1 == comboBox8.Text
            //            select new
            //            {
            //                t.CaseID,
            //                t.TaskTitle,
            //                t.TaskDetail,
            //                t.Town.Town1,
            //                t.PayFrom,
            //                //t.PayTo,
            //                t.RequiredNum,
            //                t.TaskStart,
            //                t.TaskEnd
            //            };
            //    ShowDataToDataGridView(q1);
            //}
            //var q = from t in dbContext.TaskList           //關鍵字模糊搜尋
            //        where t.PublishOrNot == "立刻上架" && (t.TaskTitle.Contains(textBox1.Text) || t.TaskDetail.Contains(textBox1.Text)) || t.Town.Town1 == comboBox9.Text && t.Town.City.City1 == comboBox8.Text
            //        //where t.PublishOrNot == "立刻上架" && (t.TaskTitle.Contains(textBox1.Text) || t.TaskDetail.Contains(textBox1.Text)) && t.Town.Town1 == comboBox9.Text && t.Town.City.City1 == comboBox8.Text
            //        select new
            //         {
            //             t.CaseID,
            //             t.TaskTitle,
            //             t.TaskDetail,
            //             t.Town.Town1,
            //             t.PayFrom,
            //             //t.PayTo,
            //             t.RequiredNum,
            //             t.TaskStart,
            //             t.TaskEnd
            //         };
            //ShowDataToDataGridView(q);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "請輸入關鍵字")
            {
                textBox1.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = from t in dbContext.TaskLists
                    where t.TaskNameList.TaskName == comboBox1.Text && t.PublishOrNot == "立刻上架"
                    select new
                    {
                        t.CaseID,
                        t.TaskTitle,
                        t.TaskDetail,
                        t.Town.Town1,
                        t.PayFrom,
                        //t.PayTo,
                        t.RequiredNum,
                        t.TaskStart,
                        t.TaskEnd
                    };
            ShowDataToDataGridView(q);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null)
            {
                var q = from t in dbContext.TaskLists.AsEnumerable()
                        where t.PublishOrNot == "立刻上架" && int.Parse(t.PayFrom) /*>=*/ == int.Parse(comboBox4.Text) /*|| int.Parse(t.PayFrom) >= int.Parse(comboBox4.Text) && int.Parse(t.PayTo) <= int.Parse(comboBox3.Text)*/
                        select new
                        {
                            t.CaseID,
                            t.TaskTitle,
                            t.TaskDetail,
                            t.Town.Town1,
                            t.PayFrom,
                            //t.PayTo,
                            t.RequiredNum,
                            t.TaskStart,
                            t.TaskEnd
                        };
                ShowDataToDataGridView(q);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)   //回到頂部
        {
            try
            {
                dataGridView2.FirstDisplayedScrollingRowIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("目前沒有資料");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var q = from t in dbContext.TaskLists.AsEnumerable()
                    where t.PublishOrNot == "立刻上架" && DateTime.Parse(t.TaskStart) >= dateTimePicker1.Value && DateTime.Parse(t.TaskEnd) <= dateTimePicker2.Value         //TaskStart 型別是nvarchar(50)
                    select new
                    {
                        t.CaseID,
                        t.TaskTitle,
                        t.TaskDetail,
                        t.Town.Town1,
                        t.PayFrom,
                        //t.PayTo,
                        t.RequiredNum,
                        t.TaskStart,
                        t.TaskEnd
                    };
            ShowDataToDataGridView(q);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var q = from t in dbContext.TaskLists
                    where t.PublishOrNot == "立刻上架" &&t.RequiredNum == comboBox2.Text
                    select new
                    {
                        t.CaseID,
                        t.TaskTitle,
                        t.TaskDetail,
                        t.Town.Town1,
                        t.PayFrom,
                        //t.PayTo,
                        t.RequiredNum,
                        t.TaskStart,
                        t.TaskEnd
                    };
            ShowDataToDataGridView(q);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
                FrmJobDetail 工作詳細頁面 = new FrmJobDetail();
                工作詳細頁面.ID = id;
                工作詳細頁面.findjob = this;
                工作詳細頁面.ShowDialog();

                FrmCollection 收藏案件 = new FrmCollection();

                收藏案件.ID = id;
                收藏案件.findjob = this;
            }
            catch
            {

            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                FrmJobDetail 工作詳細頁面 = new FrmJobDetail();
                工作詳細頁面.ID = id;
                工作詳細頁面.findjob = this;
                工作詳細頁面.ShowDialog();
            }
            catch
            {

            }          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var q = from t in dbContext.TaskLists           //關鍵字模糊搜尋
                    where t.PublishOrNot == "立刻上架" &&(t.TaskTitle.Contains(textBox1.Text) || t.TaskDetail.Contains(textBox1.Text))
                    select new
                    {
                        t.CaseID,
                        t.TaskTitle,
                        t.TaskDetail,
                        t.Town.Town1,
                        t.PayFrom,
                        //t.PayTo,
                        t.RequiredNum,
                        t.TaskStart,
                        t.TaskEnd
                    };
            ShowDataToDataGridView(q);
        }
    }
}
