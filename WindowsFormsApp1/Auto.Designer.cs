namespace WindowsFormsApp1
{
    partial class Auto
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
            this.maxloadtb = new System.Windows.Forms.TextBox();
            this.modeltb = new System.Windows.Forms.TextBox();
            this.numbertb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maxloadtb
            // 
            this.maxloadtb.Location = new System.Drawing.Point(117, 76);
            this.maxloadtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maxloadtb.Name = "maxloadtb";
            this.maxloadtb.Size = new System.Drawing.Size(76, 20);
            this.maxloadtb.TabIndex = 19;
            // 
            // modeltb
            // 
            this.modeltb.Location = new System.Drawing.Point(117, 47);
            this.modeltb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modeltb.Name = "modeltb";
            this.modeltb.Size = new System.Drawing.Size(76, 20);
            this.modeltb.TabIndex = 18;
            this.modeltb.TextChanged += new System.EventHandler(this.modeltb_TextChanged);
            this.modeltb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modeltb_KeyDown);
            // 
            // numbertb
            // 
            this.numbertb.Location = new System.Drawing.Point(117, 19);
            this.numbertb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numbertb.Name = "numbertb";
            this.numbertb.Size = new System.Drawing.Size(76, 20);
            this.numbertb.TabIndex = 17;
            this.numbertb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numbertb_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Грузоподъёмность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Госномер";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // commitbtn
            // 
            this.commitbtn.Location = new System.Drawing.Point(61, 115);
            this.commitbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commitbtn.Name = "commitbtn";
            this.commitbtn.Size = new System.Drawing.Size(77, 19);
            this.commitbtn.TabIndex = 11;
            this.commitbtn.Text = "Создать";
            this.commitbtn.UseVisualStyleBackColor = true;
            this.commitbtn.Click += new System.EventHandler(this.commitbtn_Click);
            // 
            // Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 145);
            this.Controls.Add(this.maxloadtb);
            this.Controls.Add(this.modeltb);
            this.Controls.Add(this.numbertb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commitbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Auto";
            this.Text = "Auto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox maxloadtb;
        private System.Windows.Forms.TextBox modeltb;
        private System.Windows.Forms.TextBox numbertb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button commitbtn;
    }
}