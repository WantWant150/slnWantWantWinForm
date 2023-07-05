namespace prjIspanWinForms
{
    partial class FrmExpertNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label cityIDLabel1;
            System.Windows.Forms.Label humanListLabel;
            System.Windows.Forms.Label taskStartLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label languageRequiredLabel;
            System.Windows.Forms.Label requirementLabel;
            System.Windows.Forms.Label taskPeriodLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label taskEndLabel;
            System.Windows.Forms.Label label2;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.cbcdetaill = new System.Windows.Forms.ComboBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtQA = new System.Windows.Forms.TextBox();
            this.btnBeExpert = new System.Windows.Forms.Button();
            this.cbCall = new System.Windows.Forms.ComboBox();
            this.txtIntroduction = new System.Windows.Forms.TextBox();
            this.cbskilldetail = new System.Windows.Forms.ComboBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.cbTown = new System.Windows.Forms.ComboBox();
            this.cbskillall = new System.Windows.Forms.ComboBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPayment = new System.Windows.Forms.ComboBox();
            cityIDLabel1 = new System.Windows.Forms.Label();
            humanListLabel = new System.Windows.Forms.Label();
            taskStartLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            languageRequiredLabel = new System.Windows.Forms.Label();
            requirementLabel = new System.Windows.Forms.Label();
            taskPeriodLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            taskEndLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityIDLabel1
            // 
            cityIDLabel1.AutoSize = true;
            cityIDLabel1.Location = new System.Drawing.Point(64, 28);
            cityIDLabel1.Name = "cityIDLabel1";
            cityIDLabel1.Size = new System.Drawing.Size(97, 25);
            cityIDLabel1.TabIndex = 159;
            cityIDLabel1.Text = "服務城區:";
            // 
            // humanListLabel
            // 
            humanListLabel.AutoSize = true;
            humanListLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            humanListLabel.Location = new System.Drawing.Point(64, 165);
            humanListLabel.Name = "humanListLabel";
            humanListLabel.Size = new System.Drawing.Size(97, 25);
            humanListLabel.TabIndex = 168;
            humanListLabel.Text = "參考收費:";
            // 
            // taskStartLabel
            // 
            taskStartLabel.AutoSize = true;
            taskStartLabel.Location = new System.Drawing.Point(64, 71);
            taskStartLabel.Name = "taskStartLabel";
            taskStartLabel.Size = new System.Drawing.Size(97, 25);
            taskStartLabel.TabIndex = 162;
            taskStartLabel.Text = "收費方式:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(567, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 25);
            label4.TabIndex = 172;
            label4.Text = "專長:";
            // 
            // languageRequiredLabel
            // 
            languageRequiredLabel.AutoSize = true;
            languageRequiredLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            languageRequiredLabel.Location = new System.Drawing.Point(519, 116);
            languageRequiredLabel.Name = "languageRequiredLabel";
            languageRequiredLabel.Size = new System.Drawing.Size(97, 25);
            languageRequiredLabel.TabIndex = 170;
            languageRequiredLabel.Text = "服務內容:";
            // 
            // requirementLabel
            // 
            requirementLabel.AutoSize = true;
            requirementLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            requirementLabel.Location = new System.Drawing.Point(64, 248);
            requirementLabel.Name = "requirementLabel";
            requirementLabel.Size = new System.Drawing.Size(97, 25);
            requirementLabel.TabIndex = 166;
            requirementLabel.Text = "常見問題:";
            // 
            // taskPeriodLabel
            // 
            taskPeriodLabel.AutoSize = true;
            taskPeriodLabel.Location = new System.Drawing.Point(567, 248);
            taskPeriodLabel.Name = "taskPeriodLabel";
            taskPeriodLabel.Size = new System.Drawing.Size(57, 25);
            taskPeriodLabel.TabIndex = 160;
            taskPeriodLabel.Text = "介紹:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(567, 63);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 25);
            label5.TabIndex = 173;
            label5.Text = "證照:";
            // 
            // taskEndLabel
            // 
            taskEndLabel.AutoSize = true;
            taskEndLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            taskEndLabel.Location = new System.Drawing.Point(64, 116);
            taskEndLabel.Name = "taskEndLabel";
            taskEndLabel.Size = new System.Drawing.Size(97, 25);
            taskEndLabel.TabIndex = 164;
            taskEndLabel.Text = "網站網址:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SeaShell;
            this.splitContainer1.Panel2.Controls.Add(this.txtPayment);
            this.splitContainer1.Panel2.Controls.Add(label2);
            this.splitContainer1.Panel2.Controls.Add(cityIDLabel1);
            this.splitContainer1.Panel2.Controls.Add(humanListLabel);
            this.splitContainer1.Panel2.Controls.Add(this.cbcdetaill);
            this.splitContainer1.Panel2.Controls.Add(this.txtPay);
            this.splitContainer1.Panel2.Controls.Add(this.txtQA);
            this.splitContainer1.Panel2.Controls.Add(taskStartLabel);
            this.splitContainer1.Panel2.Controls.Add(this.btnBeExpert);
            this.splitContainer1.Panel2.Controls.Add(this.cbCall);
            this.splitContainer1.Panel2.Controls.Add(label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtIntroduction);
            this.splitContainer1.Panel2.Controls.Add(languageRequiredLabel);
            this.splitContainer1.Panel2.Controls.Add(requirementLabel);
            this.splitContainer1.Panel2.Controls.Add(this.cbskilldetail);
            this.splitContainer1.Panel2.Controls.Add(this.txtService);
            this.splitContainer1.Panel2.Controls.Add(taskPeriodLabel);
            this.splitContainer1.Panel2.Controls.Add(label5);
            this.splitContainer1.Panel2.Controls.Add(taskEndLabel);
            this.splitContainer1.Panel2.Controls.Add(this.cbTown);
            this.splitContainer1.Panel2.Controls.Add(this.cbskillall);
            this.splitContainer1.Panel2.Controls.Add(this.txtWebsite);
            this.splitContainer1.Panel2.Controls.Add(this.cbCity);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.splitContainer1.Size = new System.Drawing.Size(1093, 506);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(49, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(513, 42);
            this.label9.TabIndex = 4;
            this.label9.Text = "成為專家，讓我們一起為錢錢奮鬥";
            // 
            // cbcdetaill
            // 
            this.cbcdetaill.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbcdetaill.FormattingEnabled = true;
            this.cbcdetaill.Location = new System.Drawing.Point(791, 63);
            this.cbcdetaill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcdetaill.Name = "cbcdetaill";
            this.cbcdetaill.Size = new System.Drawing.Size(132, 33);
            this.cbcdetaill.TabIndex = 182;
            this.cbcdetaill.Text = "請選擇";
            // 
            // txtPay
            // 
            this.txtPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPay.Location = new System.Drawing.Point(181, 162);
            this.txtPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(100, 34);
            this.txtPay.TabIndex = 169;
            // 
            // txtQA
            // 
            this.txtQA.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQA.Location = new System.Drawing.Point(167, 248);
            this.txtQA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQA.Multiline = true;
            this.txtQA.Name = "txtQA";
            this.txtQA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQA.Size = new System.Drawing.Size(380, 162);
            this.txtQA.TabIndex = 167;
            // 
            // btnBeExpert
            // 
            this.btnBeExpert.Location = new System.Drawing.Point(952, 25);
            this.btnBeExpert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBeExpert.Name = "btnBeExpert";
            this.btnBeExpert.Size = new System.Drawing.Size(117, 62);
            this.btnBeExpert.TabIndex = 176;
            this.btnBeExpert.Text = "成為專家";
            this.btnBeExpert.UseVisualStyleBackColor = true;
            this.btnBeExpert.Click += new System.EventHandler(this.btnBeExpert_Click);
            // 
            // cbCall
            // 
            this.cbCall.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbCall.FormattingEnabled = true;
            this.cbCall.Location = new System.Drawing.Point(652, 63);
            this.cbCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCall.Name = "cbCall";
            this.cbCall.Size = new System.Drawing.Size(121, 33);
            this.cbCall.TabIndex = 181;
            this.cbCall.Text = "請選擇";
            this.cbCall.SelectedIndexChanged += new System.EventHandler(this.cbCall_SelectedIndexChanged);
            // 
            // txtIntroduction
            // 
            this.txtIntroduction.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIntroduction.Location = new System.Drawing.Point(629, 238);
            this.txtIntroduction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntroduction.Multiline = true;
            this.txtIntroduction.Name = "txtIntroduction";
            this.txtIntroduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIntroduction.Size = new System.Drawing.Size(392, 170);
            this.txtIntroduction.TabIndex = 161;
            // 
            // cbskilldetail
            // 
            this.cbskilldetail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbskilldetail.FormattingEnabled = true;
            this.cbskilldetail.Location = new System.Drawing.Point(791, 25);
            this.cbskilldetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbskilldetail.Name = "cbskilldetail";
            this.cbskilldetail.Size = new System.Drawing.Size(132, 33);
            this.cbskilldetail.TabIndex = 180;
            this.cbskilldetail.Text = "請選擇";
            // 
            // txtService
            // 
            this.txtService.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtService.Location = new System.Drawing.Point(629, 112);
            this.txtService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtService.Multiline = true;
            this.txtService.Name = "txtService";
            this.txtService.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtService.Size = new System.Drawing.Size(392, 108);
            this.txtService.TabIndex = 171;
            // 
            // cbTown
            // 
            this.cbTown.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbTown.FormattingEnabled = true;
            this.cbTown.Location = new System.Drawing.Point(287, 26);
            this.cbTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTown.Name = "cbTown";
            this.cbTown.Size = new System.Drawing.Size(101, 33);
            this.cbTown.TabIndex = 178;
            this.cbTown.Text = "請選擇";
            // 
            // cbskillall
            // 
            this.cbskillall.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbskillall.FormattingEnabled = true;
            this.cbskillall.Location = new System.Drawing.Point(652, 25);
            this.cbskillall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbskillall.Name = "cbskillall";
            this.cbskillall.Size = new System.Drawing.Size(121, 33);
            this.cbskillall.TabIndex = 179;
            this.cbskillall.Text = "請選擇";
            this.cbskillall.SelectedIndexChanged += new System.EventHandler(this.cbskillall_SelectedIndexChanged);
            // 
            // txtWebsite
            // 
            this.txtWebsite.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWebsite.Location = new System.Drawing.Point(180, 112);
            this.txtWebsite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(333, 34);
            this.txtWebsite.TabIndex = 165;
            // 
            // cbCity
            // 
            this.cbCity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(180, 26);
            this.cbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(101, 33);
            this.cbCity.TabIndex = 177;
            this.cbCity.Text = "請選擇";
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label2.Location = new System.Drawing.Point(299, 165);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 25);
            label2.TabIndex = 183;
            label2.Text = "元";
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPayment.FormattingEnabled = true;
            this.txtPayment.Items.AddRange(new object[] {
            "現金收費",
            "事前訂金+事後匯款"});
            this.txtPayment.Location = new System.Drawing.Point(181, 71);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(248, 33);
            this.txtPayment.TabIndex = 184;
            // 
            // ExpertNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 506);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExpertNew";
            this.Text = "Expert";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbcdetaill;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.TextBox txtQA;
        private System.Windows.Forms.Button btnBeExpert;
        private System.Windows.Forms.ComboBox cbCall;
        private System.Windows.Forms.TextBox txtIntroduction;
        private System.Windows.Forms.ComboBox cbskilldetail;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.ComboBox cbTown;
        private System.Windows.Forms.ComboBox cbskillall;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox txtPayment;
    }
}