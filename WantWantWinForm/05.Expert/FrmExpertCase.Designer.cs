namespace prjIspanWinForms
{
    partial class FrmExpertCase
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
            System.Windows.Forms.Label requiredNumLabel;
            System.Windows.Forms.Label taskPeriodLabel;
            System.Windows.Forms.Label taskStartLabel;
            System.Windows.Forms.Label taskEndLabel;
            System.Windows.Forms.Label humanListLabel;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMy = new System.Windows.Forms.TextBox();
            this.txtExpert = new System.Windows.Forms.TextBox();
            this.txtTaskDetail = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnback = new System.Windows.Forms.Button();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            cityIDLabel1 = new System.Windows.Forms.Label();
            requiredNumLabel = new System.Windows.Forms.Label();
            taskPeriodLabel = new System.Windows.Forms.Label();
            taskStartLabel = new System.Windows.Forms.Label();
            taskEndLabel = new System.Windows.Forms.Label();
            humanListLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityIDLabel1
            // 
            cityIDLabel1.AutoSize = true;
            cityIDLabel1.Location = new System.Drawing.Point(47, 77);
            cityIDLabel1.Name = "cityIDLabel1";
            cityIDLabel1.Size = new System.Drawing.Size(57, 20);
            cityIDLabel1.TabIndex = 150;
            cityIDLabel1.Text = "委託人";
            // 
            // requiredNumLabel
            // 
            requiredNumLabel.AutoSize = true;
            requiredNumLabel.Location = new System.Drawing.Point(47, 117);
            requiredNumLabel.Name = "requiredNumLabel";
            requiredNumLabel.Size = new System.Drawing.Size(61, 20);
            requiredNumLabel.TabIndex = 152;
            requiredNumLabel.Text = "接案者:";
            // 
            // taskPeriodLabel
            // 
            taskPeriodLabel.AutoSize = true;
            taskPeriodLabel.Location = new System.Drawing.Point(327, 77);
            taskPeriodLabel.Name = "taskPeriodLabel";
            taskPeriodLabel.Size = new System.Drawing.Size(109, 20);
            taskPeriodLabel.TabIndex = 154;
            taskPeriodLabel.Text = "本次案件內容:";
            // 
            // taskStartLabel
            // 
            taskStartLabel.AutoSize = true;
            taskStartLabel.Location = new System.Drawing.Point(47, 164);
            taskStartLabel.Name = "taskStartLabel";
            taskStartLabel.Size = new System.Drawing.Size(77, 20);
            taskStartLabel.TabIndex = 156;
            taskStartLabel.Text = "服務地點:";
            // 
            // taskEndLabel
            // 
            taskEndLabel.AutoSize = true;
            taskEndLabel.Location = new System.Drawing.Point(47, 204);
            taskEndLabel.Name = "taskEndLabel";
            taskEndLabel.Size = new System.Drawing.Size(105, 20);
            taskEndLabel.TabIndex = 158;
            taskEndLabel.Text = "預計工作期間";
            // 
            // humanListLabel
            // 
            humanListLabel.AutoSize = true;
            humanListLabel.Location = new System.Drawing.Point(47, 324);
            humanListLabel.Name = "humanListLabel";
            humanListLabel.Size = new System.Drawing.Size(45, 20);
            humanListLabel.TabIndex = 162;
            humanListLabel.Text = "收費:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Location = new System.Drawing.Point(589, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 99);
            this.btnSave.TabIndex = 182;
            this.btnSave.Text = "送出委託";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMy
            // 
            this.txtMy.Enabled = false;
            this.txtMy.Location = new System.Drawing.Point(129, 74);
            this.txtMy.Name = "txtMy";
            this.txtMy.Size = new System.Drawing.Size(157, 29);
            this.txtMy.TabIndex = 151;
            // 
            // txtExpert
            // 
            this.txtExpert.Enabled = false;
            this.txtExpert.Location = new System.Drawing.Point(129, 114);
            this.txtExpert.Name = "txtExpert";
            this.txtExpert.Size = new System.Drawing.Size(157, 29);
            this.txtExpert.TabIndex = 153;
            // 
            // txtTaskDetail
            // 
            this.txtTaskDetail.Location = new System.Drawing.Point(331, 112);
            this.txtTaskDetail.Multiline = true;
            this.txtTaskDetail.Name = "txtTaskDetail";
            this.txtTaskDetail.Size = new System.Drawing.Size(374, 214);
            this.txtTaskDetail.TabIndex = 155;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(92, 321);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(124, 29);
            this.txtSalary.TabIndex = 161;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 34);
            this.label1.TabIndex = 183;
            this.label1.Text = "委託單";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 238);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 29);
            this.dateTimePicker1.TabIndex = 184;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(92, 277);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(206, 29);
            this.dateTimePicker2.TabIndex = 185;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(47, 244);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(37, 20);
            label8.TabIndex = 186;
            label8.Text = "起~";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(47, 284);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(37, 20);
            label9.TabIndex = 187;
            label9.Text = "~訖";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(222, 324);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 20);
            label2.TabIndex = 188;
            label2.Text = "元";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 370);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(297, 20);
            label3.TabIndex = 189;
            label3.Text = "提醒您，在送出委託之前請先聯繫專家。";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 402);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(457, 20);
            label4.TabIndex = 190;
            label4.Text = "送出委託並非代表專家接受委託，請在管理頁面查詢委託狀態。";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnback.Location = new System.Drawing.Point(601, 18);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(104, 42);
            this.btnback.TabIndex = 191;
            this.btnback.Text = "回上一頁";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cbPlace
            // 
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Items.AddRange(new object[] {
            "在家兼職",
            "指定地點"});
            this.cbPlace.Location = new System.Drawing.Point(130, 161);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(156, 28);
            this.cbPlace.TabIndex = 192;
            this.cbPlace.Text = "在家兼職";
            // 
            // ExpertCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(734, 457);
            this.Controls.Add(this.cbPlace);
            this.Controls.Add(this.btnback);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label9);
            this.Controls.Add(label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(cityIDLabel1);
            this.Controls.Add(this.txtMy);
            this.Controls.Add(requiredNumLabel);
            this.Controls.Add(this.txtExpert);
            this.Controls.Add(taskPeriodLabel);
            this.Controls.Add(this.txtTaskDetail);
            this.Controls.Add(taskStartLabel);
            this.Controls.Add(taskEndLabel);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(humanListLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "ExpertCase";
            this.Text = "ExpertCase";
            this.Load += new System.EventHandler(this.ExpertCase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMy;
        private System.Windows.Forms.TextBox txtExpert;
        private System.Windows.Forms.TextBox txtTaskDetail;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox cbPlace;
    }
}