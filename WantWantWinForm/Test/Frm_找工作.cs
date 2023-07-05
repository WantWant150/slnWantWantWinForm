using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期中
{
    public partial class Frm_找工作 : Form
    {
        public Frm_找工作()
        {
            InitializeComponent();

            DateTime defaultDate = DateTime.Today.AddDays(-7);

            // 設置DateTimePicker的值為計算得到的日期
            dateTimePicker1.Value = defaultDate;

            //var q = from c in dbContext.City
            //        select c.City1;
            // this.comboBox8.DataSource = q.ToList();
            //this.comboBox8.SelectedItem = null;
        }

        //NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        private void button2_Click(object sender, EventArgs e)
        {
            //new 首頁().Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //var q = from t in dbContext.TaskList
            //        select new {t.TaskTitle,t.TaskDetail,t.PayFrom,t.RequiredNum,};
            //var result = q.FirstOrDefault();

            //label26.Text = result.TaskTitle;
            //label39.Text = result.TaskDetail;
            //label29.Text = result.PayFrom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.flowLayoutPanel1.Controls.Clear();
            //var q = from t in dbContext.TaskList
            //        select new { t.TaskTitle, t.TaskDetail, t.PayFrom, t.RequiredNum, };
            //var result = q.ToList();

            //foreach (var item in q)
            //{
            //    Job job = new Job();
            //    job.LabRegion = item.TaskTitle;
            //    job.LabDescription = item.TaskDetail;
            //    //job.Click += Job_Click;    //請無視
            //    this.flowLayoutPanel1.Controls.Add(job);
            //}
        }

        private void Job_Click(object sender, EventArgs e)
        {
            //Job clickedJob = (Job)sender;  //請無視
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var q = from t in dbContext.Town
            //        where comboBox8.Text == t.City.City1 
            //        select t.Town1;
            //this.comboBox9.DataSource = q.ToList();
        }
    }
}
