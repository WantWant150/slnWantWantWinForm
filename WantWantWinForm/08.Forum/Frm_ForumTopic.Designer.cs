namespace prjWantWantWinForm
{
    partial class Frm_ForumTopic
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtFirstFloorContext = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.panelReplyComment = new System.Windows.Forms.Panel();
            this.txtReplyComment = new System.Windows.Forms.TextBox();
            this.btnReplyCommentOK = new System.Windows.Forms.Button();
            this.btnReplyComment = new System.Windows.Forms.Button();
            this.rtxtFirstReply = new System.Windows.Forms.RichTextBox();
            this.labPostTime = new System.Windows.Forms.Label();
            this.labAuthorName = new System.Windows.Forms.Label();
            this.labShowTitle = new System.Windows.Forms.Label();
            this.labLine = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelReplyComment.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rtxtFirstFloorContext);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.labPostTime);
            this.groupBox1.Controls.Add(this.labAuthorName);
            this.groupBox1.Controls.Add(this.labShowTitle);
            this.groupBox1.Controls.Add(this.labLine);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(20, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(866, 625);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "發文";
            // 
            // rtxtFirstFloorContext
            // 
            this.rtxtFirstFloorContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(240)))));
            this.rtxtFirstFloorContext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtFirstFloorContext.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtxtFirstFloorContext.Location = new System.Drawing.Point(27, 78);
            this.rtxtFirstFloorContext.Name = "rtxtFirstFloorContext";
            this.rtxtFirstFloorContext.ReadOnly = true;
            this.rtxtFirstFloorContext.Size = new System.Drawing.Size(829, 163);
            this.rtxtFirstFloorContext.TabIndex = 6;
            this.rtxtFirstFloorContext.Text = "";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btnGoBack);
            this.panel1.Controls.Add(this.panelReplyComment);
            this.panel1.Controls.Add(this.btnReplyComment);
            this.panel1.Controls.Add(this.rtxtFirstReply);
            this.panel1.Location = new System.Drawing.Point(112, 249);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 351);
            this.panel1.TabIndex = 5;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnGoBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnGoBack.Location = new System.Drawing.Point(262, 293);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(161, 39);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "回上一頁";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // panelReplyComment
            // 
            this.panelReplyComment.AutoSize = true;
            this.panelReplyComment.Controls.Add(this.txtReplyComment);
            this.panelReplyComment.Controls.Add(this.btnReplyCommentOK);
            this.panelReplyComment.Location = new System.Drawing.Point(5, 205);
            this.panelReplyComment.Name = "panelReplyComment";
            this.panelReplyComment.Size = new System.Drawing.Size(736, 82);
            this.panelReplyComment.TabIndex = 8;
            this.panelReplyComment.Visible = false;
            // 
            // txtReplyComment
            // 
            this.txtReplyComment.Location = new System.Drawing.Point(3, 13);
            this.txtReplyComment.MaxLength = 75;
            this.txtReplyComment.Name = "txtReplyComment";
            this.txtReplyComment.Size = new System.Drawing.Size(730, 22);
            this.txtReplyComment.TabIndex = 0;
            // 
            // btnReplyCommentOK
            // 
            this.btnReplyCommentOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnReplyCommentOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnReplyCommentOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplyCommentOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnReplyCommentOK.Location = new System.Drawing.Point(665, 41);
            this.btnReplyCommentOK.Name = "btnReplyCommentOK";
            this.btnReplyCommentOK.Size = new System.Drawing.Size(68, 31);
            this.btnReplyCommentOK.TabIndex = 7;
            this.btnReplyCommentOK.Text = "確定發出";
            this.btnReplyCommentOK.UseVisualStyleBackColor = false;
            this.btnReplyCommentOK.Click += new System.EventHandler(this.btnReplyCommentOK_Click);
            // 
            // btnReplyComment
            // 
            this.btnReplyComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnReplyComment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnReplyComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplyComment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnReplyComment.Location = new System.Drawing.Point(671, 168);
            this.btnReplyComment.Name = "btnReplyComment";
            this.btnReplyComment.Size = new System.Drawing.Size(68, 31);
            this.btnReplyComment.TabIndex = 7;
            this.btnReplyComment.Text = "回覆";
            this.btnReplyComment.UseVisualStyleBackColor = false;
            this.btnReplyComment.Click += new System.EventHandler(this.btnReplyComment_Click);
            // 
            // rtxtFirstReply
            // 
            this.rtxtFirstReply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.rtxtFirstReply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtFirstReply.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtxtFirstReply.Location = new System.Drawing.Point(5, 3);
            this.rtxtFirstReply.Name = "rtxtFirstReply";
            this.rtxtFirstReply.ReadOnly = true;
            this.rtxtFirstReply.Size = new System.Drawing.Size(736, 196);
            this.rtxtFirstReply.TabIndex = 2;
            this.rtxtFirstReply.Text = "";
            // 
            // labPostTime
            // 
            this.labPostTime.AutoSize = true;
            this.labPostTime.BackColor = System.Drawing.Color.Transparent;
            this.labPostTime.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPostTime.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labPostTime.Location = new System.Drawing.Point(658, 31);
            this.labPostTime.Name = "labPostTime";
            this.labPostTime.Size = new System.Drawing.Size(60, 17);
            this.labPostTime.TabIndex = 3;
            this.labPostTime.Text = "發文時間";
            // 
            // labAuthorName
            // 
            this.labAuthorName.AutoSize = true;
            this.labAuthorName.BackColor = System.Drawing.Color.Transparent;
            this.labAuthorName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAuthorName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labAuthorName.Location = new System.Drawing.Point(55, 58);
            this.labAuthorName.Name = "labAuthorName";
            this.labAuthorName.Size = new System.Drawing.Size(34, 17);
            this.labAuthorName.TabIndex = 1;
            this.labAuthorName.Text = "作者";
            // 
            // labShowTitle
            // 
            this.labShowTitle.AutoSize = true;
            this.labShowTitle.BackColor = System.Drawing.Color.Transparent;
            this.labShowTitle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowTitle.Location = new System.Drawing.Point(42, 20);
            this.labShowTitle.Name = "labShowTitle";
            this.labShowTitle.Size = new System.Drawing.Size(62, 31);
            this.labShowTitle.TabIndex = 1;
            this.labShowTitle.Text = "標題";
            // 
            // labLine
            // 
            this.labLine.AutoSize = true;
            this.labLine.BackColor = System.Drawing.Color.Transparent;
            this.labLine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLine.Location = new System.Drawing.Point(42, 39);
            this.labLine.Name = "labLine";
            this.labLine.Size = new System.Drawing.Size(610, 24);
            this.labLine.TabIndex = 1;
            this.labLine.Text = "---------------------------------------------------------------------------";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 707);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Frm_ForumTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1102, 723);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_ForumTopic";
            this.Text = "Frm_ForumTopic";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelReplyComment.ResumeLayout(false);
            this.panelReplyComment.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labShowTitle;
        private System.Windows.Forms.Label labLine;
        private System.Windows.Forms.Label labAuthorName;
        private System.Windows.Forms.Label labPostTime;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.RichTextBox rtxtFirstFloorContext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxtFirstReply;
        private System.Windows.Forms.Panel panelReplyComment;
        private System.Windows.Forms.Button btnReplyComment;
        private System.Windows.Forms.TextBox txtReplyComment;
        private System.Windows.Forms.Button btnReplyCommentOK;
    }
}