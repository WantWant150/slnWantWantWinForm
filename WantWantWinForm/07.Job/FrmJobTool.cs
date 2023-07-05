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
    public partial class FrmJobTool : Form
    {
        //private int accountID;
        
        public FrmJobTool()
        {
            InitializeComponent();
            //accountID = 9; 
        }

        private void btn_GiveJob_Click(object sender, EventArgs e)
        {
            //splitContainer1.Panel2.Controls.Clear();
            //Frm_找工作 找工作 = new Frm_找工作();
            //找工作.TopLevel = false;
            //splitContainer1.Panel2.Controls.Add(找工作);
            //找工作.Show();
        }

        private void tsp_GaveJob_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FrmHistory 已發包 = new FrmHistory();
            已發包.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(已發包);
            已發包.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FrmCollection 收藏案件 = new FrmCollection();
            收藏案件.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(收藏案件);
            收藏案件.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FrmResume 履歷 = new FrmResume();
            //履歷.AccountID = accountID;
            履歷.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(履歷);
            履歷.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //splitContainer1.Panel2.Controls.Clear();
            //出任務 出任務  = new 出任務();
            //出任務.TopLevel = false;
            //splitContainer1.Panel2.Controls.Add(出任務);
            //出任務.Show();  //隱藏
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Frm_找工作_DataGridView_ 找工作 = new Frm_找工作_DataGridView_();
            找工作.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(找工作);
            找工作.Show();
        }
    }
}
