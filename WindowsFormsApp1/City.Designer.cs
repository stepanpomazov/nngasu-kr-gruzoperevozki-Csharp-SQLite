namespace WindowsFormsApp1
{
    partial class City
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
            this.countrytb = new System.Windows.Forms.TextBox();
            this.citytb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countrytb
            // 
            this.countrytb.Location = new System.Drawing.Point(89, 36);
            this.countrytb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countrytb.Name = "countrytb";
            this.countrytb.Size = new System.Drawing.Size(76, 20);
            this.countrytb.TabIndex = 23;
            // 
            // citytb
            // 
            this.citytb.Location = new System.Drawing.Point(89, 10);
            this.citytb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.citytb.Name = "citytb";
            this.citytb.Size = new System.Drawing.Size(76, 20);
            this.citytb.TabIndex = 22;
            this.citytb.TextChanged += new System.EventHandler(this.citytb_TextChanged);
            this.citytb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.citytb_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Страна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Город";
            // 
            // commitbtn
            // 
            this.commitbtn.Location = new System.Drawing.Point(40, 69);
            this.commitbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commitbtn.Name = "commitbtn";
            this.commitbtn.Size = new System.Drawing.Size(77, 19);
            this.commitbtn.TabIndex = 19;
            this.commitbtn.Text = "Создать";
            this.commitbtn.UseVisualStyleBackColor = true;
            this.commitbtn.Click += new System.EventHandler(this.commitbtn_Click);
            // 
            // City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 96);
            this.Controls.Add(this.countrytb);
            this.Controls.Add(this.citytb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commitbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "City";
            this.Text = "City";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox countrytb;
        private System.Windows.Forms.TextBox citytb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button commitbtn;
    }
}