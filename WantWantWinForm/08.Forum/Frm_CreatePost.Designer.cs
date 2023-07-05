namespace prjWantWantWinForm
{
    partial class Frm_CreatePost
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.labNoAct_Title = new System.Windows.Forms.Label();
            this.labNoAct_Comment = new System.Windows.Forms.Label();
            this.btnSendPost = new System.Windows.Forms.Button();
            this.btnSaveDraft = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labShowNowCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(104, 101);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.MaxLength = 25;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(557, 29);
            this.txtTitle.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(104, 162);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(557, 268);
            this.txtContent.TabIndex = 0;
            // 
            // labNoAct_Title
            // 
            this.labNoAct_Title.AutoSize = true;
            this.labNoAct_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.labNoAct_Title.Location = new System.Drawing.Point(39, 105);
            this.labNoAct_Title.Name = "labNoAct_Title";
            this.labNoAct_Title.Size = new System.Drawing.Size(45, 20);
            this.labNoAct_Title.TabIndex = 1;
            this.labNoAct_Title.Text = "標題:";
            // 
            // labNoAct_Comment
            // 
            this.labNoAct_Comment.AutoSize = true;
            this.labNoAct_Comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.labNoAct_Comment.Location = new System.Drawing.Point(39, 162);
            this.labNoAct_Comment.Name = "labNoAct_Comment";
            this.labNoAct_Comment.Size = new System.Drawing.Size(45, 20);
            this.labNoAct_Comment.TabIndex = 1;
            this.labNoAct_Comment.Text = "內文:";
            // 
            // btnSendPost
            // 
            this.btnSendPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnSendPost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnSendPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnSendPost.Location = new System.Drawing.Point(247, 460);
            this.btnSendPost.Name = "btnSendPost";
            this.btnSendPost.Size = new System.Drawing.Size(122, 36);
            this.btnSendPost.TabIndex = 5;
            this.btnSendPost.Text = "確定送出";
            this.btnSendPost.UseVisualStyleBackColor = false;
            this.btnSendPost.Click += new System.EventHandler(this.btnSendPost_Click);
            // 
            // btnSaveDraft
            // 
            this.btnSaveDraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnSaveDraft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnSaveDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDraft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnSaveDraft.Location = new System.Drawing.Point(393, 460);
            this.btnSaveDraft.Name = "btnSaveDraft";
            this.btnSaveDraft.Size = new System.Drawing.Size(122, 36);
            this.btnSaveDraft.TabIndex = 5;
            this.btnSaveDraft.Text = "儲存草稿";
            this.btnSaveDraft.UseVisualStyleBackColor = false;
            this.btnSaveDraft.Click += new System.EventHandler(this.btnSaveDraft_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnCancel.Location = new System.Drawing.Point(539, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消退出";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labShowNowCategory
            // 
            this.labShowNowCategory.AutoSize = true;
            this.labShowNowCategory.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowNowCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.labShowNowCategory.Location = new System.Drawing.Point(39, 33);
            this.labShowNowCategory.Name = "labShowNowCategory";
            this.labShowNowCategory.Size = new System.Drawing.Size(53, 24);
            this.labShowNowCategory.TabIndex = 1;
            this.labShowNowCategory.Text = "內文:";
            // 
            // Frm_CreatePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1364, 1061);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveDraft);
            this.Controls.Add(this.btnSendPost);
            this.Controls.Add(this.labShowNowCategory);
            this.Controls.Add(this.labNoAct_Comment);
            this.Controls.Add(this.labNoAct_Title);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_CreatePost";
            this.Text = "Frm_CreatePost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label labNoAct_Title;
        private System.Windows.Forms.Label labNoAct_Comment;
        private System.Windows.Forms.Button btnSendPost;
        private System.Windows.Forms.Button btnSaveDraft;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labShowNowCategory;
    }
}