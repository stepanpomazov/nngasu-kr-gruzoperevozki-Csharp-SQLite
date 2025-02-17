namespace WindowsFormsApp1
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.zakaztb = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.forgetbtn = new System.Windows.Forms.Button();
            this.searchbtn2 = new System.Windows.Forms.Button();
            this.phonetb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menubtn = new System.Windows.Forms.Button();
            this.Nt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отследить посылку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zakaztb
            // 
            this.zakaztb.Location = new System.Drawing.Point(214, 20);
            this.zakaztb.Margin = new System.Windows.Forms.Padding(2);
            this.zakaztb.Name = "zakaztb";
            this.zakaztb.Size = new System.Drawing.Size(199, 20);
            this.zakaztb.TabIndex = 1;
            this.zakaztb.Text = "Введите свой номер заказа";
            this.zakaztb.Visible = false;
            this.zakaztb.TextChanged += new System.EventHandler(this.zakaztb_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(416, 20);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(56, 19);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Поиск";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Visible = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // forgetbtn
            // 
            this.forgetbtn.Location = new System.Drawing.Point(214, 50);
            this.forgetbtn.Margin = new System.Windows.Forms.Padding(2);
            this.forgetbtn.Name = "forgetbtn";
            this.forgetbtn.Size = new System.Drawing.Size(198, 19);
            this.forgetbtn.TabIndex = 3;
            this.forgetbtn.Text = "Забыл номер заказа";
            this.forgetbtn.UseVisualStyleBackColor = true;
            this.forgetbtn.Visible = false;
            this.forgetbtn.Click += new System.EventHandler(this.forgetbtn_Click);
            // 
            // searchbtn2
            // 
            this.searchbtn2.Location = new System.Drawing.Point(416, 81);
            this.searchbtn2.Margin = new System.Windows.Forms.Padding(2);
            this.searchbtn2.Name = "searchbtn2";
            this.searchbtn2.Size = new System.Drawing.Size(56, 19);
            this.searchbtn2.TabIndex = 4;
            this.searchbtn2.Text = "Поиск";
            this.searchbtn2.UseVisualStyleBackColor = true;
            this.searchbtn2.Visible = false;
            this.searchbtn2.Click += new System.EventHandler(this.searchbtn2_Click);
            // 
            // phonetb
            // 
            this.phonetb.Location = new System.Drawing.Point(214, 83);
            this.phonetb.Margin = new System.Windows.Forms.Padding(2);
            this.phonetb.Name = "phonetb";
            this.phonetb.Size = new System.Drawing.Size(199, 20);
            this.phonetb.TabIndex = 5;
            this.phonetb.Text = "Введите номер телефона";
            this.phonetb.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(568, 237);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // menubtn
            // 
            this.menubtn.Location = new System.Drawing.Point(200, 20);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(154, 78);
            this.menubtn.TabIndex = 7;
            this.menubtn.Text = "Меню";
            this.menubtn.UseVisualStyleBackColor = true;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // Nt
            // 
            this.Nt.AutoSize = true;
            this.Nt.Location = new System.Drawing.Point(13, 122);
            this.Nt.Name = "Nt";
            this.Nt.Size = new System.Drawing.Size(90, 13);
            this.Nt.TabIndex = 8;
            this.Nt.Text = "Текущее время:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 145);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nt);
            this.Controls.Add(this.menubtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.phonetb);
            this.Controls.Add(this.searchbtn2);
            this.Controls.Add(this.forgetbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.zakaztb);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Отследите посылку";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox zakaztb;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button forgetbtn;
        private System.Windows.Forms.Button searchbtn2;
        private System.Windows.Forms.TextBox phonetb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button menubtn;
        private System.Windows.Forms.Label Nt;
        private System.Windows.Forms.Label label1;
    }
}