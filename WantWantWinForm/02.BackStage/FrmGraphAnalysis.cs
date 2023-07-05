using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace prjWantWantWinForm
{
    public partial class FrmGraphAnalysis : Form
    {
        public FrmGraphAnalysis()
        {
            InitializeComponent();
        }


        NewIspanProjectEntities dbContext = new NewIspanProjectEntities();


        private void FrmGraphAnalysis_Load(object sender, EventArgs e)
        {

            var q = from t in dbContext.TaskLists
                    group t by t.AccountID into g
                    select new
                    {
                        會員人數 = g.Key,
                        發案數 = g.Count(),
                    };

            this.chart1.DataSource = q.ToList();
            this.chart1.Series[0].XValueMember = "會員人數";
            this.chart1.Series[0].YValueMembers = "發案數";
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            //chart1.Refresh();

        }
    }
}
