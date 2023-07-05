namespace prjWantWantWinForm
{
    partial class Frm_ForumEnterCategory
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
            this.labShow_CategoryTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labAuthor = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labReplyCount = new System.Windows.Forms.Label();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.labReplyTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labShow_CategoryTitle
            // 
            this.labShow_CategoryTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labShow_CategoryTitle.AutoSize = true;
            this.labShow_CategoryTitle.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow_CategoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.labShow_CategoryTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labShow_CategoryTitle.Location = new System.Drawing.Point(12, 9);
            this.labShow_CategoryTitle.Name = "labShow_CategoryTitle";
            this.labShow_CategoryTitle.Size = new System.Drawing.Size(123, 35);
            this.labShow_CategoryTitle.TabIndex = 0;
            this.labShow_CategoryTitle.Text = "論壇標題";
            this.labShow_CategoryTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labAuthor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labReplyCount, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labReplyTime, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1165, 36);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labAuthor
            // 
            this.labAuthor.AutoSize = true;
            this.labAuthor.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAuthor.Location = new System.Drawing.Point(585, 1);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Padding = new System.Windows.Forms.Padding(5);
            this.labAuthor.Size = new System.Drawing.Size(58, 34);
            this.labAuthor.TabIndex = 0;
            this.labAuthor.Text = "作者";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(4, 1);
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new System.Windows.Forms.Padding(5);
            this.labTitle.Size = new System.Drawing.Size(96, 34);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "討論主題";
            // 
            // labReplyCount
            // 
            this.labReplyCount.AutoSize = true;
            this.labReplyCount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labReplyCount.Location = new System.Drawing.Point(760, 1);
            this.labReplyCount.Name = "labReplyCount";
            this.labReplyCount.Padding = new System.Windows.Forms.Padding(5);
            this.labReplyCount.Size = new System.Drawing.Size(77, 34);
            this.labReplyCount.TabIndex = 0;
            this.labReplyCount.Text = "回覆數";
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreatePost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnCreatePost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnCreatePost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnCreatePost.Location = new System.Drawing.Point(965, 5);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(219, 36);
            this.btnCreatePost.TabIndex = 4;
            this.btnCreatePost.Text = "我要發文";
            this.btnCreatePost.UseVisualStyleBackColor = false;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // labReplyTime
            // 
            this.labReplyTime.AutoSize = true;
            this.labReplyTime.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labReplyTime.Location = new System.Drawing.Point(935, 1);
            this.labReplyTime.Name = "labReplyTime";
            this.labReplyTime.Padding = new System.Windows.Forms.Padding(5);
            this.labReplyTime.Size = new System.Drawing.Size(96, 34);
            this.labReplyTime.TabIndex = 0;
            this.labReplyTime.Text = "發文時間";
            // 
            // Frm_ForumEnterCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1196, 438);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labShow_CategoryTitle);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_ForumEnterCategory";
            this.Text = "Frm_ForumEnterCategory";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labShow_CategoryTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labAuthor;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labReplyCount;
        private System.Windows.Forms.Button btnCreatePost;
        private System.Windows.Forms.Label labReplyTime;
    }
}