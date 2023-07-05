namespace prjWantWantWinForm
{
    partial class FrmTask
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_TaskNumberID = new System.Windows.Forms.ComboBox();
            this.cmb_Town = new System.Windows.Forms.ComboBox();
            this.cmb_City = new System.Windows.Forms.ComboBox();
            this.txt_WorkPlace = new System.Windows.Forms.TextBox();
            this.dTP_TaskDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dTP_TaskDateStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_Publish = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dTP_End = new System.Windows.Forms.DateTimePicker();
            this.dTP_Start = new System.Windows.Forms.DateTimePicker();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Detail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PayFrom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_TimeStart = new System.Windows.Forms.TextBox();
            this.txt_People = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_TimeEnd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(59, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 275;
            this.label2.Text = "任務類型";
            // 
            // cmb_TaskNumberID
            // 
            this.cmb_TaskNumberID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_TaskNumberID.BackColor = System.Drawing.Color.White;
            this.cmb_TaskNumberID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_TaskNumberID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmb_TaskNumberID.FormattingEnabled = true;
            this.cmb_TaskNumberID.Location = new System.Drawing.Point(225, 260);
            this.cmb_TaskNumberID.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_TaskNumberID.Name = "cmb_TaskNumberID";
            this.cmb_TaskNumberID.Size = new System.Drawing.Size(135, 33);
            this.cmb_TaskNumberID.TabIndex = 274;
            this.cmb_TaskNumberID.Text = "請選擇";
            // 
            // cmb_Town
            // 
            this.cmb_Town.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_Town.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmb_Town.FormattingEnabled = true;
            this.cmb_Town.Location = new System.Drawing.Point(360, 423);
            this.cmb_Town.Name = "cmb_Town";
            this.cmb_Town.Size = new System.Drawing.Size(121, 33);
            this.cmb_Town.TabIndex = 284;
            // 
            // cmb_City
            // 
            this.cmb_City.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_City.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmb_City.FormattingEnabled = true;
            this.cmb_City.Location = new System.Drawing.Point(224, 423);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.Size = new System.Drawing.Size(121, 33);
            this.cmb_City.TabIndex = 283;
            this.cmb_City.SelectedIndexChanged += new System.EventHandler(this.cmb_City_SelectedIndexChanged_1);
            // 
            // txt_WorkPlace
            // 
            this.txt_WorkPlace.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_WorkPlace.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_WorkPlace.Location = new System.Drawing.Point(496, 422);
            this.txt_WorkPlace.Name = "txt_WorkPlace";
            this.txt_WorkPlace.Size = new System.Drawing.Size(230, 34);
            this.txt_WorkPlace.TabIndex = 285;
            this.txt_WorkPlace.Text = "例：台北市大安區";
            this.txt_WorkPlace.Click += new System.EventHandler(this.txt_WorkPlace_Click_1);
            // 
            // dTP_TaskDateEnd
            // 
            this.dTP_TaskDateEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dTP_TaskDateEnd.Location = new System.Drawing.Point(461, 315);
            this.dTP_TaskDateEnd.Name = "dTP_TaskDateEnd";
            this.dTP_TaskDateEnd.Size = new System.Drawing.Size(205, 34);
            this.dTP_TaskDateEnd.TabIndex = 280;
            // 
            // dTP_TaskDateStart
            // 
            this.dTP_TaskDateStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dTP_TaskDateStart.Location = new System.Drawing.Point(225, 315);
            this.dTP_TaskDateStart.Name = "dTP_TaskDateStart";
            this.dTP_TaskDateStart.Size = new System.Drawing.Size(205, 34);
            this.dTP_TaskDateStart.TabIndex = 279;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.LightCoral;
            this.label7.Location = new System.Drawing.Point(59, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 277;
            this.label7.Text = "任務期間";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(432, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 25);
            this.label10.TabIndex = 278;
            this.label10.Text = "~";
            // 
            // cmb_Publish
            // 
            this.cmb_Publish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_Publish.BackColor = System.Drawing.Color.White;
            this.cmb_Publish.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_Publish.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmb_Publish.FormattingEnabled = true;
            this.cmb_Publish.Items.AddRange(new object[] {
            "立刻上架",
            "延後上架"});
            this.cmb_Publish.Location = new System.Drawing.Point(225, 653);
            this.cmb_Publish.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_Publish.Name = "cmb_Publish";
            this.cmb_Publish.Size = new System.Drawing.Size(172, 33);
            this.cmb_Publish.TabIndex = 290;
            this.cmb_Publish.Text = "請選擇";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label23.ForeColor = System.Drawing.Color.LightCoral;
            this.label23.Location = new System.Drawing.Point(62, 655);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 31);
            this.label23.TabIndex = 276;
            this.label23.Text = "是否上架";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.ForeColor = System.Drawing.Color.LightCoral;
            this.label17.Location = new System.Drawing.Point(59, 427);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 31);
            this.label17.TabIndex = 273;
            this.label17.Text = "工作地區";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Save.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(354, 739);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 42);
            this.btn_Save.TabIndex = 266;
            this.btn_Save.Text = "儲存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // dTP_End
            // 
            this.dTP_End.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dTP_End.Location = new System.Drawing.Point(461, 593);
            this.dTP_End.Name = "dTP_End";
            this.dTP_End.Size = new System.Drawing.Size(205, 34);
            this.dTP_End.TabIndex = 289;
            // 
            // dTP_Start
            // 
            this.dTP_Start.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dTP_Start.Location = new System.Drawing.Point(227, 593);
            this.dTP_Start.Name = "dTP_Start";
            this.dTP_Start.Size = new System.Drawing.Size(205, 34);
            this.dTP_Start.TabIndex = 288;
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Title.Location = new System.Drawing.Point(224, 90);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(533, 34);
            this.txt_Title.TabIndex = 257;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(57, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 256;
            this.label4.Text = "任務標題";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(58, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 258;
            this.label5.Text = "任務內容";
            // 
            // txt_Detail
            // 
            this.txt_Detail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Detail.Location = new System.Drawing.Point(225, 144);
            this.txt_Detail.MaxLength = 400;
            this.txt_Detail.Multiline = true;
            this.txt_Detail.Name = "txt_Detail";
            this.txt_Detail.Size = new System.Drawing.Size(533, 95);
            this.txt_Detail.TabIndex = 259;
            this.txt_Detail.WordWrap = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.LightCoral;
            this.label8.Location = new System.Drawing.Point(59, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 260;
            this.label8.Text = "支付金額";
            // 
            // txt_PayFrom
            // 
            this.txt_PayFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_PayFrom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_PayFrom.Location = new System.Drawing.Point(225, 475);
            this.txt_PayFrom.Name = "txt_PayFrom";
            this.txt_PayFrom.Size = new System.Drawing.Size(150, 34);
            this.txt_PayFrom.TabIndex = 286;
            this.txt_PayFrom.Text = "請輸入金額";
            this.txt_PayFrom.Click += new System.EventHandler(this.txt_PayFrom_Click_1);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.LightCoral;
            this.label12.Location = new System.Drawing.Point(58, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 31);
            this.label12.TabIndex = 261;
            this.label12.Text = "任務時段";
            // 
            // txt_TimeStart
            // 
            this.txt_TimeStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_TimeStart.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_TimeStart.Location = new System.Drawing.Point(225, 368);
            this.txt_TimeStart.Name = "txt_TimeStart";
            this.txt_TimeStart.Size = new System.Drawing.Size(150, 34);
            this.txt_TimeStart.TabIndex = 281;
            this.txt_TimeStart.Text = "開始時間";
            this.txt_TimeStart.Click += new System.EventHandler(this.txt_TimeStart_Click_1);
            // 
            // txt_People
            // 
            this.txt_People.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_People.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_People.Location = new System.Drawing.Point(225, 533);
            this.txt_People.Name = "txt_People";
            this.txt_People.Size = new System.Drawing.Size(256, 34);
            this.txt_People.TabIndex = 287;
            this.txt_People.Text = "請輸入人數";
            this.txt_People.Click += new System.EventHandler(this.txt_People_Click_1);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(377, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 25);
            this.label11.TabIndex = 262;
            this.label11.Text = "~";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.ForeColor = System.Drawing.Color.LightCoral;
            this.label16.Location = new System.Drawing.Point(60, 536);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 31);
            this.label16.TabIndex = 265;
            this.label16.Text = "需求人數";
            // 
            // txt_TimeEnd
            // 
            this.txt_TimeEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_TimeEnd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_TimeEnd.Location = new System.Drawing.Point(404, 367);
            this.txt_TimeEnd.Name = "txt_TimeEnd";
            this.txt_TimeEnd.Size = new System.Drawing.Size(150, 34);
            this.txt_TimeEnd.TabIndex = 282;
            this.txt_TimeEnd.Text = "結束時間";
            this.txt_TimeEnd.Click += new System.EventHandler(this.txt_TimeEnd_Click_1);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.LightCoral;
            this.label14.Location = new System.Drawing.Point(61, 596);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 31);
            this.label14.TabIndex = 263;
            this.label14.Text = "刊登期間";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(433, 600);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 25);
            this.label13.TabIndex = 264;
            this.label13.Text = "~";
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(822, 872);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_TaskNumberID);
            this.Controls.Add(this.cmb_Town);
            this.Controls.Add(this.cmb_City);
            this.Controls.Add(this.txt_WorkPlace);
            this.Controls.Add(this.dTP_TaskDateEnd);
            this.Controls.Add(this.dTP_TaskDateStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_Publish);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dTP_End);
            this.Controls.Add(this.dTP_Start);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Detail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_PayFrom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_TimeStart);
            this.Controls.Add(this.txt_People);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_TimeEnd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTask";
            this.Text = "出任務";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_TaskNumberID;
        private System.Windows.Forms.ComboBox cmb_Town;
        private System.Windows.Forms.ComboBox cmb_City;
        private System.Windows.Forms.TextBox txt_WorkPlace;
        private System.Windows.Forms.DateTimePicker dTP_TaskDateEnd;
        private System.Windows.Forms.DateTimePicker dTP_TaskDateStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_Publish;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dTP_End;
        private System.Windows.Forms.DateTimePicker dTP_Start;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Detail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PayFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_TimeStart;
        private System.Windows.Forms.TextBox txt_People;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_TimeEnd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}