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
    public partial class FrmCollection : Form
    {
        public Frm_找工作_DataGridView_ findjob
        {
            get; set;
        }
        public int ID
        {
            get; set;
        }

        public FrmCollection()
        {
            InitializeComponent();

            //Job job = new Job();
            //job.FlowLayoutPanel = flowLayoutPanel1;
            //flowLayoutPanel1.Controls.Add(job);
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

            NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        private void Frm_收藏案件_Load(object sender, EventArgs e)
        {
            var q = from mc in dbContext.MemberCollections
                  //where mc.CaseID == ID && mc.AccountID == CMember.AccountID
                    where mc.AccountID == CMember.AccountID && mc.CaseID != null
                    select new
                     {
                         mc.TaskList.CaseID,
                         mc.TaskList.TaskTitle,
                         mc.TaskList.TaskDetail,
                         mc.TaskList.Town.Town1,
                         mc.TaskList.PayFrom,
                         //mc.TaskList.PayTo,
                         mc.TaskList.RequiredNum,
                         mc.TaskList.TaskStart,
                         mc.TaskList.TaskEnd
                     };
            ShowDataToDataGridView(q);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var q = (from mc in dbContext.MemberCollection
            //         where mc.CaseID == ID && mc.AccountID == CMember.AccountID && mc.CaseID != null  
            //         select mc).FirstOrDefault();

            //this.dbContext.MemberCollection.Remove(q);
            //dbContext.SaveChanges();
            //MessageBox.Show("已刪除");

            //int id = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
            //Frm_工作詳細頁面 工作詳細頁面 = new Frm_工作詳細頁面();
            //工作詳細頁面.ID = id;
            ////工作詳細頁面.findjob = this;
            //工作詳細頁面.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int id = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.FirstDisplayedScrollingRowIndex = 0;
            }
          catch (Exception ex)
            {
                MessageBox.Show("目前沒有收藏資料");
            }
        }
    }
}
