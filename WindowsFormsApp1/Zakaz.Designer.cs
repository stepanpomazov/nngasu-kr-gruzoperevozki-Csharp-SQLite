namespace WindowsFormsApp1
{
    partial class Zakaz
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
            this.commitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customertb = new System.Windows.Forms.TextBox();
            this.sendertb = new System.Windows.Forms.TextBox();
            this.gruztb = new System.Windows.Forms.TextBox();
            this.transfertb = new System.Windows.Forms.TextBox();
            this.autotb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // commitbtn
            // 
            this.commitbtn.Location = new System.Drawing.Point(133, 335);
            this.commitbtn.Name = "commitbtn";
            this.commitbtn.Size = new System.Drawing.Size(103, 23);
            this.commitbtn.TabIndex = 0;
            this.commitbtn.Text = "Создать";
            this.commitbtn.UseVisualStyleBackColor = true;
            this.commitbtn.Click += new System.EventHandler(this.commitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Покупатель";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отправитель";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Товар";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Перевозка";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Авто";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // customertb
            // 
            this.customertb.Location = new System.Drawing.Point(136, 35);
            this.customertb.Name = "customertb";
            this.customertb.Size = new System.Drawing.Size(100, 22);
            this.customertb.TabIndex = 6;
            this.customertb.TextChanged += new System.EventHandler(this.customertb_TextChanged);
            // 
            // sendertb
            // 
            this.sendertb.Location = new System.Drawing.Point(136, 67);
            this.sendertb.Name = "sendertb";
            this.sendertb.Size = new System.Drawing.Size(100, 22);
            this.sendertb.TabIndex = 7;
            this.sendertb.TextChanged += new System.EventHandler(this.sendertb_TextChanged);
            // 
            // gruztb
            // 
            this.gruztb.Location = new System.Drawing.Point(136, 106);
            this.gruztb.Name = "gruztb";
            this.gruztb.Size = new System.Drawing.Size(100, 22);
            this.gruztb.TabIndex = 8;
            this.gruztb.TextChanged += new System.EventHandler(this.gruztb_TextChanged);
            // 
            // transfertb
            // 
            this.transfertb.Location = new System.Drawing.Point(136, 140);
            this.transfertb.Name = "transfertb";
            this.transfertb.Size = new System.Drawing.Size(100, 22);
            this.transfertb.TabIndex = 9;
            this.transfertb.TextChanged += new System.EventHandler(this.transfertb_TextChanged);
            // 
            // autotb
            // 
            this.autotb.Location = new System.Drawing.Point(136, 171);
            this.autotb.Name = "autotb";
            this.autotb.Size = new System.Drawing.Size(100, 22);
            this.autotb.TabIndex = 10;
            this.autotb.TextChanged += new System.EventHandler(this.autotb_TextChanged);
            // 
            // Zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 390);
            this.Controls.Add(this.autotb);
            this.Controls.Add(this.transfertb);
            this.Controls.Add(this.gruztb);
            this.Controls.Add(this.sendertb);
            this.Controls.Add(this.customertb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commitbtn);
            this.Name = "Zakaz";
            this.Text = "Zakaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button commitbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customertb;
        private System.Windows.Forms.TextBox sendertb;
        private System.Windows.Forms.TextBox gruztb;
        private System.Windows.Forms.TextBox transfertb;
        private System.Windows.Forms.TextBox autotb;
    }
}