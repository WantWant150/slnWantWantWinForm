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
    public partial class FrmHistory : Form
    {
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
        
        public FrmHistory()
        {
            InitializeComponent();

            ////依內容自動換行
            //dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            ////自動調欄寬
            //dataGridView1.AutoResizeColumns();

            //自動調欄高
            dataGridView2.AutoResizeRows();

            // 設定標題的 AutoSizeMode 屬性為 AllCells
            dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // 設定自動調整模式為 ColumnHeader，以便自動調整標題寬度
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //new 首頁().ShowDialog();
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

        private void Frm_已投遞_Load(object sender, EventArgs e)
        {
            var q = from al in dbContext.ApplicationLists
                    where al.CaseStatusID == 21 && al.Resume.AccountID == CMember.AccountID
                    select new
                    {
                        al.TaskList.CaseID,
                        al.TaskList.TaskTitle,
                        al.TaskList.TaskDetail,
                        al.TaskList.Town.Town1,
                        al.TaskList.PayFrom,
                        //al.TaskList.PayTo,
                        al.TaskList.RequiredNum,
                        al.TaskList.TaskStart,
                        al.TaskList.TaskEnd
                    };
            ShowDataToDataGridView(q);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q = from al in dbContext.ApplicationLists
                    where al.CaseStatusID == 21 && al.Resume.AccountID == CMember.AccountID
                    select new
                    {
                        al.TaskList.CaseID,
                        al.TaskList.TaskTitle,
                        al.TaskList.TaskDetail,
                        al.TaskList.Town.Town1,
                        al.TaskList.PayFrom,
                        //al.TaskList.PayTo,
                        al.TaskList.RequiredNum,
                        al.TaskList.TaskStart,
                        al.TaskList.TaskEnd
                    };
            ShowDataToDataGridView(q);
            comboBox4.SelectedItem = null;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if(comboBox4.Text == "已錄取")
            {
                var q = from al in dbContext.TaskLists/*ApplicationList*/
                        where al.CaseStatusID == 1                   //錄取=1 婉拒=2
                        select new
                        {
                            //al.TaskList.CaseID,
                            //al.TaskList.TaskTitle,
                            //al.TaskList.TaskDetail,
                            //al.TaskList.Town.Town1,
                            //al.TaskList.PayFrom,
                            ////al.TaskList.PayTo,
                            //al.TaskList.RequiredNum,
                            //al.TaskList.TaskStart,
                            //al.TaskList.TaskEnd


                            al.CaseID,
                            al.TaskTitle,
                            al.TaskDetail,
                            al.Town.Town1,
                            al.PayFrom,
                            //al.TaskList.PayTo,
                            al.RequiredNum,
                            al.TaskStart,
                            al.TaskEnd
                        };
                ShowDataToDataGridView(q);
            }
            else if (comboBox4.Text == "已婉拒")
            {
                var q = from al in dbContext.TaskLists          /*ApplicationList*/
                        where al.CaseStatusID == 2                   //錄取=1 婉拒=2
                        select new
                        {
                            //al.TaskList.CaseID,
                            //al.TaskList.TaskTitle,
                            //al.TaskList.TaskDetail,
                            //al.TaskList.Town.Town1,
                            //al.TaskList.PayFrom,
                            ////al.TaskList.PayTo,
                            //al.TaskList.RequiredNum,
                            //al.TaskList.TaskStart,
                            //al.TaskList.TaskEnd

                            al.CaseID,
                            al.TaskTitle,
                            al.TaskDetail,
                            al.Town.Town1,
                            al.PayFrom,
                            //al.TaskList.PayTo,
                            al.RequiredNum,
                            al.TaskStart,
                            al.TaskEnd
                        };
                ShowDataToDataGridView(q);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
