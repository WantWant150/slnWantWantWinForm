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
            this.btnGraphAnalysis = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.splitContainer1.Panel1.Controls.Add(this.btnGraphAnalysis);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnMessage);
            this.splitContainer1.Panel1.Controls.Add(this.btnPoint);
            this.splitContainer1.Panel1.Controls.Add(this.btnMember);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Snow;
            this.splitContainer1.Size = new System.Drawing.Size(1132, 865);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnGraphAnalysis
            // 
            this.btnGraphAnalysis.BackColor = System.Drawing.Color.SeaShell;
            this.btnGraphAnalysis.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGraphAnalysis.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnGraphAnalysis.Location = new System.Drawing.Point(14, 392);
            this.btnGraphAnalysis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGraphAnalysis.Name = "btnGraphAnalysis";
            this.btnGraphAnalysis.Size = new System.Drawing.Size(182, 42);
            this.btnGraphAnalysis.TabIndex = 214;
            this.btnGraphAnalysis.Text = "圖表分析";
            this.btnGraphAnalysis.UseVisualStyleBackColor = false;
            this.btnGraphAnalysis.Click += new System.EventHandler(this.btnGraphAnalysis_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.SeaShell;
            this.btnOrder.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrder.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnOrder.Location = new System.Drawing.Point(14, 259);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(182, 42);
            this.btnOrder.TabIndex = 213;
            this.btnOrder.Text = "訂單管理";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.SeaShell;
            this.btnMessage.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMessage.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnMessage.Location = new System.Drawing.Point(14, 326);
            this.btnMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(182, 42);
            this.btnMessage.TabIndex = 212;
            this.btnMessage.Text = "會員訊息管理";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.SeaShell;
            this.btnPoint.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPoint.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnPoint.Location = new System.Drawing.Point(14, 199);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(182, 42);
            this.btnPoint.TabIndex = 212;
            this.btnPoint.Text = "點數商品管理";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.SeaShell;
            this.btnMember.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMember.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnMember.Location = new System.Drawing.Point(14, 139);
            this.btnMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(182, 42);
            this.btnMember.TabIndex = 212;
            this.btnMember.Text = "會員管理";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // FrmBackStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 865);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBackStage";
            this.Text = "後台";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnGraphAnalysis;
    }
}