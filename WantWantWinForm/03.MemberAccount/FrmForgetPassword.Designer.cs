namespace prjWantWantWinForm
{
    partial class FrmForgetPassword
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnChangeValidateCode = new System.Windows.Forms.Button();
            this.txtBoxValidateCode = new System.Windows.Forms.TextBox();
            this.picValidateCode = new System.Windows.Forms.PictureBox();
            this.txtBoxMemberEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picValidateCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEnter.Location = new System.Drawing.Point(308, 174);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(85, 49);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "確認";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnChangeValidateCode
            // 
            this.btnChangeValidateCode.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChangeValidateCode.Location = new System.Drawing.Point(273, 116);
            this.btnChangeValidateCode.Name = "btnChangeValidateCode";
            this.btnChangeValidateCode.Size = new System.Drawing.Size(100, 39);
            this.btnChangeValidateCode.TabIndex = 6;
            this.btnChangeValidateCode.Text = "更換圖片";
            this.btnChangeValidateCode.UseVisualStyleBackColor = true;
            this.btnChangeValidateCode.Click += new System.EventHandler(this.btnChangeValidateCode_Click);
            // 
            // txtBoxValidateCode
            // 
            this.txtBoxValidateCode.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxValidateCode.Location = new System.Drawing.Point(25, 120);
            this.txtBoxValidateCode.Name = "txtBoxValidateCode";
            this.txtBoxValidateCode.Size = new System.Drawing.Size(100, 33);
            this.txtBoxValidateCode.TabIndex = 5;
            // 
            // picValidateCode
            // 
            this.picValidateCode.Location = new System.Drawing.Point(148, 116);
            this.picValidateCode.Name = "picValidateCode";
            this.picValidateCode.Size = new System.Drawing.Size(100, 39);
            this.picValidateCode.TabIndex = 4;
            this.picValidateCode.TabStop = false;
            // 
            // txtBoxMemberEmail
            // 
            this.txtBoxMemberEmail.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxMemberEmail.Location = new System.Drawing.Point(29, 53);
            this.txtBoxMemberEmail.Name = "txtBoxMemberEmail";
            this.txtBoxMemberEmail.Size = new System.Drawing.Size(218, 33);
            this.txtBoxMemberEmail.TabIndex = 13;
            this.txtBoxMemberEmail.Text = "aaa@abc.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "驗證碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "帳號(電子郵件)";
            // 
            // FrmForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 242);
            this.Controls.Add(this.txtBoxMemberEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnChangeValidateCode);
            this.Controls.Add(this.txtBoxValidateCode);
            this.Controls.Add(this.picValidateCode);
            this.Name = "FrmForgetPassword";
            this.Text = "FrmForgetPassword";
            ((System.ComponentModel.ISupportInitialize)(this.picValidateCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnChangeValidateCode;
        private System.Windows.Forms.TextBox txtBoxValidateCode;
        private System.Windows.Forms.PictureBox picValidateCode;
        private System.Windows.Forms.TextBox txtBoxMemberEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}