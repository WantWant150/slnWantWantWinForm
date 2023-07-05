namespace prjIspanWinForms
{
    partial class FrmExpertView
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label cityIDLabel1;
            System.Windows.Forms.Label taskPeriodLabel;
            System.Windows.Forms.Label taskStartLabel;
            System.Windows.Forms.Label taskEndLabel;
            System.Windows.Forms.Label requirementLabel;
            System.Windows.Forms.Label humanListLabel;
            System.Windows.Forms.Label languageRequiredLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpertView));
            this.txtIntroduction = new System.Windows.Forms.TextBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtQA = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbcdetaill = new System.Windows.Forms.ComboBox();
            this.cbCall = new System.Windows.Forms.ComboBox();
            this.cbskilldetail = new System.Windows.Forms.ComboBox();
            this.cbskillall = new System.Windows.Forms.ComboBox();
            this.cbTown = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.btnHistoru = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndelect = new System.Windows.Forms.Button();
            this.btnPictureUp = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPayment = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cityIDLabel1 = new System.Windows.Forms.Label();
            taskPeriodLabel = new System.Windows.Forms.Label();
            taskStartLabel = new System.Windows.Forms.Label();
            taskEndLabel = new System.Windows.Forms.Label();
            requirementLabel = new System.Windows.Forms.Label();
            humanListLabel = new System.Windows.Forms.Label();
            languageRequiredLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(415, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 25);
            label4.TabIndex = 139;
            label4.Text = "專長:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(415, 64);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(57, 25);
            label5.TabIndex = 141;
            label5.Text = "證照:";
            // 
            // cityIDLabel1
            // 
            cityIDLabel1.AutoSize = true;
            cityIDLabel1.Location = new System.Drawing.Point(15, 26);
            cityIDLabel1.Name = "cityIDLabel1";
            cityIDLabel1.Size = new System.Drawing.Size(97, 25);
            cityIDLabel1.TabIndex = 117;
            cityIDLabel1.Text = "服務城區:";
            // 
            // taskPeriodLabel
            // 
            taskPeriodLabel.AutoSize = true;
            taskPeriodLabel.Location = new System.Drawing.Point(543, 235);
            taskPeriodLabel.Name = "taskPeriodLabel";
            taskPeriodLabel.Size = new System.Drawing.Size(57, 25);
            taskPeriodLabel.TabIndex = 121;
            taskPeriodLabel.Text = "介紹:";
            // 
            // taskStartLabel
            // 
            taskStartLabel.AutoSize = true;
            taskStartLabel.Location = new System.Drawing.Point(15, 60);
            taskStartLabel.Name = "taskStartLabel";
            taskStartLabel.Size = new System.Drawing.Size(97, 25);
            taskStartLabel.TabIndex = 123;
            taskStartLabel.Text = "收費方式:";
            // 
            // taskEndLabel
            // 
            taskEndLabel.AutoSize = true;
            taskEndLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            taskEndLabel.Location = new System.Drawing.Point(15, 178);
            taskEndLabel.Name = "taskEndLabel";
            taskEndLabel.Size = new System.Drawing.Size(97, 25);
            taskEndLabel.TabIndex = 125;
            taskEndLabel.Text = "網站網址:";
            // 
            // requirementLabel
            // 
            requirementLabel.AutoSize = true;
            requirementLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            requirementLabel.Location = new System.Drawing.Point(15, 232);
            requirementLabel.Name = "requirementLabel";
            requirementLabel.Size = new System.Drawing.Size(97, 25);
            requirementLabel.TabIndex = 127;
            requirementLabel.Text = "常見問題:";
            // 
            // humanListLabel
            // 
            humanListLabel.AutoSize = true;
            humanListLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            humanListLabel.Location = new System.Drawing.Point(15, 129);
            humanListLabel.Name = "humanListLabel";
            humanListLabel.Size = new System.Drawing.Size(97, 25);
            humanListLabel.TabIndex = 129;
            humanListLabel.Text = "參考收費:";
            // 
            // languageRequiredLabel
            // 
            languageRequiredLabel.AutoSize = true;
            languageRequiredLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            languageRequiredLabel.Location = new System.Drawing.Point(375, 109);
            languageRequiredLabel.Name = "languageRequiredLabel";
            languageRequiredLabel.Size = new System.Drawing.Size(97, 25);
            languageRequiredLabel.TabIndex = 131;
            languageRequiredLabel.Text = "服務內容:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label2.Location = new System.Drawing.Point(267, 132);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 25);
            label2.TabIndex = 159;
            label2.Text = "元";
            // 
            // txtIntroduction
            // 
            this.txtIntroduction.Enabled = false;
            this.txtIntroduction.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIntroduction.Location = new System.Drawing.Point(605, 225);
            this.txtIntroduction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntroduction.Multiline = true;
            this.txtIntroduction.Name = "txtIntroduction";
            this.txtIntroduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIntroduction.Size = new System.Drawing.Size(392, 170);
            this.txtIntroduction.TabIndex = 122;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Enabled = false;
            this.txtWebsite.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWebsite.Location = new System.Drawing.Point(117, 178);
            this.txtWebsite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(353, 34);
            this.txtWebsite.TabIndex = 126;
            // 
            // txtQA
            // 
            this.txtQA.Enabled = false;
            this.txtQA.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQA.Location = new System.Drawing.Point(117, 235);
            this.txtQA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQA.Multiline = true;
            this.txtQA.Name = "txtQA";
            this.txtQA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQA.Size = new System.Drawing.Size(405, 162);
            this.txtQA.TabIndex = 128;
            // 
            // txtService
            // 
            this.txtService.Enabled = false;
            this.txtService.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtService.Location = new System.Drawing.Point(500, 109);
            this.txtService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtService.Multiline = true;
            this.txtService.Name = "txtService";
            this.txtService.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtService.Size = new System.Drawing.Size(317, 103);
            this.txtService.TabIndex = 132;
            // 
            // txtPay
            // 
            this.txtPay.Enabled = false;
            this.txtPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPay.Location = new System.Drawing.Point(123, 129);
            this.txtPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(135, 34);
            this.txtPay.TabIndex = 130;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbcdetaill
            // 
            this.cbcdetaill.Enabled = false;
            this.cbcdetaill.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbcdetaill.FormattingEnabled = true;
            this.cbcdetaill.Location = new System.Drawing.Point(639, 64);
            this.cbcdetaill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcdetaill.Name = "cbcdetaill";
            this.cbcdetaill.Size = new System.Drawing.Size(177, 33);
            this.cbcdetaill.TabIndex = 158;
            // 
            // cbCall
            // 
            this.cbCall.Enabled = false;
            this.cbCall.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbCall.FormattingEnabled = true;
            this.cbCall.Location = new System.Drawing.Point(500, 64);
            this.cbCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCall.Name = "cbCall";
            this.cbCall.Size = new System.Drawing.Size(121, 33);
            this.cbCall.TabIndex = 157;
            this.cbCall.SelectedIndexChanged += new System.EventHandler(this.cbCall_SelectedIndexChanged);
            // 
            // cbskilldetail
            // 
            this.cbskilldetail.Enabled = false;
            this.cbskilldetail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbskilldetail.FormattingEnabled = true;
            this.cbskilldetail.Location = new System.Drawing.Point(639, 25);
            this.cbskilldetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbskilldetail.Name = "cbskilldetail";
            this.cbskilldetail.Size = new System.Drawing.Size(177, 33);
            this.cbskilldetail.TabIndex = 156;
            // 
            // cbskillall
            // 
            this.cbskillall.Enabled = false;
            this.cbskillall.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbskillall.FormattingEnabled = true;
            this.cbskillall.Location = new System.Drawing.Point(500, 25);
            this.cbskillall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbskillall.Name = "cbskillall";
            this.cbskillall.Size = new System.Drawing.Size(121, 33);
            this.cbskillall.TabIndex = 155;
            this.cbskillall.SelectedIndexChanged += new System.EventHandler(this.cbskillall_SelectedIndexChanged);
            // 
            // cbTown
            // 
            this.cbTown.Enabled = false;
            this.cbTown.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbTown.FormattingEnabled = true;
            this.cbTown.Location = new System.Drawing.Point(225, 22);
            this.cbTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTown.Name = "cbTown";
            this.cbTown.Size = new System.Drawing.Size(140, 33);
            this.cbTown.TabIndex = 154;
            // 
            // cbCity
            // 
            this.cbCity.Enabled = false;
            this.cbCity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(117, 22);
            this.cbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(101, 33);
            this.cbCity.TabIndex = 153;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // btnHistoru
            // 
            this.btnHistoru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHistoru.Location = new System.Drawing.Point(847, 150);
            this.btnHistoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistoru.Name = "btnHistoru";
            this.btnHistoru.Size = new System.Drawing.Size(117, 62);
            this.btnHistoru.TabIndex = 150;
            this.btnHistoru.Text = "歷史委託專家";
            this.btnHistoru.UseVisualStyleBackColor = false;
            this.btnHistoru.Click += new System.EventHandler(this.btnHistoru_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(847, 82);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 62);
            this.btnSave.TabIndex = 149;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModify.Location = new System.Drawing.Point(847, 15);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(117, 62);
            this.btnModify.TabIndex = 149;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1111, 940);
            this.splitContainer1.SplitterDistance = 56;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 85);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.lbName);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Panel2.Controls.Add(this.panel3);
            this.splitContainer2.Size = new System.Drawing.Size(1051, 940);
            this.splitContainer2.SplitterDistance = 145;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(29, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(513, 42);
            this.label9.TabIndex = 4;
            this.label9.Text = "成為專家，讓我們一起為錢錢奮鬥";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbName.Location = new System.Drawing.Point(669, 89);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(92, 42);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "姓名:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(847, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.MistyRose;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 465);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1051, 326);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btndelect);
            this.panel2.Controls.Add(this.btnPictureUp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 426);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 39);
            this.panel2.TabIndex = 159;
            // 
            // btndelect
            // 
            this.btndelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btndelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btndelect.Location = new System.Drawing.Point(549, 0);
            this.btndelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelect.Name = "btndelect";
            this.btndelect.Size = new System.Drawing.Size(497, 39);
            this.btndelect.TabIndex = 1;
            this.btndelect.Text = "刪除所選取照片";
            this.btndelect.UseVisualStyleBackColor = false;
            this.btndelect.Click += new System.EventHandler(this.btndelect_Click);
            // 
            // btnPictureUp
            // 
            this.btnPictureUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPictureUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPictureUp.Location = new System.Drawing.Point(0, 0);
            this.btnPictureUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPictureUp.Name = "btnPictureUp";
            this.btnPictureUp.Size = new System.Drawing.Size(549, 39);
            this.btnPictureUp.TabIndex = 0;
            this.btnPictureUp.Text = "上傳照片";
            this.btnPictureUp.UseVisualStyleBackColor = false;
            this.btnPictureUp.Click += new System.EventHandler(this.btnPictureUp_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.txtPayment);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(cityIDLabel1);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(humanListLabel);
            this.panel3.Controls.Add(this.cbcdetaill);
            this.panel3.Controls.Add(this.txtPay);
            this.panel3.Controls.Add(this.btnModify);
            this.panel3.Controls.Add(this.txtQA);
            this.panel3.Controls.Add(taskStartLabel);
            this.panel3.Controls.Add(this.btnHistoru);
            this.panel3.Controls.Add(this.cbCall);
            this.panel3.Controls.Add(label4);
            this.panel3.Controls.Add(this.txtIntroduction);
            this.panel3.Controls.Add(languageRequiredLabel);
            this.panel3.Controls.Add(requirementLabel);
            this.panel3.Controls.Add(this.cbskilldetail);
            this.panel3.Controls.Add(this.txtService);
            this.panel3.Controls.Add(taskPeriodLabel);
            this.panel3.Controls.Add(label5);
            this.panel3.Controls.Add(taskEndLabel);
            this.panel3.Controls.Add(this.cbTown);
            this.panel3.Controls.Add(this.cbskillall);
            this.panel3.Controls.Add(this.txtWebsite);
            this.panel3.Controls.Add(this.cbCity);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 426);
            this.panel3.TabIndex = 161;
            // 
            // txtPayment
            // 
            this.txtPayment.Enabled = false;
            this.txtPayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPayment.FormattingEnabled = true;
            this.txtPayment.Items.AddRange(new object[] {
            "現金收費",
            "事前訂金+事後匯款"});
            this.txtPayment.Location = new System.Drawing.Point(117, 64);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(248, 33);
            this.txtPayment.TabIndex = 160;
            // 
            // ExpertView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1111, 940);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExpertView";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtIntroduction;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.TextBox txtQA;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnHistoru;
        private System.Windows.Forms.ComboBox cbTown;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbskilldetail;
        private System.Windows.Forms.ComboBox cbskillall;
        private System.Windows.Forms.ComboBox cbcdetaill;
        private System.Windows.Forms.ComboBox cbCall;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btndelect;
        private System.Windows.Forms.Button btnPictureUp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtPayment;
    }
}

