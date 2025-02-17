namespace WindowsFormsApp1
{
    partial class Gruz
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
            this.arcticultb = new System.Windows.Forms.TextBox();
            this.weighttb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arcticultb
            // 
            this.arcticultb.Location = new System.Drawing.Point(92, 47);
            this.arcticultb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.arcticultb.Name = "arcticultb";
            this.arcticultb.Size = new System.Drawing.Size(76, 20);
            this.arcticultb.TabIndex = 18;
            // 
            // weighttb
            // 
            this.weighttb.Location = new System.Drawing.Point(92, 21);
            this.weighttb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weighttb.Name = "weighttb";
            this.weighttb.Size = new System.Drawing.Size(76, 20);
            this.weighttb.TabIndex = 17;
            this.weighttb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.weighttb_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Арктикул";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Вес";
            // 
            // commitbtn
            // 
            this.commitbtn.Location = new System.Drawing.Point(44, 80);
            this.commitbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commitbtn.Name = "commitbtn";
            this.commitbtn.Size = new System.Drawing.Size(77, 19);
            this.commitbtn.TabIndex = 11;
            this.commitbtn.Text = "Создать";
            this.commitbtn.UseVisualStyleBackColor = true;
            this.commitbtn.Click += new System.EventHandler(this.commitbtn_Click);
            // 
            // Gruz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 115);
            this.Controls.Add(this.arcticultb);
            this.Controls.Add(this.weighttb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commitbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Gruz";
            this.Text = "Gruz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox arcticultb;
        private System.Windows.Forms.TextBox weighttb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button commitbtn;
    }
}