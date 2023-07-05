namespace prjWantWantWinForm
{
    partial class FrmExpertR
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label cityIDLabel1;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpertR));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labPrice = new System.Windows.Forms.Label();
            this.labLocation = new System.Windows.Forms.Label();
            this.labun = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            cityIDLabel1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityIDLabel1
            // 
            cityIDLabel1.AutoSize = true;
            cityIDLabel1.Location = new System.Drawing.Point(204, 54);
            cityIDLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cityIDLabel1.Name = "cityIDLabel1";
            cityIDLabel1.Size = new System.Drawing.Size(77, 20);
            cityIDLabel1.TabIndex = 155;
            cityIDLabel1.Text = "服務城區:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(180, 86);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(109, 20);
            label3.TabIndex = 157;
            label3.Text = "預估提供價格:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.labPrice);
            this.panel1.Controls.Add(this.labLocation);
            this.panel1.Controls.Add(cityIDLabel1);
            this.panel1.Controls.Add(this.labun);
            this.panel1.Controls.Add(this.labname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 184);
            this.panel1.TabIndex = 0;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(297, 86);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(77, 20);
            this.labPrice.TabIndex = 156;
            this.labPrice.Text = "專家姓名:";
            // 
            // labLocation
            // 
            this.labLocation.AutoSize = true;
            this.labLocation.Location = new System.Drawing.Point(297, 54);
            this.labLocation.Name = "labLocation";
            this.labLocation.Size = new System.Drawing.Size(77, 20);
            this.labLocation.TabIndex = 156;
            this.labLocation.Text = "專家姓名:";
            // 
            // labun
            // 
            this.labun.AutoSize = true;
            this.labun.Location = new System.Drawing.Point(466, 20);
            this.labun.Name = "labun";
            this.labun.Size = new System.Drawing.Size(57, 20);
            this.labun.TabIndex = 3;
            this.labun.Text = "已認證";
            this.labun.Visible = false;
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(297, 20);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(77, 20);
            this.labname.TabIndex = 2;
            this.labname.Text = "專家姓名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "專家姓名:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(380, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 60);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查看";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmExpertR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FrmExpertR";
            this.Size = new System.Drawing.Size(539, 184);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labun;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labLocation;
    }
}
