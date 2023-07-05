using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjIspanWinForms
{
    public partial class DateSelecter : UserControl
    {
        public DateSelecter()
        {
            InitializeComponent();

            YearLoad();
            MonthLoad();
            DayLoad();
        }

        private void DayLoad()
        {
            for (int i = 1; i <= 31; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }
        }

        private void MonthLoad()
        {
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
        }

        private void YearLoad()
        {
            int nowYear = DateTime.Now.Year;
            for(int i = 0; i < 120; i++)
            {
                comboBox1.Items.Add((nowYear-i).ToString());
            }
        }

        public string date
        {
            get
            {
               return  $"{comboBox1.Text}/{comboBox2.Text}/{comboBox3.Text}";
            }
        }
    }
}
