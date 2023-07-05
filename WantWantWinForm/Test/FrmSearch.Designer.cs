namespace prjIspanWinForms
{
    partial class FrmSearch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.tabControlSreach = new System.Windows.Forms.TabControl();
            this.tabPageTask = new System.Windows.Forms.TabPage();
            this.splitContainerTask = new System.Windows.Forms.SplitContainer();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBoxTaskCity = new System.Windows.Forms.ComboBox();
            this.btnApplyTask = new System.Windows.Forms.Button();
            this.btnSreachTask = new System.Windows.Forms.Button();
            this.txtSreachTask = new System.Windows.Forms.TextBox();
            this.labClearFilterTask = new System.Windows.Forms.Label();
            this.splitContainerTask2 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewTaskShow = new System.Windows.Forms.DataGridView();
            this.dataGridViewTask = new System.Windows.Forms.DataGridView();
            this.tabPageExpert = new System.Windows.Forms.TabPage();
            this.splitContainerExpert = new System.Windows.Forms.SplitContainer();
            this.splitContainerExport2 = new System.Windows.Forms.SplitContainer();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBoxTaskSkill = new System.Windows.Forms.ComboBox();
            this.comboBoxExpertCity = new System.Windows.Forms.ComboBox();
            this.btnApplyExpert = new System.Windows.Forms.Button();
            this.btnSreachExpert = new System.Windows.Forms.Button();
            this.txtSreachExpert = new System.Windows.Forms.TextBox();
            this.labClearFilterExpert = new System.Windows.Forms.Label();
            this.dataGridViewExportShow = new System.Windows.Forms.DataGridView();
            this.dataGridViewExportShowTop = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlSreach.SuspendLayout();
            this.tabPageTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTask)).BeginInit();
            this.splitContainerTask.Panel1.SuspendLayout();
            this.splitContainerTask.Panel2.SuspendLayout();
            this.splitContainerTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTask2)).BeginInit();
            this.splitContainerTask2.Panel1.SuspendLayout();
            this.splitContainerTask2.Panel2.SuspendLayout();
            this.splitContainerTask2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
            this.tabPageExpert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerExpert)).BeginInit();
            this.splitContainerExpert.Panel1.SuspendLayout();
            this.splitContainerExpert.Panel2.SuspendLayout();
            this.splitContainerExpert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerExport2)).BeginInit();
            this.splitContainerExport2.Panel1.SuspendLayout();
            this.splitContainerExport2.Panel2.SuspendLayout();
            this.splitContainerExport2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExportShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExportShowTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSreach
            // 
            this.tabControlSreach.Controls.Add(this.tabPageTask);
            this.tabControlSreach.Controls.Add(this.tabPageExpert);
            this.tabControlSreach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSreach.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControlSreach.Location = new System.Drawing.Point(0, 0);
            this.tabControlSreach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlSreach.Name = "tabControlSreach";
            this.tabControlSreach.SelectedIndex = 0;
            this.tabControlSreach.Size = new System.Drawing.Size(1006, 721);
            this.tabControlSreach.TabIndex = 0;
            // 
            // tabPageTask
            // 
            this.tabPageTask.BackColor = System.Drawing.Color.White;
            this.tabPageTask.Controls.Add(this.splitContainerTask);
            this.tabPageTask.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPageTask.Location = new System.Drawing.Point(4, 38);
            this.tabPageTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageTask.Name = "tabPageTask";
            this.tabPageTask.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageTask.Size = new System.Drawing.Size(998, 679);
            this.tabPageTask.TabIndex = 0;
            this.tabPageTask.Text = "找任務";
            // 
            // splitContainerTask
            // 
            this.splitContainerTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTask.Location = new System.Drawing.Point(4, 5);
            this.splitContainerTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainerTask.Name = "splitContainerTask";
            this.splitContainerTask.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTask.Panel1
            // 
            this.splitContainerTask.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.splitContainerTask.Panel1.Controls.Add(this.comboBox3);
            this.splitContainerTask.Panel1.Controls.Add(this.comboBox2);
            this.splitContainerTask.Panel1.Controls.Add(this.comboBoxTaskCity);
            this.splitContainerTask.Panel1.Controls.Add(this.btnApplyTask);
            this.splitContainerTask.Panel1.Controls.Add(this.btnSreachTask);
            this.splitContainerTask.Panel1.Controls.Add(this.txtSreachTask);
            this.splitContainerTask.Panel1.Controls.Add(this.labClearFilterTask);
            // 
            // splitContainerTask.Panel2
            // 
            this.splitContainerTask.Panel2.Controls.Add(this.splitContainerTask2);
            this.splitContainerTask.Size = new System.Drawing.Size(990, 669);
            this.splitContainerTask.SplitterDistance = 78;
            this.splitContainerTask.SplitterWidth = 7;
            this.splitContainerTask.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(277, 18);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 37);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.Text = "其他篩選";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(145, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 37);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "類別";
            // 
            // comboBoxTaskCity
            // 
            this.comboBoxTaskCity.FormattingEnabled = true;
            this.comboBoxTaskCity.Location = new System.Drawing.Point(13, 18);
            this.comboBoxTaskCity.Name = "comboBoxTaskCity";
            this.comboBoxTaskCity.Size = new System.Drawing.Size(121, 37);
            this.comboBoxTaskCity.TabIndex = 11;
            this.comboBoxTaskCity.Text = "地區";
            // 
            // btnApplyTask
            // 
            this.btnApplyTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnApplyTask.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnApplyTask.Location = new System.Drawing.Point(868, 19);
            this.btnApplyTask.Name = "btnApplyTask";
            this.btnApplyTask.Size = new System.Drawing.Size(109, 34);
            this.btnApplyTask.TabIndex = 10;
            this.btnApplyTask.Text = "立即應徵";
            this.btnApplyTask.UseVisualStyleBackColor = false;
            // 
            // btnSreachTask
            // 
            this.btnSreachTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnSreachTask.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSreachTask.Location = new System.Drawing.Point(760, 19);
            this.btnSreachTask.Name = "btnSreachTask";
            this.btnSreachTask.Size = new System.Drawing.Size(97, 34);
            this.btnSreachTask.TabIndex = 10;
            this.btnSreachTask.Text = "搜尋";
            this.btnSreachTask.UseVisualStyleBackColor = false;
            // 
            // txtSreachTask
            // 
            this.txtSreachTask.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSreachTask.Location = new System.Drawing.Point(512, 17);
            this.txtSreachTask.Name = "txtSreachTask";
            this.txtSreachTask.Size = new System.Drawing.Size(237, 38);
            this.txtSreachTask.TabIndex = 9;
            this.txtSreachTask.Text = "輸入關鍵字 ex.倒垃圾";
            // 
            // labClearFilterTask
            // 
            this.labClearFilterTask.AutoSize = true;
            this.labClearFilterTask.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labClearFilterTask.Location = new System.Drawing.Point(409, 24);
            this.labClearFilterTask.Name = "labClearFilterTask";
            this.labClearFilterTask.Size = new System.Drawing.Size(92, 25);
            this.labClearFilterTask.TabIndex = 8;
            this.labClearFilterTask.Text = "清除篩選";
            // 
            // splitContainerTask2
            // 
            this.splitContainerTask2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerTask2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTask2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTask2.Name = "splitContainerTask2";
            this.splitContainerTask2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTask2.Panel1
            // 
            this.splitContainerTask2.Panel1.Controls.Add(this.dataGridViewTaskShow);
            // 
            // splitContainerTask2.Panel2
            // 
            this.splitContainerTask2.Panel2.Controls.Add(this.dataGridViewTask);
            this.splitContainerTask2.Size = new System.Drawing.Size(990, 584);
            this.splitContainerTask2.SplitterDistance = 340;
            this.splitContainerTask2.TabIndex = 0;
            // 
            // dataGridViewTaskShow
            // 
            this.dataGridViewTaskShow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dataGridViewTaskShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTaskShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTaskShow.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTaskShow.Name = "dataGridViewTaskShow";
            this.dataGridViewTaskShow.RowHeadersWidth = 51;
            this.dataGridViewTaskShow.RowTemplate.Height = 27;
            this.dataGridViewTaskShow.Size = new System.Drawing.Size(988, 338);
            this.dataGridViewTaskShow.TabIndex = 0;
            // 
            // dataGridViewTask
            // 
            this.dataGridViewTask.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTask.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.RowHeadersWidth = 51;
            this.dataGridViewTask.RowTemplate.Height = 27;
            this.dataGridViewTask.Size = new System.Drawing.Size(988, 238);
            this.dataGridViewTask.TabIndex = 0;
            // 
            // tabPageExpert
            // 
            this.tabPageExpert.BackColor = System.Drawing.Color.White;
            this.tabPageExpert.Controls.Add(this.splitContainerExpert);
            this.tabPageExpert.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPageExpert.Location = new System.Drawing.Point(4, 38);
            this.tabPageExpert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageExpert.Name = "tabPageExpert";
            this.tabPageExpert.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageExpert.Size = new System.Drawing.Size(998, 679);
            this.tabPageExpert.TabIndex = 1;
            this.tabPageExpert.Text = "找專家";
            // 
            // splitContainerExpert
            // 
            this.splitContainerExpert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerExpert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerExpert.Location = new System.Drawing.Point(4, 5);
            this.splitContainerExpert.Name = "splitContainerExpert";
            this.splitContainerExpert.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerExpert.Panel1
            // 
            this.splitContainerExpert.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerExpert.Panel1.Controls.Add(this.splitContainerExport2);
            // 
            // splitContainerExpert.Panel2
            // 
            this.splitContainerExpert.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainerExpert.Panel2.Controls.Add(this.dataGridViewExportShowTop);
            this.splitContainerExpert.Size = new System.Drawing.Size(990, 669);
            this.splitContainerExpert.SplitterDistance = 435;
            this.splitContainerExpert.TabIndex = 0;
            // 
            // splitContainerExport2
            // 
            this.splitContainerExport2.BackColor = System.Drawing.Color.White;
            this.splitContainerExport2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerExport2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerExport2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerExport2.Name = "splitContainerExport2";
            this.splitContainerExport2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerExport2.Panel1
            // 
            this.splitContainerExport2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.splitContainerExport2.Panel1.Controls.Add(this.comboBox4);
            this.splitContainerExport2.Panel1.Controls.Add(this.comboBoxTaskSkill);
            this.splitContainerExport2.Panel1.Controls.Add(this.comboBoxExpertCity);
            this.splitContainerExport2.Panel1.Controls.Add(this.btnApplyExpert);
            this.splitContainerExport2.Panel1.Controls.Add(this.btnSreachExpert);
            this.splitContainerExport2.Panel1.Controls.Add(this.txtSreachExpert);
            this.splitContainerExport2.Panel1.Controls.Add(this.labClearFilterExpert);
            // 
            // splitContainerExport2.Panel2
            // 
            this.splitContainerExport2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainerExport2.Panel2.Controls.Add(this.dataGridViewExportShow);
            this.splitContainerExport2.Size = new System.Drawing.Size(990, 435);
            this.splitContainerExport2.SplitterDistance = 81;
            this.splitContainerExport2.TabIndex = 0;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(276, 23);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 37);
            this.comboBox4.TabIndex = 20;
            this.comboBox4.Text = "其他篩選";
            // 
            // comboBoxTaskSkill
            // 
            this.comboBoxTaskSkill.FormattingEnabled = true;
            this.comboBoxTaskSkill.Location = new System.Drawing.Point(145, 23);
            this.comboBoxTaskSkill.Name = "comboBoxTaskSkill";
            this.comboBoxTaskSkill.Size = new System.Drawing.Size(121, 37);
            this.comboBoxTaskSkill.TabIndex = 19;
            this.comboBoxTaskSkill.Text = "類別";
            this.comboBoxTaskSkill.SelectedIndexChanged += new System.EventHandler(this.comboBoxSkill_SelectedIndexChanged);
            // 
            // comboBoxExpertCity
            // 
            this.comboBoxExpertCity.FormattingEnabled = true;
            this.comboBoxExpertCity.Location = new System.Drawing.Point(14, 23);
            this.comboBoxExpertCity.Name = "comboBoxExpertCity";
            this.comboBoxExpertCity.Size = new System.Drawing.Size(121, 37);
            this.comboBoxExpertCity.TabIndex = 18;
            this.comboBoxExpertCity.Text = "地區";
            this.comboBoxExpertCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxExpertCity_SelectedIndexChanged);
            // 
            // btnApplyExpert
            // 
            this.btnApplyExpert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnApplyExpert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnApplyExpert.Location = new System.Drawing.Point(863, 24);
            this.btnApplyExpert.Name = "btnApplyExpert";
            this.btnApplyExpert.Size = new System.Drawing.Size(109, 34);
            this.btnApplyExpert.TabIndex = 16;
            this.btnApplyExpert.Text = "立即應徵";
            this.btnApplyExpert.UseVisualStyleBackColor = false;
            // 
            // btnSreachExpert
            // 
            this.btnSreachExpert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnSreachExpert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSreachExpert.Location = new System.Drawing.Point(756, 24);
            this.btnSreachExpert.Name = "btnSreachExpert";
            this.btnSreachExpert.Size = new System.Drawing.Size(97, 34);
            this.btnSreachExpert.TabIndex = 17;
            this.btnSreachExpert.Text = "搜尋";
            this.btnSreachExpert.UseVisualStyleBackColor = false;
            // 
            // txtSreachExpert
            // 
            this.txtSreachExpert.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSreachExpert.Location = new System.Drawing.Point(509, 22);
            this.txtSreachExpert.Name = "txtSreachExpert";
            this.txtSreachExpert.Size = new System.Drawing.Size(237, 38);
            this.txtSreachExpert.TabIndex = 15;
            this.txtSreachExpert.Text = "輸入關鍵字 ex.倒垃圾";
            // 
            // labClearFilterExpert
            // 
            this.labClearFilterExpert.AutoSize = true;
            this.labClearFilterExpert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labClearFilterExpert.Location = new System.Drawing.Point(407, 29);
            this.labClearFilterExpert.Name = "labClearFilterExpert";
            this.labClearFilterExpert.Size = new System.Drawing.Size(92, 25);
            this.labClearFilterExpert.TabIndex = 14;
            this.labClearFilterExpert.Text = "清除篩選";
            // 
            // dataGridViewExportShow
            // 
            this.dataGridViewExportShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExportShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExportShow.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewExportShow.Name = "dataGridViewExportShow";
            this.dataGridViewExportShow.RowHeadersWidth = 51;
            this.dataGridViewExportShow.RowTemplate.Height = 27;
            this.dataGridViewExportShow.Size = new System.Drawing.Size(988, 348);
            this.dataGridViewExportShow.TabIndex = 0;
            // 
            // dataGridViewExportShowTop
            // 
            this.dataGridViewExportShowTop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dataGridViewExportShowTop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExportShowTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExportShowTop.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewExportShowTop.Name = "dataGridViewExportShowTop";
            this.dataGridViewExportShowTop.RowHeadersWidth = 51;
            this.dataGridViewExportShowTop.RowTemplate.Height = 27;
            this.dataGridViewExportShowTop.Size = new System.Drawing.Size(988, 228);
            this.dataGridViewExportShowTop.TabIndex = 0;
            // 
            // FrmSreach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.tabControlSreach);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSreach";
            this.Text = "FrmSreach";
            this.tabControlSreach.ResumeLayout(false);
            this.tabPageTask.ResumeLayout(false);
            this.splitContainerTask.Panel1.ResumeLayout(false);
            this.splitContainerTask.Panel1.PerformLayout();
            this.splitContainerTask.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTask)).EndInit();
            this.splitContainerTask.ResumeLayout(false);
            this.splitContainerTask2.Panel1.ResumeLayout(false);
            this.splitContainerTask2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTask2)).EndInit();
            this.splitContainerTask2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTaskShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
            this.tabPageExpert.ResumeLayout(false);
            this.splitContainerExpert.Panel1.ResumeLayout(false);
            this.splitContainerExpert.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerExpert)).EndInit();
            this.splitContainerExpert.ResumeLayout(false);
            this.splitContainerExport2.Panel1.ResumeLayout(false);
            this.splitContainerExport2.Panel1.PerformLayout();
            this.splitContainerExport2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerExport2)).EndInit();
            this.splitContainerExport2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExportShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExportShowTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion        
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabControlSreach;
        private System.Windows.Forms.TabPage tabPageTask;
        private System.Windows.Forms.SplitContainer splitContainerTask;
        private System.Windows.Forms.TabPage tabPageExpert;
        private System.Windows.Forms.Button btnSreachTask;
        private System.Windows.Forms.TextBox txtSreachTask;
        private System.Windows.Forms.Label labClearFilterTask;
        private System.Windows.Forms.SplitContainer splitContainerTask2;
        private System.Windows.Forms.DataGridView dataGridViewTaskShow;
        private System.Windows.Forms.DataGridView dataGridViewTask;
        private System.Windows.Forms.Button btnApplyTask;
        private System.Windows.Forms.SplitContainer splitContainerExpert;
        private System.Windows.Forms.SplitContainer splitContainerExport2;
        private System.Windows.Forms.DataGridView dataGridViewExportShowTop;
        private System.Windows.Forms.Button btnApplyExpert;
        private System.Windows.Forms.Button btnSreachExpert;
        private System.Windows.Forms.TextBox txtSreachExpert;
        private System.Windows.Forms.Label labClearFilterExpert;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBoxTaskCity;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBoxTaskSkill;
        private System.Windows.Forms.ComboBox comboBoxExpertCity;
        private System.Windows.Forms.DataGridView dataGridViewExportShow;
    }
}