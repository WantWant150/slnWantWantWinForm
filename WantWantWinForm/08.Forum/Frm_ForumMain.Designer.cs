namespace WinFormsMidSora
{
    partial class Frm_ForumMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ForumMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRevisePost = new System.Windows.Forms.Button();
            this.btnGotoForum = new System.Windows.Forms.Button();
            this.labShow_FormCateDes = new System.Windows.Forms.Label();
            this.labNoAct_ForumCategory = new System.Windows.Forms.Label();
            this.comboxDisplay_CategoryTitle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(224)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnRevisePost);
            this.splitContainer1.Panel1.Controls.Add(this.btnGotoForum);
            this.splitContainer1.Panel1.Controls.Add(this.labShow_FormCateDes);
            this.splitContainer1.Panel1.Controls.Add(this.labNoAct_ForumCategory);
            this.splitContainer1.Panel1.Controls.Add(this.comboxDisplay_CategoryTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.splitContainer1.Size = new System.Drawing.Size(1031, 799);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(885, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnRevisePost
            // 
            this.btnRevisePost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevisePost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnRevisePost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnRevisePost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevisePost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnRevisePost.Location = new System.Drawing.Point(705, 12);
            this.btnRevisePost.Name = "btnRevisePost";
            this.btnRevisePost.Size = new System.Drawing.Size(161, 36);
            this.btnRevisePost.TabIndex = 3;
            this.btnRevisePost.Text = "個人發文管理";
            this.btnRevisePost.UseVisualStyleBackColor = false;
            this.btnRevisePost.Click += new System.EventHandler(this.btnRevisePost_Click);
            // 
            // btnGotoForum
            // 
            this.btnGotoForum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnGotoForum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnGotoForum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGotoForum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnGotoForum.Location = new System.Drawing.Point(311, 12);
            this.btnGotoForum.Name = "btnGotoForum";
            this.btnGotoForum.Size = new System.Drawing.Size(161, 36);
            this.btnGotoForum.TabIndex = 3;
            this.btnGotoForum.Text = "進入此討論區";
            this.btnGotoForum.UseVisualStyleBackColor = false;
            this.btnGotoForum.Click += new System.EventHandler(this.btnGotoForum_Click);
            // 
            // labShow_FormCateDes
            // 
            this.labShow_FormCateDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.labShow_FormCateDes.Location = new System.Drawing.Point(81, 52);
            this.labShow_FormCateDes.Name = "labShow_FormCateDes";
            this.labShow_FormCateDes.Size = new System.Drawing.Size(391, 83);
            this.labShow_FormCateDes.TabIndex = 2;
            this.labShow_FormCateDes.Text = "討論區描述部分";
            // 
            // labNoAct_ForumCategory
            // 
            this.labNoAct_ForumCategory.AutoSize = true;
            this.labNoAct_ForumCategory.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNoAct_ForumCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.labNoAct_ForumCategory.Location = new System.Drawing.Point(12, 18);
            this.labNoAct_ForumCategory.Name = "labNoAct_ForumCategory";
            this.labNoAct_ForumCategory.Size = new System.Drawing.Size(67, 24);
            this.labNoAct_ForumCategory.TabIndex = 1;
            this.labNoAct_ForumCategory.Text = "討論區";
            // 
            // comboxDisplay_CategoryTitle
            // 
            this.comboxDisplay_CategoryTitle.BackColor = System.Drawing.Color.White;
            this.comboxDisplay_CategoryTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDisplay_CategoryTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboxDisplay_CategoryTitle.FormattingEnabled = true;
            this.comboxDisplay_CategoryTitle.Location = new System.Drawing.Point(85, 16);
            this.comboxDisplay_CategoryTitle.Name = "comboxDisplay_CategoryTitle";
            this.comboxDisplay_CategoryTitle.Size = new System.Drawing.Size(216, 28);
            this.comboxDisplay_CategoryTitle.TabIndex = 0;
            this.comboxDisplay_CategoryTitle.SelectedIndexChanged += new System.EventHandler(this.comboxDisplay_CategoryTitle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(300, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 250);
            this.label2.TabIndex = 3;
            this.label2.Text = "歡迎來到WantWant的討論區\r\n這邊可以跟大家交流各式意見\r\n以下是小小規定，希望大家可以遵守喔\r\n-----------------------------" +
    "-------------\r\n\r\n◆禁止偏激謾罵等製造爭議的行為\r\n◆禁止製造仇恨、人身攻擊及無意義的內容\r\n◆切勿故意引戰、洗版\r\n\r\n祝大家玩得愉快~";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(221)))), ((int)(((byte)(232)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(300, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 83);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_ForumMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 799);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_ForumMain";
            this.RightToLeftLayout = true;
            this.Text = "ForumMain";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labShow_FormCateDes;
        private System.Windows.Forms.Label labNoAct_ForumCategory;
        private System.Windows.Forms.ComboBox comboxDisplay_CategoryTitle;
        private System.Windows.Forms.Button btnGotoForum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRevisePost;
    }
}

