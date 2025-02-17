namespace WindowsFormsApp1
{
    partial class Sender
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
            this.label6 = new System.Windows.Forms.Label();
            this.phonetb = new System.Windows.Forms.TextBox();
            this.adresstb = new System.Windows.Forms.TextBox();
            this.patronomictb = new System.Windows.Forms.TextBox();
            this.firstnametb = new System.Windows.Forms.TextBox();
            this.lastnametb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commitbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Город";
            // 
            // phonetb
            // 
            this.phonetb.Location = new System.Drawing.Point(84, 120);
            this.phonetb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phonetb.Name = "phonetb";
            this.phonetb.Size = new System.Drawing.Size(76, 20);
            this.phonetb.TabIndex = 34;
            this.phonetb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phonetb_KeyDown);
            // 
            // adresstb
            // 
            this.adresstb.Location = new System.Drawing.Point(84, 95);
            this.adresstb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adresstb.Name = "adresstb";
            this.adresstb.Size = new System.Drawing.Size(76, 20);
            this.adresstb.TabIndex = 33;
            this.adresstb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adresstb_KeyDown);
            // 
            // patronomictb
            // 
            this.patronomictb.Location = new System.Drawing.Point(84, 67);
            this.patronomictb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patronomictb.Name = "patronomictb";
            this.patronomictb.Size = new System.Drawing.Size(76, 20);
            this.patronomictb.TabIndex = 32;
            this.patronomictb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.patronomictb_KeyDown);
            // 
            // firstnametb
            // 
            this.firstnametb.Location = new System.Drawing.Point(84, 36);
            this.firstnametb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstnametb.Name = "firstnametb";
            this.firstnametb.Size = new System.Drawing.Size(76, 20);
            this.firstnametb.TabIndex = 31;
            this.firstnametb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstnametb_KeyDown);
            // 
            // lastnametb
            // 
            this.lastnametb.Location = new System.Drawing.Point(84, 10);
            this.lastnametb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastnametb.Name = "lastnametb";
            this.lastnametb.Size = new System.Drawing.Size(76, 20);
            this.lastnametb.TabIndex = 30;
            this.lastnametb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastnametb_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Фамилия";
            // 
            // commitbtn
            // 
            this.commitbtn.Location = new System.Drawing.Point(37, 181);
            this.commitbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commitbtn.Name = "commitbtn";
            this.commitbtn.Size = new System.Drawing.Size(77, 19);
            this.commitbtn.TabIndex = 24;
            this.commitbtn.Text = "Создать";
            this.commitbtn.UseVisualStyleBackColor = true;
            this.commitbtn.Click += new System.EventHandler(this.commitbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 208);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phonetb);
            this.Controls.Add(this.adresstb);
            this.Controls.Add(this.patronomictb);
            this.Controls.Add(this.firstnametb);
            this.Controls.Add(this.lastnametb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commitbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sender";
            this.Text = "Sender";
            this.Load += new System.EventHandler(this.Sender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phonetb;
        private System.Windows.Forms.TextBox adresstb;
        private System.Windows.Forms.TextBox patronomictb;
        private System.Windows.Forms.TextBox firstnametb;
        private System.Windows.Forms.TextBox lastnametb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button commitbtn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}