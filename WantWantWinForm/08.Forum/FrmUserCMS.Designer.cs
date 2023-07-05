namespace WinFormsMidSora
{
    partial class FrmUserCMS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewMGR = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labLine = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCommentMGR = new System.Windows.Forms.Button();
            this.btnModifyPost = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMGR)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridViewMGR);
            this.panel2.Location = new System.Drawing.Point(181, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 523);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewMGR
            // 
            this.dataGridViewMGR.AllowUserToAddRows = false;
            this.dataGridViewMGR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMGR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDelete,
            this.btnModify});
            this.dataGridViewMGR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMGR.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMGR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewMGR.Name = "dataGridViewMGR";
            this.dataGridViewMGR.RowTemplate.Height = 24;
            this.dataGridViewMGR.Size = new System.Drawing.Size(744, 523);
            this.dataGridViewMGR.TabIndex = 0;
            this.dataGridViewMGR.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewMGR_CellBeginEdit);
            this.dataGridViewMGR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMGR_CellContentClick);
            this.dataGridViewMGR.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMGR_CellEndEdit);
            // 
            // btnDelete
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle13;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "刪除";
            this.btnDelete.MinimumWidth = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDelete.Text = "刪除";
            this.btnDelete.ToolTipText = "刪除";
            this.btnDelete.UseColumnTextForButtonValue = true;
            this.btnDelete.Width = 50;
            // 
            // btnModify
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModify.DefaultCellStyle = dataGridViewCellStyle14;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.HeaderText = "修改";
            this.btnModify.MinimumWidth = 8;
            this.btnModify.Name = "btnModify";
            this.btnModify.Text = "修改";
            this.btnModify.UseColumnTextForButtonValue = true;
            this.btnModify.Width = 50;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.labLine);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnCommentMGR);
            this.panel1.Controls.Add(this.btnModifyPost);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 524);
            this.panel1.TabIndex = 2;
            // 
            // labLine
            // 
            this.labLine.AutoSize = true;
            this.labLine.BackColor = System.Drawing.Color.Transparent;
            this.labLine.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLine.Location = new System.Drawing.Point(3, 90);
            this.labLine.Name = "labLine";
            this.labLine.Size = new System.Drawing.Size(154, 24);
            this.labLine.TabIndex = 6;
            this.labLine.Text = "------------------";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 62);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 25);
            this.comboBox1.TabIndex = 5;
            // 
            // btnCommentMGR
            // 
            this.btnCommentMGR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnCommentMGR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnCommentMGR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommentMGR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCommentMGR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnCommentMGR.Location = new System.Drawing.Point(9, 118);
            this.btnCommentMGR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCommentMGR.Name = "btnCommentMGR";
            this.btnCommentMGR.Size = new System.Drawing.Size(142, 51);
            this.btnCommentMGR.TabIndex = 4;
            this.btnCommentMGR.Text = "個人留言管理";
            this.btnCommentMGR.UseVisualStyleBackColor = false;
            this.btnCommentMGR.Click += new System.EventHandler(this.btnCommentMGR_Click);
            // 
            // btnModifyPost
            // 
            this.btnModifyPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnModifyPost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(174)))), ((int)(((byte)(188)))));
            this.btnModifyPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPost.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnModifyPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnModifyPost.Location = new System.Drawing.Point(9, 4);
            this.btnModifyPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyPost.Name = "btnModifyPost";
            this.btnModifyPost.Size = new System.Drawing.Size(142, 51);
            this.btnModifyPost.TabIndex = 4;
            this.btnModifyPost.Text = "個人發文管理";
            this.btnModifyPost.UseVisualStyleBackColor = false;
            this.btnModifyPost.Click += new System.EventHandler(this.btnModifyPost_Click);
            // 
            // FrmUserCMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(936, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUserCMS";
            this.Text = "FrmUserCMS";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMGR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCommentMGR;
        private System.Windows.Forms.Button btnModifyPost;
        private System.Windows.Forms.DataGridView dataGridViewMGR;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn btnModify;
        private System.Windows.Forms.Label labLine;
    }
}