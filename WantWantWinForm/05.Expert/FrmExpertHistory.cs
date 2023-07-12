using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
    public partial class FrmExpertHistory : Form
    {
        public FrmExpertHistory()
        {
            InitializeComponent();
        }
        NewIspanProjectEntities db = new NewIspanProjectEntities();
        int member = CMember.AccountID;
        private void ExpertHistory_Load(object sender, EventArgs e)
        {
            //15是專家尚未確認16是拒絕17進行中18是完成
            #region 委託者看

 
            var q = from t in db.TaskLists
                    join ma in db.MemberAccounts on t.AccountID equals ma.AccountID
                  
                    join ea in db.ExpertApplications on t.CaseID equals ea.CaseID
                    join cs in db.CaseStatusLists on ea.CaseStatusID equals cs.CaseStatusID
                    where t.ExpertApplications.FirstOrDefault().AccountID == member
                    select new
                    {
                        案件編號= t.ExpertApplications.FirstOrDefault().CaseID,
                        工作內容 = t.TaskDetail,
                        金額 = t.PayFrom,
                        工作地點 = t.WorkPlace,
                        工作時間起 = t.TaskStart,
                        工作時間訖 = t.TaskEnd,
                        被委託人 = ma.Name,
                        委託狀態 = cs.CaseStatus,
                        委託狀態代碼 = ea.CaseStatusID,
                        委託日期 = t.DataCreateDate
                     };
            this.dataGridView4.DataSource = q.ToList();
            #endregion
            #region 專家看
            Expertviewhistory();
            //var q1 = from t in db.TaskLists
            //         join ea in db.ExpertApplications on t.CaseID equals ea.CaseID
            //         join ma in db.MemberAccounts on ea.AccountID equals ma.AccountID
            //         join cs in db.CaseStatusLists on ea.CaseStatusID equals cs.CaseStatusID
            //         where t.AccountID == member /*&& ea.CaseStatusID == 15*/
            //         select new
            //         {
            //             案件編號 = ea.CaseID,
            //             工作內容 = t.TaskDetail,
            //             金額 = t.PayFrom,
            //             工作地點 = t.WorkPlace,
            //             工作時間起 = t.TaskStart,
            //             工作時間訖 = t.TaskEnd,


            //             委託人 = ma.Name,
            //             委託狀態 = cs.CaseStatus,
            //             委託狀態代碼 = ea.CaseStatusID,
            //             委託日期 = t.DataCreateDate

            //         };
            //this.dataGridView1.DataSource = q1.ToList();
            #endregion

        }
        void Expertviewhistory(){
            var q2 = from t in db.TaskLists
                     join ea in db.ExpertApplications on t.CaseID equals ea.CaseID
                     join ma in db.MemberAccounts on ea.AccountID equals ma.AccountID
                     join cs in db.CaseStatusLists on ea.CaseStatusID equals cs.CaseStatusID
                     where t.AccountID == member /*&& ea.CaseStatusID == 15*/
                     select new
                     {
                         案件編號 = ea.CaseID,
                         工作內容 = t.TaskDetail,
                         金額 = t.PayFrom,
                         工作地點 = t.WorkPlace,
                         工作時間起 = t.TaskStart,
                         工作時間訖 = t.TaskEnd,
                         委託人 = ma.Name,
                         委託狀態 = cs.CaseStatus,
                         委託狀態代碼 = ea.CaseStatusID,
                         委託日期 = t.DataCreateDate

                     };
            this.dataGridView1.DataSource = q2.ToList();
        }
        int row;
        int column;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //第一排按鈕
            if (dataGridView1.Columns[e.ColumnIndex].Name == "check" && e.RowIndex >= 0)
            {
                if (e.RowIndex < dataGridView1.Rows.Count)
                {
        
                    column = e.ColumnIndex;
                    row = e.RowIndex;

                    if ((int)dataGridView1.Rows[row].Cells[11].Value == 15)
                    {

                        DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[3];
                        var qstatus = (from ea in db.ExpertApplications

                                       where ea.CaseID == (int)cell.Value
                                       select ea).FirstOrDefault();

                        qstatus.CaseStatusID = 17;
                        db.SaveChanges();
                        MessageBox.Show("成功接案");

                        Expertviewhistory();


                    }
                    else if ((int)dataGridView1.Rows[row].Cells[11].Value == 16)
                    {
                        MessageBox.Show("已拒絕接本案件");

                    }
                    else if ((int)dataGridView1.Rows[row].Cells[11].Value == 17)
                    {
                        MessageBox.Show("本案件已接受");

                    }
                    else if ((int)dataGridView1.Rows[row].Cells[11].Value == 18)
                    {
                        MessageBox.Show("本案件已完成");

                    }

                }

            }


            //第二排按鈕
            if (dataGridView1.Columns[e.ColumnIndex].Name == "No" && e.RowIndex >= 0)
            {


                if (e.RowIndex < dataGridView1.Rows.Count)
                {
       
                    if ((int)dataGridView1.Rows[row].Cells[11].Value == 15)
                    {
                        DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[3];
                        var qstatus = (from ea in db.ExpertApplications

                                       where ea.CaseID == (int)cell.Value
                                       select ea).FirstOrDefault();

                        qstatus.CaseStatusID = 16;
                        db.SaveChanges();
                        MessageBox.Show("拒絕接案");

                        Expertviewhistory();


                    }
                    else if ((int)dataGridView1.Rows[row].Cells[11].Value == 16)
                    {
                        MessageBox.Show("已拒絕接本案件");

                    }
                    else if ((int)dataGridView1.Rows[row].Cells[11].Value == 17)
                    {
                        MessageBox.Show("本案件已接受");

                    }
                    else if ((int)dataGridView1.Rows[row].Cells[11].Value == 18)
                    {
                        MessageBox.Show("本案件已完成");

                    }

                }
            }

            //第三排按鈕
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Finish" && e.RowIndex >= 0)
            {


                if (e.RowIndex < dataGridView1.Rows.Count)
                {

                    if ((int)dataGridView1.Rows[row].Cells[11].Value == 17)
                    {

                        //取得該行的第四個資料格
                        DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[3];
                    var qstatus = (from ea in db.ExpertApplications

                                   where ea.CaseID == (int)cell.Value
                                   select ea).FirstOrDefault();

                    qstatus.CaseStatusID = 18;
                    db.SaveChanges();
                    MessageBox.Show("案件完成");

                    Expertviewhistory();
                    }
                    else if ((int)dataGridView1.Rows[row].Cells[11].Value == 16)
                    {
                        MessageBox.Show("已拒絕接本案件");

                    }
                    else if ((int)dataGridView1.Rows[row].Cells[11].Value == 17)
                    {
                        MessageBox.Show("本案件已接受");

                    }
                    else if ((int)dataGridView1.Rows[row].Cells[11].Value == 18)
                    {
                        MessageBox.Show("本案件已完成");

                    }


                }

            }


        }

      


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var buttonCell = dataGridView1.Rows[row].Cells[column] as DataGridViewButtonCell;

                //// 根據特定條件來設定按鈕的可見性或啟用狀態
                //if (yourCondition)
                //{
                //    buttonCell.Visible = false; // 隱藏按鈕
                //                                // 或者
                //    buttonCell.ReadOnly = true; // 禁用按鈕
                //}
            }
        }

    }
}
