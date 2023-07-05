namespace prjWantWantWinForm
{
    partial class 已上架
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublishEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_TaskNumberID = new System.Windows.Forms.ComboBox();
            this.btn_Search1 = new System.Windows.Forms.Button();
            this.dTP_TaskEnd = new System.Windows.Forms.DateTimePicker();
            this.dTP_TaskStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Detail = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.LightCoral;
            this.label9.Location = new System.Drawing.Point(69, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 31);
            this.label9.TabIndex = 200;
            this.label9.Text = "任務類型";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CaseID,
            this.TaskStart,
            this.TaskEnd,
            this.PublishStart,
            this.PublishEnd,
            this.TaskTitle,
            this.TaskDetail});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(37, 383);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 323);
            this.dataGridView1.TabIndex = 202;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // CaseID
            // 
            this.CaseID.HeaderText = "案件編號";
            this.CaseID.MinimumWidth = 6;
            this.CaseID.Name = "CaseID";
            // 
            // TaskStart
            // 
            this.TaskStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskStart.DefaultCellStyle = dataGridViewCellStyle2;
            this.TaskStart.HeaderText = "任務日期起";
            this.TaskStart.MinimumWidth = 6;
            this.TaskStart.Name = "TaskStart";
            // 
            // TaskEnd
            // 
            this.TaskEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskEnd.DefaultCellStyle = dataGridViewCellStyle3;
            this.TaskEnd.HeaderText = "任務日期迄";
            this.TaskEnd.MinimumWidth = 6;
            this.TaskEnd.Name = "TaskEnd";
            // 
            // PublishStart
            // 
            this.PublishStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PublishStart.DefaultCellStyle = dataGridViewCellStyle4;
            this.PublishStart.HeaderText = "刊登日期起";
            this.PublishStart.MinimumWidth = 6;
            this.PublishStart.Name = "PublishStart";
            // 
            // PublishEnd
            // 
            this.PublishEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PublishEnd.DefaultCellStyle = dataGridViewCellStyle5;
            this.PublishEnd.HeaderText = "刊登日期迄";
            this.PublishEnd.MinimumWidth = 6;
            this.PublishEnd.Name = "PublishEnd";
            // 
            // TaskTitle
            // 
            this.TaskTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskTitle.DefaultCellStyle = dataGridViewCellStyle6;
            this.TaskTitle.HeaderText = "任務標題";
            this.TaskTitle.MinimumWidth = 6;
            this.TaskTitle.Name = "TaskTitle";
            this.TaskTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TaskDetail
            // 
            this.TaskDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskDetail.DefaultCellStyle = dataGridViewCellStyle7;
            this.TaskDetail.HeaderText = "任務內容";
            this.TaskDetail.MinimumWidth = 6;
            this.TaskDetail.Name = "TaskDetail";
            // 
            // cmb_TaskNumberID
            // 
            this.cmb_TaskNumberID.BackColor = System.Drawing.Color.White;
            this.cmb_TaskNumberID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_TaskNumberID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmb_TaskNumberID.FormattingEnabled = true;
            this.cmb_TaskNumberID.Location = new System.Drawing.Point(197, 100);
            this.cmb_TaskNumberID.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_TaskNumberID.Name = "cmb_TaskNumberID";
            this.cmb_TaskNumberID.Size = new System.Drawing.Size(143, 33);
            this.cmb_TaskNumberID.TabIndex = 199;
            this.cmb_TaskNumberID.Text = "請選擇";
            // 
            // btn_Search1
            // 
            this.btn_Search1.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Search1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search1.ForeColor = System.Drawing.Color.White;
            this.btn_Search1.Location = new System.Drawing.Point(656, 280);
            this.btn_Search1.Name = "btn_Search1";
            this.btn_Search1.Size = new System.Drawing.Size(80, 42);
            this.btn_Search1.TabIndex = 201;
            this.btn_Search1.Text = "搜尋";
            this.btn_Search1.UseVisualStyleBackColor = false;
            this.btn_Search1.Click += new System.EventHandler(this.btn_Search1_Click_1);
            // 
            // dTP_TaskEnd
            // 
            this.dTP_TaskEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dTP_TaskEnd.Location = new System.Drawing.Point(432, 152);
            this.dTP_TaskEnd.Name = "dTP_TaskEnd";
            this.dTP_TaskEnd.Size = new System.Drawing.Size(205, 34);
            this.dTP_TaskEnd.TabIndex = 196;
            // 
            // dTP_TaskStart
            // 
            this.dTP_TaskStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dTP_TaskStart.Location = new System.Drawing.Point(197, 152);
            this.dTP_TaskStart.Name = "dTP_TaskStart";
            this.dTP_TaskStart.Size = new System.Drawing.Size(205, 34);
            this.dTP_TaskStart.TabIndex = 195;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(69, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 193;
            this.label1.Text = "任務日期";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(403, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 194;
            this.label2.Text = "~";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(69, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 185;
            this.label4.Text = "任務標題";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(69, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 187;
            this.label5.Text = "任務內容";
            // 
            // txt_Detail
            // 
            this.txt_Detail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Detail.Location = new System.Drawing.Point(197, 258);
            this.txt_Detail.Multiline = true;
            this.txt_Detail.Name = "txt_Detail";
            this.txt_Detail.Size = new System.Drawing.Size(435, 95);
            this.txt_Detail.TabIndex = 188;
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Title.Location = new System.Drawing.Point(197, 206);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(435, 34);
            this.txt_Title.TabIndex = 186;
            // 
            // 已上架
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(842, 795);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_TaskNumberID);
            this.Controls.Add(this.btn_Search1);
            this.Controls.Add(this.dTP_TaskEnd);
            this.Controls.Add(this.dTP_TaskStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Detail);
            this.Controls.Add(this.txt_Title);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "已上架";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "已發包";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_TaskNumberID;
        private System.Windows.Forms.Button btn_Search1;
        private System.Windows.Forms.DateTimePicker dTP_TaskEnd;
        private System.Windows.Forms.DateTimePicker dTP_TaskStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Detail;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublishEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDetail;
    }
}