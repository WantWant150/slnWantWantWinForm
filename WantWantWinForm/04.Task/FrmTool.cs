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
    public partial class FrmTool : Form
    {
        public FrmTool()
        {
            InitializeComponent();
        }

        private void btn_GiveJob_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FrmTask 出任務 = new FrmTask();
            出任務.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(出任務);
            出任務.Show();
        }

        private void tsp_GaveJob_Click_1(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            已上架 已發包 = new 已上架();
            已發包.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(已發包);
            已發包.Show();
        }


        private void tsp_Saved_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FrmNotPublish 已儲存 = new FrmNotPublish();
            已儲存.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(已儲存);
            已儲存.Show();
        }

        private void tsp_App_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FrmEmployee 求職表 = new FrmEmployee();
            求職表.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(求職表);
            求職表.Show();
        }

        private void tsp_Acc_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FrmApproved 錄取結果 = new FrmApproved();
            錄取結果.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(錄取結果);
            錄取結果.Show();
        }
    }
}
