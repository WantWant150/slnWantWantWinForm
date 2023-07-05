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
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();

        }


        private void FrmIndex_Load(object sender, EventArgs e)
        {
            login();
        }


        #region 顯示視窗方法
        public void ShowForm(Form frm)
        {
            // Show Form and Close Now Use Form
            try
            {
                //if (this.ActiveMdiChild != null)
                //    this.ActiveMdiChild.Close();
                //if (frm.IsMdiContainer)
                //{
                //**8****9**
                if (Back.backstageCancel != "Cancel")
                {
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }

            }

       // }
          catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region 會員登入介面
        private void login()
        {
            //顯示登入介面
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
            login.MdiParent = this;
            if (login.DialogResult == DialogResult.OK) //會員成功登入時
            {
                login.Dispose();

                if (CLoginInfo.memInfoFinished) //會員成功登入，就會跳出屬於他的主畫面
                {
                    NewIspanProjectEntities dbContext = new NewIspanProjectEntities();
                    int MemberRoleID = (from mem in dbContext.MemberRoleConns
                                       where mem.AccountID == CMember.AccountID
                                       select mem.RoleID).FirstOrDefault();
                    if (MemberRoleID==1)   //如果判斷是會員，要秀出Form1TskSearch在mdi子表單
                    {
                        //因為在註冊帳號時就會有設定角色會員或客服了，所以有找到的話一定是First
                        MessageBox.Show("歡迎光臨會員");
                        Form1TskSearch frm = new Form1TskSearch();
                        ShowForm(frm);
                    }
                    else if (MemberRoleID == 2) //如果判斷是客服人員，要秀出FrmBackStage在mdi子表單
                    {
                        MessageBox.Show("歡迎光臨客服人員");

                        FrmBackStage frm = new FrmBackStage();
                        ShowForm(frm);
                    }
                }
                else //如果尚未填寫會員資料(以Name判斷)，就跳出會員資料填寫
                {
                    MessageBox.Show("請填寫個人資料");
                    FrmMemberInfo MemInfo = new FrmMemberInfo();
                    MemInfo.ShowDialog();
                    if (MemInfo.DialogResult == DialogResult.OK)
                    {
                        MemInfo.Dispose();
                    }
                }
                
                CMember.getMemInfo(CMember.AccountID); //取得登入會員資料
                if (CMember.Name != null) //歡迎字串建置
                {
                    label1.Text = $"歡迎光臨，{CMember.Name[0]}**";
                }
                else
                {
                    label1.Text = $"請填寫個人資料";
                }
            }

            else if (login.DialogResult == DialogResult.Cancel) //取消按紐
            {
                login.Dispose();
                this.Close(); //會直接結束FrmLogin
                return;
            }
        }
        #endregion


        #region 發任務
        private void toolStripButtonTask_Click(object sender, EventArgs e)
        {
            Form3Task frm = new Form3Task();
            ShowForm(frm);
        }
        private void 發任務ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form3Task frm = new Form3Task();
            //ShowForm(frm);
        }
        #endregion


        #region 找專家
        private void toolStripButtonExpert_Click(object sender, EventArgs e)
        {
            FrmExpertSearch frm = new FrmExpertSearch();
            ShowForm(frm);
        }
        private void 找專家ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region 會員中心
        private void toolStripButtonMember_Click(object sender, EventArgs e)
        {
            FrmMemberMain frm = new FrmMemberMain();
            ShowForm(frm);
        }
        private void 會員中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMemberMain frm = new FrmMemberMain();
            ShowForm(frm);
        }
        #endregion


        #region 點數商城
        private void toolStripButtonPoint_Click(object sender, EventArgs e)
        {
            Form2Point frm = new Form2Point();
            ShowForm(frm);
        }
        private void 點數商城ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2Point frm = new Form2Point();
            ShowForm(frm);
        }
        #endregion


        #region 討論區
        private void toolStripButtonForum_Click(object sender, EventArgs e)
        {
            FrmBackStage frm = new FrmBackStage();
            ShowForm(frm);
        }
        private void 討論區ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackStage frm = new FrmBackStage();
            ShowForm(frm);
        }
        #endregion


        #region 關閉視窗        

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void 關閉目前視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }
        private void 關閉所有視窗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }
        #endregion


        #region 排列視窗
        private void 水平排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void 階梯式排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        #endregion
    }
}
