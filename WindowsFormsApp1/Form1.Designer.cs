namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.connnectiontb = new System.Windows.Forms.TextBox();
            this.connectionbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.zakazbtn = new System.Windows.Forms.Button();
            this.gruzbtn = new System.Windows.Forms.Button();
            this.autobtn = new System.Windows.Forms.Button();
            this.customerbtn = new System.Windows.Forms.Button();
            this.senderbtn = new System.Windows.Forms.Button();
            this.transferbtn = new System.Windows.Forms.Button();
            this.driverbtn = new System.Windows.Forms.Button();
            this.citybtn = new System.Windows.Forms.Button();
            this.schedulebtn = new System.Windows.Forms.Button();
            this.statusbtn = new System.Windows.Forms.Button();
            this.menubtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // connnectiontb
            // 
            this.connnectiontb.Location = new System.Drawing.Point(9, 10);
            this.connnectiontb.Margin = new System.Windows.Forms.Padding(2);
            this.connnectiontb.Name = "connnectiontb";
            this.connnectiontb.Size = new System.Drawing.Size(722, 20);
            this.connnectiontb.TabIndex = 0;
            this.connnectiontb.Text = "Нажмите \"Присоединиться\" чтобы получить соединение с бд SQLite";
            this.connnectiontb.TextChanged += new System.EventHandler(this.connnectiontb_TextChanged);
            // 
            // connectionbtn
            // 
            this.connectionbtn.Location = new System.Drawing.Point(627, 34);
            this.connectionbtn.Margin = new System.Windows.Forms.Padding(2);
            this.connectionbtn.Name = "connectionbtn";
            this.connectionbtn.Size = new System.Drawing.Size(104, 19);
            this.connectionbtn.TabIndex = 1;
            this.connectionbtn.Text = "Присоединиться";
            this.connectionbtn.UseVisualStyleBackColor = true;
            this.connectionbtn.Click += new System.EventHandler(this.connectionbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(512, 407);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // openbtn
            // 
            this.openbtn.Location = new System.Drawing.Point(542, 89);
            this.openbtn.Margin = new System.Windows.Forms.Padding(2);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(56, 19);
            this.openbtn.TabIndex = 3;
            this.openbtn.Text = "open";
            this.openbtn.UseVisualStyleBackColor = true;
            this.openbtn.Visible = false;
            this.openbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer",
            "Sender",
            "City",
            "Gruz",
            "Transfer",
            "Auto",
            "Driver",
            "Zakaz"});
            this.comboBox1.Location = new System.Drawing.Point(604, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // zakazbtn
            // 
            this.zakazbtn.Location = new System.Drawing.Point(538, 129);
            this.zakazbtn.Margin = new System.Windows.Forms.Padding(2);
            this.zakazbtn.Name = "zakazbtn";
            this.zakazbtn.Size = new System.Drawing.Size(193, 19);
            this.zakazbtn.TabIndex = 9;
            this.zakazbtn.Text = "Внести заказ";
            this.zakazbtn.UseVisualStyleBackColor = true;
            this.zakazbtn.Visible = false;
            this.zakazbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gruzbtn
            // 
            this.gruzbtn.Location = new System.Drawing.Point(538, 153);
            this.gruzbtn.Margin = new System.Windows.Forms.Padding(2);
            this.gruzbtn.Name = "gruzbtn";
            this.gruzbtn.Size = new System.Drawing.Size(193, 19);
            this.gruzbtn.TabIndex = 10;
            this.gruzbtn.Text = "Зарегистрировать груз";
            this.gruzbtn.UseVisualStyleBackColor = true;
            this.gruzbtn.Visible = false;
            this.gruzbtn.Click += new System.EventHandler(this.gruzbtn_Click);
            // 
            // autobtn
            // 
            this.autobtn.Location = new System.Drawing.Point(538, 176);
            this.autobtn.Margin = new System.Windows.Forms.Padding(2);
            this.autobtn.Name = "autobtn";
            this.autobtn.Size = new System.Drawing.Size(193, 19);
            this.autobtn.TabIndex = 11;
            this.autobtn.Text = "Зарегистрировать авто";
            this.autobtn.UseVisualStyleBackColor = true;
            this.autobtn.Visible = false;
            this.autobtn.Click += new System.EventHandler(this.autobtn_Click);
            // 
            // customerbtn
            // 
            this.customerbtn.Location = new System.Drawing.Point(538, 200);
            this.customerbtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerbtn.Name = "customerbtn";
            this.customerbtn.Size = new System.Drawing.Size(193, 19);
            this.customerbtn.TabIndex = 12;
            this.customerbtn.Text = "Зарегистрировать покупателя";
            this.customerbtn.UseVisualStyleBackColor = true;
            this.customerbtn.Visible = false;
            this.customerbtn.Click += new System.EventHandler(this.customerbtn_Click);
            // 
            // senderbtn
            // 
            this.senderbtn.Location = new System.Drawing.Point(538, 224);
            this.senderbtn.Margin = new System.Windows.Forms.Padding(2);
            this.senderbtn.Name = "senderbtn";
            this.senderbtn.Size = new System.Drawing.Size(193, 19);
            this.senderbtn.TabIndex = 13;
            this.senderbtn.Text = "Зарегистрировать продавца";
            this.senderbtn.UseVisualStyleBackColor = true;
            this.senderbtn.Visible = false;
            this.senderbtn.Click += new System.EventHandler(this.senderbtn_Click);
            // 
            // transferbtn
            // 
            this.transferbtn.Location = new System.Drawing.Point(538, 249);
            this.transferbtn.Margin = new System.Windows.Forms.Padding(2);
            this.transferbtn.Name = "transferbtn";
            this.transferbtn.Size = new System.Drawing.Size(193, 19);
            this.transferbtn.TabIndex = 14;
            this.transferbtn.Text = "Зарегистрировать перевозку";
            this.transferbtn.UseVisualStyleBackColor = true;
            this.transferbtn.Visible = false;
            this.transferbtn.Click += new System.EventHandler(this.transferbtn_Click);
            // 
            // driverbtn
            // 
            this.driverbtn.Location = new System.Drawing.Point(536, 272);
            this.driverbtn.Margin = new System.Windows.Forms.Padding(2);
            this.driverbtn.Name = "driverbtn";
            this.driverbtn.Size = new System.Drawing.Size(193, 19);
            this.driverbtn.TabIndex = 16;
            this.driverbtn.Text = "Зарегистрировать водителя";
            this.driverbtn.UseVisualStyleBackColor = true;
            this.driverbtn.Visible = false;
            this.driverbtn.Click += new System.EventHandler(this.driverbtn_Click);
            // 
            // citybtn
            // 
            this.citybtn.Location = new System.Drawing.Point(536, 295);
            this.citybtn.Margin = new System.Windows.Forms.Padding(2);
            this.citybtn.Name = "citybtn";
            this.citybtn.Size = new System.Drawing.Size(193, 19);
            this.citybtn.TabIndex = 17;
            this.citybtn.Text = "Новый город";
            this.citybtn.UseVisualStyleBackColor = true;
            this.citybtn.Visible = false;
            this.citybtn.Click += new System.EventHandler(this.citytb_Click);
            // 
            // schedulebtn
            // 
            this.schedulebtn.Location = new System.Drawing.Point(536, 320);
            this.schedulebtn.Margin = new System.Windows.Forms.Padding(2);
            this.schedulebtn.Name = "schedulebtn";
            this.schedulebtn.Size = new System.Drawing.Size(193, 19);
            this.schedulebtn.TabIndex = 18;
            this.schedulebtn.Text = "Вывести расписание";
            this.schedulebtn.UseVisualStyleBackColor = true;
            this.schedulebtn.Visible = false;
            this.schedulebtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // statusbtn
            // 
            this.statusbtn.Location = new System.Drawing.Point(536, 345);
            this.statusbtn.Name = "statusbtn";
            this.statusbtn.Size = new System.Drawing.Size(193, 23);
            this.statusbtn.TabIndex = 19;
            this.statusbtn.Text = "Изменить статус заказа";
            this.statusbtn.UseVisualStyleBackColor = true;
            this.statusbtn.Visible = false;
            this.statusbtn.Click += new System.EventHandler(this.statusbtn_Click);
            // 
            // menubtn
            // 
            this.menubtn.Location = new System.Drawing.Point(536, 374);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(193, 68);
            this.menubtn.TabIndex = 20;
            this.menubtn.Text = "Вернуться в меню";
            this.menubtn.UseVisualStyleBackColor = true;
            this.menubtn.Visible = false;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Получить PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Отчеты:";
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "PDF расписание ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Получить PDF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024"});
            this.comboBox2.Location = new System.Drawing.Point(207, 502);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 21);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Заказы за";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "год";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Для удаления откройте нужную вам таблицу и используйте двойной клик по ID.";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "По пользователю";
            this.label5.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(246, 531);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(96, 21);
            this.comboBox3.TabIndex = 30;
            this.comboBox3.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(349, 528);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Получить PDF";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "По водителю";
            this.label6.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(470, 467);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(89, 21);
            this.comboBox4.TabIndex = 33;
            this.comboBox4.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(565, 465);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 34;
            this.button5.Text = "Получить PDF";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(565, 500);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 23);
            this.button6.TabIndex = 35;
            this.button6.Text = "Получить PDF";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(470, 500);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(89, 21);
            this.comboBox5.TabIndex = 36;
            this.comboBox5.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "По продавцу";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 559);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menubtn);
            this.Controls.Add(this.statusbtn);
            this.Controls.Add(this.schedulebtn);
            this.Controls.Add(this.citybtn);
            this.Controls.Add(this.driverbtn);
            this.Controls.Add(this.transferbtn);
            this.Controls.Add(this.senderbtn);
            this.Controls.Add(this.customerbtn);
            this.Controls.Add(this.autobtn);
            this.Controls.Add(this.gruzbtn);
            this.Controls.Add(this.zakazbtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.openbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.connectionbtn);
            this.Controls.Add(this.connnectiontb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox connnectiontb;
        private System.Windows.Forms.Button connectionbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button openbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button zakazbtn;
        private System.Windows.Forms.Button gruzbtn;
        private System.Windows.Forms.Button autobtn;
        private System.Windows.Forms.Button customerbtn;
        private System.Windows.Forms.Button senderbtn;
        private System.Windows.Forms.Button transferbtn;
        private System.Windows.Forms.Button driverbtn;
        private System.Windows.Forms.Button citybtn;
        private System.Windows.Forms.Button schedulebtn;
        private System.Windows.Forms.Button statusbtn;
        private System.Windows.Forms.Button menubtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label7;
    }
}

