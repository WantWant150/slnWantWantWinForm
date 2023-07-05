namespace prjWantWantWinForm
{
    partial class FrmBackStage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnFourm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.splitContainer1.Panel1.Controls.Add(this.btnFourm);
            this.splitContainer1.Panel1.Controls.Add(this.btnPoint);
            this.splitContainer1.Panel1.Controls.Add(this.btnMember);
            this.splitContainer1.Panel1.Controls.Add(this.btnTask);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Snow;
            this.splitContainer1.Size = new System.Drawing.Size(1006, 721);
            this.splitContainer1.SplitterDistance = 194;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.SeaShell;
            this.btnTask.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTask.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnTask.Location = new System.Drawing.Point(12, 66);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(162, 35);
            this.btnTask.TabIndex = 212;
            this.btnTask.Text = "任務管理";
            this.btnTask.UseVisualStyleBackColor = false;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.SeaShell;
            this.btnMember.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMember.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnMember.Location = new System.Drawing.Point(12, 116);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(162, 35);
            this.btnMember.TabIndex = 212;
            this.btnMember.Text = "會員管理";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.SeaShell;
            this.btnPoint.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPoint.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnPoint.Location = new System.Drawing.Point(12, 167);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(162, 35);
            this.btnPoint.TabIndex = 212;
            this.btnPoint.Text = "點數商城管理";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnFourm
            // 
            this.btnFourm.BackColor = System.Drawing.Color.SeaShell;
            this.btnFourm.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFourm.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnFourm.Location = new System.Drawing.Point(12, 223);
            this.btnFourm.Name = "btnFourm";
            this.btnFourm.Size = new System.Drawing.Size(162, 35);
            this.btnFourm.TabIndex = 212;
            this.btnFourm.Text = "討論區管理";
            this.btnFourm.UseVisualStyleBackColor = false;
            this.btnFourm.Click += new System.EventHandler(this.btnFourm_Click);
            // 
            // FrmBackStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmBackStage";
            this.Text = "後台";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnFourm;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnMember;
    }
}