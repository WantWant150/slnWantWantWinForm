using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWantWantWinForm
{
   
    public partial class ucProducts : UserControl
    {
       
        public ucProducts()
        {
            InitializeComponent();
        
        }
        public event EventHandler onSelect = null;
        public event EventHandler onCountChange = null;

        public int Id { get; set; }
        public string PPrice
        {
            get { return labPrice.Text; }
            set { labPrice.Text = value; }
        }

        public string PName
        { get { return labName.Text; }
        set { labName.Text = value; }
        }
      

        public Image PImage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }

        private int count;
        public int PCount
        {
            get { return count; }
            set
            {
                count = value;
                labCount.Text = count.ToString();
                onCountChange?.Invoke(this, EventArgs.Empty);
            }
        }
       
        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PCount++;
            onCountChange?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           PCount= PCount > 0 ? PCount-1: 0;
            onCountChange?.Invoke(this, EventArgs.Empty);
        }
        
    }
}
