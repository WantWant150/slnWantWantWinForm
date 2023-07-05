using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjIspanWinForms
{
    public partial class FrmExpertR : UserControl
    {
        public FrmExpertR()
        {
            InitializeComponent();
        }
       
        public int findresumeid { get; set; }
        public string findlabname {  set { labname.Text=value; } }
        public string findlaLocation { set { labLocation.Text = value; } }
        public string findlabprice { set { labPrice.Text = value; } }

        public string finds { set { labun.Text = value; } }
       
        public PictureBox searchpb { set { this.pictureBox1.Image = value.Image; } }
        FindAccount fa=new FindAccount();
        private void btnSearch_Click(object sender, EventArgs e)
        {

            CExpert.FindR = findresumeid;


            FrmExpertViewResume er = new FrmExpertViewResume();

            er.Text = findresumeid.ToString();

            er.MdiParent = this.ParentForm.MdiParent;
            er.Show();
            er.BringToFront();



            //base.FindForm().Close();
        }
     
    }
}
