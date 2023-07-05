namespace prjWantWantWinForm._08.Forum
{
    partial class Frm_ForumServiceCMS
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewMGR = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labLine = new System.Windows.Forms.Label();
            this.btnModifyPost = new System.Windows.Forms.Button();
            this.btnCommentMGR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMGR)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewMGR);
            this.panel2.Location = new System.Drawing.Point(196, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 523);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewMGR
            // 
            this.dataGridViewMGR.AllowUserToAddRows = false;
            this.dataGridViewMGR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMGR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMGR.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMGR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewMGR.Name = "dataGridViewMGR";
            this.dataGridViewMGR.RowTemplate.Height = 24;
            this.dataGridViewMGR.Size = new System.Drawing.Size(744, 523);
            this.dataGridViewMGR.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.labLine);
            this.panel1.Controls.Add(this.btnModifyPost);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCommentMGR);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 523);
            this.panel1.TabIndex = 4;
            // 
            // labLine
            // 
            this.labLine.AutoSize = true;
            this.labLine.BackColor = System.Drawing.Color.Transparent;
            this.labLine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLine.Location = new System.Drawing.Point(3, 128);
            this.labLine.Name = "labLine";
            this.labLine.Size = new System.Drawing.Size(170, 24);
            this.labLine.TabIndex = 6;
            this.labLine.Text = "--------------------";
            // 
            // btnModifyPost
            // 
            this.btnModifyPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnModifyPost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnModifyPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPost.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnModifyPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnModifyPost.Location = new System.Drawing.Point(7, 14);
            this.btnModifyPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyPost.Name = "btnModifyPost";
            this.btnModifyPost.Size = new System.Drawing.Size(162, 51);
            this.btnModifyPost.TabIndex = 4;
            this.btnModifyPost.Text = "發文管理";
            this.btnModifyPost.UseVisualStyleBackColor = false;
            this.btnModifyPost.Click += new System.EventHandler(this.btnModifyPost_Click);
            // 
            // btnCommentMGR
            // 
            this.btnCommentMGR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnCommentMGR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnCommentMGR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommentMGR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCommentMGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnCommentMGR.Location = new System.Drawing.Point(7, 73);
            this.btnCommentMGR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCommentMGR.Name = "btnCommentMGR";
            this.btnCommentMGR.Size = new System.Drawing.Size(162, 51);
            this.btnCommentMGR.TabIndex = 4;
            this.btnCommentMGR.Text = "留言管理";
            this.btnCommentMGR.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.button1.Location = new System.Drawing.Point(8, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "討論區塊開放管理";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Frm_ForumServiceCMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(958, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_ForumServiceCMS";
            this.Text = "Frm_ForumServiceCMS";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMGR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewMGR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labLine;
        private System.Windows.Forms.Button btnModifyPost;
        private System.Windows.Forms.Button btnCommentMGR;
        private System.Windows.Forms.Button button1;
    }
}