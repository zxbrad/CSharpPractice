namespace AccountWindowsApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textContent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textCurrency = new System.Windows.Forms.ComboBox();
            this.textDateInput = new System.Windows.Forms.DateTimePicker();
            this.textNote = new System.Windows.Forms.TextBox();
            this.textDateInput2 = new System.Windows.Forms.DateTimePicker();
            this.textExpend = new System.Windows.Forms.Label();
            this.textIncome = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.Label();
            this.textCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加账目";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.create_item);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "*账目名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "*类型：";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(56, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(360, 220);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类型";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "金额";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "时间";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "备注";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "*金额：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "货币：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "时间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "备注：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "内容：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 10;
            // 
            // textContent
            // 
            this.textContent.Location = new System.Drawing.Point(549, 273);
            this.textContent.Multiline = true;
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(202, 136);
            this.textContent.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "选择时间：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "导出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.importAccounts);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(42, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "账目查询";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(482, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 15;
            this.label11.Text = "账目添加";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "当月支出：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 17;
            this.label13.Text = "当月收入：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 18;
            this.label14.Text = "当月净入：";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(549, 58);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 21);
            this.textName.TabIndex = 19;
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(549, 140);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(100, 21);
            this.textAmount.TabIndex = 21;
            // 
            // textCurrency
            // 
            this.textCurrency.DisplayMember = "人民币";
            this.textCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textCurrency.FormattingEnabled = true;
            this.textCurrency.Items.AddRange(new object[] {
            "人民币",
            "美元",
            "欧元"});
            this.textCurrency.Location = new System.Drawing.Point(691, 140);
            this.textCurrency.Name = "textCurrency";
            this.textCurrency.Size = new System.Drawing.Size(60, 20);
            this.textCurrency.TabIndex = 22;
            // 
            // textDateInput
            // 
            this.textDateInput.Location = new System.Drawing.Point(549, 183);
            this.textDateInput.Name = "textDateInput";
            this.textDateInput.Size = new System.Drawing.Size(112, 21);
            this.textDateInput.TabIndex = 23;
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(549, 230);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(202, 21);
            this.textNote.TabIndex = 24;
            // 
            // textDateInput2
            // 
            this.textDateInput2.Location = new System.Drawing.Point(113, 55);
            this.textDateInput2.Name = "textDateInput2";
            this.textDateInput2.Size = new System.Drawing.Size(236, 21);
            this.textDateInput2.TabIndex = 25;
            this.textDateInput2.ValueChanged += new System.EventHandler(this.textDateInput2_ValueChanged);
            // 
            // textExpend
            // 
            this.textExpend.AutoSize = true;
            this.textExpend.Location = new System.Drawing.Point(115, 100);
            this.textExpend.Name = "textExpend";
            this.textExpend.Size = new System.Drawing.Size(0, 12);
            this.textExpend.TabIndex = 26;
            // 
            // textIncome
            // 
            this.textIncome.AutoSize = true;
            this.textIncome.Location = new System.Drawing.Point(115, 131);
            this.textIncome.Name = "textIncome";
            this.textIncome.Size = new System.Drawing.Size(0, 12);
            this.textIncome.TabIndex = 27;
            // 
            // textTotal
            // 
            this.textTotal.AutoSize = true;
            this.textTotal.Location = new System.Drawing.Point(115, 159);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(0, 12);
            this.textTotal.TabIndex = 28;
            // 
            // textCategory
            // 
            this.textCategory.DisplayMember = "人民币";
            this.textCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textCategory.FormattingEnabled = true;
            this.textCategory.Items.AddRange(new object[] {
            "收入",
            "支出"});
            this.textCategory.Location = new System.Drawing.Point(549, 103);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(100, 20);
            this.textCategory.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 484);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textIncome);
            this.Controls.Add(this.textExpend);
            this.Controls.Add(this.textDateInput2);
            this.Controls.Add(this.textNote);
            this.Controls.Add(this.textDateInput);
            this.Controls.Add(this.textCurrency);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textContent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textContent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.ComboBox textCurrency;
        private System.Windows.Forms.DateTimePicker textDateInput;
        private System.Windows.Forms.TextBox textNote;
        private System.Windows.Forms.DateTimePicker textDateInput2;
        private System.Windows.Forms.Label textExpend;
        private System.Windows.Forms.Label textIncome;
        private System.Windows.Forms.Label textTotal;
        private System.Windows.Forms.ComboBox textCategory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

