namespace TimeEditor
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createTime = new System.Windows.Forms.DateTimePicker();
            this.writeTime = new System.Windows.Forms.DateTimePicker();
            this.accessTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.randomTime = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.createCheck = new System.Windows.Forms.CheckBox();
            this.writeCheck = new System.Windows.Forms.CheckBox();
            this.accessCheck = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chooseFileBtn.Location = new System.Drawing.Point(33, 74);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(132, 52);
            this.chooseFileBtn.TabIndex = 0;
            this.chooseFileBtn.Text = "選擇檔案";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            this.chooseFileBtn.Click += new System.EventHandler(this.chooseFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 42);
            this.label1.TabIndex = 998;
            this.label1.Text = "拖曳檔案\r\n或";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(190, 47);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox.Size = new System.Drawing.Size(425, 88);
            this.listBox.Sorted = true;
            this.listBox.TabIndex = 1;
            this.listBox.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            this.listBox.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.listBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(186, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 999;
            this.label2.Text = "未匯入檔案";
            // 
            // createTime
            // 
            this.createTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.createTime.Enabled = false;
            this.createTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createTime.Location = new System.Drawing.Point(90, 178);
            this.createTime.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.createTime.Name = "createTime";
            this.createTime.Size = new System.Drawing.Size(147, 22);
            this.createTime.TabIndex = 1000;
            this.createTime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // writeTime
            // 
            this.writeTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.writeTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.writeTime.Location = new System.Drawing.Point(90, 230);
            this.writeTime.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.writeTime.Name = "writeTime";
            this.writeTime.Size = new System.Drawing.Size(147, 22);
            this.writeTime.TabIndex = 1001;
            this.writeTime.ValueChanged += new System.EventHandler(this.writeTime_ValueChanged);
            // 
            // accessTime
            // 
            this.accessTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.accessTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.accessTime.Location = new System.Drawing.Point(90, 283);
            this.accessTime.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.accessTime.Name = "accessTime";
            this.accessTime.Size = new System.Drawing.Size(147, 22);
            this.accessTime.TabIndex = 1002;
            this.accessTime.ValueChanged += new System.EventHandler(this.accessTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1003;
            this.label3.Text = "建立日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1003;
            this.label4.Text = "修改日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1003;
            this.label5.Text = "存取日期";
            // 
            // randomTime
            // 
            this.randomTime.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.randomTime.Location = new System.Drawing.Point(333, 213);
            this.randomTime.Name = "randomTime";
            this.randomTime.Size = new System.Drawing.Size(130, 57);
            this.randomTime.TabIndex = 1004;
            this.randomTime.Text = "亂數時間";
            this.randomTime.UseVisualStyleBackColor = true;
            this.randomTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.save.Location = new System.Drawing.Point(485, 213);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(130, 57);
            this.save.TabIndex = 1005;
            this.save.Text = "修改並存檔";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button2_Click);
            // 
            // createCheck
            // 
            this.createCheck.AutoSize = true;
            this.createCheck.Checked = true;
            this.createCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.createCheck.Location = new System.Drawing.Point(243, 182);
            this.createCheck.Name = "createCheck";
            this.createCheck.Size = new System.Drawing.Size(60, 16);
            this.createCheck.TabIndex = 1006;
            this.createCheck.Text = "不變更";
            this.createCheck.UseVisualStyleBackColor = true;
            this.createCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // writeCheck
            // 
            this.writeCheck.AutoSize = true;
            this.writeCheck.Location = new System.Drawing.Point(243, 233);
            this.writeCheck.Name = "writeCheck";
            this.writeCheck.Size = new System.Drawing.Size(60, 16);
            this.writeCheck.TabIndex = 1006;
            this.writeCheck.Text = "不變更";
            this.writeCheck.UseVisualStyleBackColor = true;
            this.writeCheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // accessCheck
            // 
            this.accessCheck.AutoSize = true;
            this.accessCheck.Location = new System.Drawing.Point(243, 287);
            this.accessCheck.Name = "accessCheck";
            this.accessCheck.Size = new System.Drawing.Size(60, 16);
            this.accessCheck.TabIndex = 1006;
            this.accessCheck.Text = "不變更";
            this.accessCheck.UseVisualStyleBackColor = true;
            this.accessCheck.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(126, 261);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 1006;
            this.checkBox1.Text = "同步變更";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 1003;
            this.label6.Text = "分鐘";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numericUpDown1.Location = new System.Drawing.Point(345, 276);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 23);
            this.numericUpDown1.TabIndex = 1008;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 337);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.accessCheck);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.writeCheck);
            this.Controls.Add(this.createCheck);
            this.Controls.Add(this.save);
            this.Controls.Add(this.randomTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accessTime);
            this.Controls.Add(this.writeTime);
            this.Controls.Add(this.createTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseFileBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日期修改器";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker createTime;
        private System.Windows.Forms.DateTimePicker writeTime;
        private System.Windows.Forms.DateTimePicker accessTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button randomTime;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox createCheck;
        private System.Windows.Forms.CheckBox writeCheck;
        private System.Windows.Forms.CheckBox accessCheck;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

