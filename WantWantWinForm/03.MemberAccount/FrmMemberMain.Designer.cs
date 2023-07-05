namespace prjWantWantWinForm
{
    partial class FrmMemberMain
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnFrmMemberInfo = new System.Windows.Forms.Button();
            this.btnFrmChangePassword = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(13, 215);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 49);
            this.button2.TabIndex = 24;
            this.button2.Text = "委託專家紀錄";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFrmMemberInfo
            // 
            this.btnFrmMemberInfo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFrmMemberInfo.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFrmMemberInfo.ForeColor = System.Drawing.Color.White;
            this.btnFrmMemberInfo.Location = new System.Drawing.Point(13, 45);
            this.btnFrmMemberInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFrmMemberInfo.Name = "btnFrmMemberInfo";
            this.btnFrmMemberInfo.Size = new System.Drawing.Size(280, 49);
            this.btnFrmMemberInfo.TabIndex = 33;
            this.btnFrmMemberInfo.Text = "個人基本資料";
            this.btnFrmMemberInfo.UseVisualStyleBackColor = false;
            this.btnFrmMemberInfo.Click += new System.EventHandler(this.btnFrmMemberInfo_Click);
            // 
            // btnFrmChangePassword
            // 
            this.btnFrmChangePassword.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFrmChangePassword.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFrmChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnFrmChangePassword.Location = new System.Drawing.Point(13, 102);
            this.btnFrmChangePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFrmChangePassword.Name = "btnFrmChangePassword";
            this.btnFrmChangePassword.Size = new System.Drawing.Size(280, 49);
            this.btnFrmChangePassword.TabIndex = 35;
            this.btnFrmChangePassword.Text = "更改密碼";
            this.btnFrmChangePassword.UseVisualStyleBackColor = false;
            this.btnFrmChangePassword.Click += new System.EventHandler(this.btnFrmChangePassword_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button13.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(13, 159);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(280, 49);
            this.button13.TabIndex = 24;
            this.button13.Text = "專家管理";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // FrmMemberMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnFrmChangePassword);
            this.Controls.Add(this.btnFrmMemberInfo);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMemberMain";
            this.Text = "FrmMemberMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFrmMemberInfo;
        private System.Windows.Forms.Button btnFrmChangePassword;
        private System.Windows.Forms.Button button13;
    }
}