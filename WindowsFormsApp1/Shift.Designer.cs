namespace WindowsFormsApp1
{
    partial class Shift
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
            this.datetb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commitbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.autocb = new System.Windows.Forms.ComboBox();
            this.drivercb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // datetb
            // 
            this.datetb.Location = new System.Drawing.Point(92, 17);
            this.datetb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetb.Name = "datetb";
            this.datetb.ReadOnly = true;
            this.datetb.Size = new System.Drawing.Size(76, 20);
            this.datetb.TabIndex = 22;
            this.datetb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datetb_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Авто_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Дата";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // commitbtn
            // 
            this.commitbtn.Location = new System.Drawing.Point(44, 104);
            this.commitbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commitbtn.Name = "commitbtn";
            this.commitbtn.Size = new System.Drawing.Size(77, 19);
            this.commitbtn.TabIndex = 19;
            this.commitbtn.Text = "Создать";
            this.commitbtn.UseVisualStyleBackColor = true;
            this.commitbtn.Click += new System.EventHandler(this.commitbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Водитель_id";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // autocb
            // 
            this.autocb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autocb.FormattingEnabled = true;
            this.autocb.Location = new System.Drawing.Point(92, 48);
            this.autocb.Name = "autocb";
            this.autocb.Size = new System.Drawing.Size(76, 21);
            this.autocb.TabIndex = 27;
            // 
            // drivercb
            // 
            this.drivercb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drivercb.FormattingEnabled = true;
            this.drivercb.Location = new System.Drawing.Point(92, 75);
            this.drivercb.Name = "drivercb";
            this.drivercb.Size = new System.Drawing.Size(76, 21);
            this.drivercb.TabIndex = 28;
            // 
            // Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 141);
            this.Controls.Add(this.drivercb);
            this.Controls.Add(this.autocb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commitbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Shift";
            this.Text = "Shift";
            this.Load += new System.EventHandler(this.Shift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox datetb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button commitbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox autocb;
        private System.Windows.Forms.ComboBox drivercb;
    }
}