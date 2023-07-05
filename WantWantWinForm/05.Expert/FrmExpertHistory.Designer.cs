namespace prjWantWantWinForm
{
    partial class FrmExpertHistory
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label1;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.check = new System.Windows.Forms.DataGridViewButtonColumn();
            this.No = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Finish = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            cityIDLabel1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityIDLabel1
            // 
            cityIDLabel1.AutoSize = true;
            cityIDLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            cityIDLabel1.Location = new System.Drawing.Point(23, 9);
            cityIDLabel1.Name = "cityIDLabel1";
            cityIDLabel1.Size = new System.Drawing.Size(105, 20);
            cityIDLabel1.TabIndex = 185;
            cityIDLabel1.Text = "委託案件紀錄";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label7.Location = new System.Drawing.Point(12, 26);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(89, 20);
            label7.TabIndex = 197;
            label7.Text = "我是接案人";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label8.Location = new System.Drawing.Point(12, 256);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(89, 20);
            label8.TabIndex = 198;
            label8.Text = "我是委託人";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.No,
            this.Finish});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 75);
            this.dataGridView1.TabIndex = 188;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // check
            // 
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.check.HeaderText = "接案";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            this.check.Text = "接案";
            this.check.ToolTipText = "接案";
            this.check.UseColumnTextForButtonValue = true;
            this.check.Width = 125;
            // 
            // No
            // 
            this.No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No.HeaderText = "拒絕";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Text = "拒絕";
            this.No.UseColumnTextForButtonValue = true;
            this.No.Width = 125;
            // 
            // Finish
            // 
            this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Finish.HeaderText = "完成";
            this.Finish.MinimumWidth = 6;
            this.Finish.Name = "Finish";
            this.Finish.Text = "完成任務";
            this.Finish.UseColumnTextForButtonValue = true;
            this.Finish.Width = 125;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(925, 237);
            this.dataGridView4.TabIndex = 191;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 237);
            this.panel1.TabIndex = 199;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 75);
            this.panel2.TabIndex = 200;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(cityIDLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 80);
            this.panel3.TabIndex = 201;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label1.Location = new System.Drawing.Point(28, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 20);
            label1.TabIndex = 192;
            label1.Text = "接案紀錄";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(925, 78);
            this.panel4.TabIndex = 202;
            // 
            // ExpertHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(925, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExpertHistory";
            this.Text = "ExpertHistory";
            this.Load += new System.EventHandler(this.ExpertHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewButtonColumn check;
        private System.Windows.Forms.DataGridViewButtonColumn No;
        private System.Windows.Forms.DataGridViewButtonColumn Finish;
        private System.Windows.Forms.Panel panel4;
    }
}