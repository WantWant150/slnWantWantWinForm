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


        /*
        #region 表單加入Panel
        private Form AddPanel(Form frm)
        {
            // 設置其他表單的屬性
            frm.TopLevel = false;

            // 將 Panel 加入 SplitContainer 的 Panel1 中
            splitContainer1.Panel2.Controls.Add(frm);

            // 顯示表單
            frm.Show();

            return frm;
        }
        #endregion
        */


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
            FrmMember frm = new FrmMember();
            MessageBox.Show("2");
            OpenForm(frm);
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {

        }

        private void btnFourm_Click(object sender, EventArgs e)
        {

        }
    }
}
