using prjWantWantWinForm;
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
    public partial class FrmBackStage : Form
    {
        public FrmBackStage()
        {
            InitializeComponent();
        }


        private Form OpenForm(Form frm)
        {
            if (splitContainer1.Panel2 != null)
            {
               
                splitContainer1.Panel2.Controls.Clear();

                // 設置其他表單的屬性
                frm.TopLevel = false;

                // 將 Panel 加入 SplitContainer 的 Panel1 中
                splitContainer1.Panel2.Controls.Add(frm);

                // 顯示表單
                frm.Show();

                return frm;
            }
            return null;
        } 


        private void btnTask_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            FrmBackMember frm = new FrmBackMember();            
            OpenForm(frm);
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            FrmProductList frm = new FrmProductList();
            OpenForm(frm);
        }

        private void btnFourm_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FrmOrderChart frm = new FrmOrderChart();
            OpenForm(frm);
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            FrmBackServiceContact frm = new FrmBackServiceContact();
            OpenForm(frm);
        }

        private void btnGraphAnalysis_Click(object sender, EventArgs e)
        {
            FrmGraphAnalysis frm = new FrmGraphAnalysis();
            OpenForm(frm);
        }
    }
}
