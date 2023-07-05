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
    public partial class WithoutButton : UserControl
    {
        public WithoutButton()
        {
            InitializeComponent();
        }

        NewIspanProjectEntities dbWantModel = new NewIspanProjectEntities();

        public string RealName
        {
            get { return txt_RealName.Text; }
            set { txt_RealName.Text = value; }
        }

        public string UserSkill
        {
            get { return txt_UserSkill.Text; }
            set { txt_UserSkill.Text = value; }
        }

        public string UserCert
        {
            get { return txt_UserCert.Text; }
            set { txt_UserCert.Text = value; }
        }

        public string UserAuto
        {
            get { return txt_UserAuto.Text; }
            set { txt_UserAuto.Text = value; }
        }

        public string PublishDate
        {
            get { return txt_PublishDate.Text; }
            set { txt_PublishDate.Text = value; }
        }

        public string TaskDate
        {
            get { return txt_TaskDate.Text; }
            set { txt_TaskDate.Text = value; }
        }

        public string TaskTitle
        {
            get { return txt_TaskTitle.Text; }
            set { txt_TaskTitle.Text = value; }
        }

        public string TaskDetail
        {
            get { return txt_TaskDetail.Text; }
            set { txt_TaskDetail.Text = value; }
        }

        public FlowLayoutPanel flowLayoutPanel1
        {
            get; set;
        }

    }
}
