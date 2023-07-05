using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm._08.Forum
{
    public partial class Frm_ForumServiceCMS : Form
    {
        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();

        public Frm_ForumServiceCMS()
        {
            InitializeComponent();
        }

        private void btnModifyPost_Click(object sender, EventArgs e)
        {
            var q= from p in dbContext.ForumPosts
                   select p;

                
        }
    }
}
