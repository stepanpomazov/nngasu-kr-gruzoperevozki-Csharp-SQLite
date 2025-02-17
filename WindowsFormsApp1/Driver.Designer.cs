namespace WindowsFormsApp1
{
    partial class Driver
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
            this.exptb = new System.Windows.Forms.TextBox();
            this.patronomictb = new System.Windows.Forms.TextBox();
            this.firstnametb = new System.Windows.Forms.TextBox();
            this.lastnametb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commitbtn = new System.Windows.Forms.Button();
            this.zagrancb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exptb
            // 
            this.exptb.Location = new System.Drawing.Point(95, 98);
            this.exptb.Margin = new System.Windows.Forms.Padding(2);
            this.exptb.Name = "exptb";
            this.exptb.Size = new System.Drawing.Size(76, 20);
            this.exptb.TabIndex = 46;
            this.exptb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.exptb_KeyDown);
            // 
            // patronomictb
            // 
            this.patronomictb.Location = new System.Drawing.Point(95, 70);
            this.patronomictb.Margin = new System.Windows.Forms.Padding(2);
            this.patronomictb.Name = "patronomictb";
            this.patronomictb.Size = new System.Drawing.Size(76, 20);
            this.patronomictb.TabIndex = 45;
            this.patronomictb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.patronomictb_KeyDown);
            // 
            // firstnametb
            // 
            this.firstnametb.Location = new System.Drawing.Point(95, 38);
            this.firstnametb.Margin = new System.Windows.Forms.Padding(2);
            this.firstnametb.Name = "firstnametb";
            this.firstnametb.Size = new System.Drawing.Size(76, 20);
            this.firstnametb.TabIndex = 44;
            this.firstnametb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstnametb_KeyDown);
            // 
            // lastnametb
            // 
            this.lastnametb.Location = new System.Drawing.Point(95, 10);
            this.lastnametb.Margin = new System.Windows.Forms.Padding(2);
            this.lastnametb.Name = "lastnametb";
            this.lastnametb.Size = new System.Drawing.Size(76, 20);
            this.lastnametb.TabIndex = 43;
            this.lastnametb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastnametb_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Наличие визы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Опыт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Фамилия";
            // 
            // commitbtn
            // 
            this.commitbtn.Location = new System.Drawing.Point(44, 183);
            this.commitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.commitbtn.Name = "commitbtn";
            this.commitbtn.Size = new System.Drawing.Size(77, 19);
            this.commitbtn.TabIndex = 37;
            this.commitbtn.Text = "Создать";
            this.commitbtn.UseVisualStyleBackColor = true;
            this.commitbtn.Click += new System.EventHandler(this.commitbtn_Click);
            // 
            // zagrancb
            // 
            this.zagrancb.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1"});
            this.zagrancb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zagrancb.FormattingEnabled = true;
            this.zagrancb.Items.AddRange(new object[] {
            "0",
            "1"});
            this.zagrancb.Location = new System.Drawing.Point(95, 124);
            this.zagrancb.Name = "zagrancb";
            this.zagrancb.Size = new System.Drawing.Size(75, 21);
            this.zagrancb.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Auto_id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Определить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(399, 187);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Госномер"});
            this.comboBox2.Location = new System.Drawing.Point(291, 209);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 53;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 55;
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 242);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zagrancb);
            this.Controls.Add(this.exptb);
            this.Controls.Add(this.patronomictb);
            this.Controls.Add(this.firstnametb);
            this.Controls.Add(this.lastnametb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commitbtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Driver";
            this.Text = "Driver";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox exptb;
        private System.Windows.Forms.TextBox patronomictb;
        private System.Windows.Forms.TextBox firstnametb;
        private System.Windows.Forms.TextBox lastnametb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button commitbtn;
        private System.Windows.Forms.ComboBox zagrancb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
    }
}