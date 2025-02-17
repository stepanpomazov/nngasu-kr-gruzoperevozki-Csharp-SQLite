namespace WindowsFormsApp1
{
    partial class zakaz2
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
            this.autotb = new System.Windows.Forms.TextBox();
            this.transfertb = new System.Windows.Forms.TextBox();
            this.gruztb = new System.Windows.Forms.TextBox();
            this.sendertb = new System.Windows.Forms.TextBox();
            this.customertb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commitbtn = new System.Windows.Forms.Button();
            this.foundcustomerbtn = new System.Windows.Forms.Button();
            this.foundsenderbtn = new System.Windows.Forms.Button();
            this.foundgruzbtn = new System.Windows.Forms.Button();
            this.foundtransferbtn = new System.Windows.Forms.Button();
            this.foundautobtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filtertb = new System.Windows.Forms.TextBox();
            this.commitfilterbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // autotb
            // 
            this.autotb.Location = new System.Drawing.Point(101, 107);
            this.autotb.Margin = new System.Windows.Forms.Padding(2);
            this.autotb.Name = "autotb";
            this.autotb.ReadOnly = true;
            this.autotb.Size = new System.Drawing.Size(76, 20);
            this.autotb.TabIndex = 21;
            // 
            // transfertb
            // 
            this.transfertb.Location = new System.Drawing.Point(101, 141);
            this.transfertb.Margin = new System.Windows.Forms.Padding(2);
            this.transfertb.Name = "transfertb";
            this.transfertb.ReadOnly = true;
            this.transfertb.Size = new System.Drawing.Size(76, 20);
            this.transfertb.TabIndex = 20;
            // 
            // gruztb
            // 
            this.gruztb.Location = new System.Drawing.Point(101, 74);
            this.gruztb.Margin = new System.Windows.Forms.Padding(2);
            this.gruztb.Name = "gruztb";
            this.gruztb.ReadOnly = true;
            this.gruztb.Size = new System.Drawing.Size(76, 20);
            this.gruztb.TabIndex = 19;
            // 
            // sendertb
            // 
            this.sendertb.Location = new System.Drawing.Point(101, 45);
            this.sendertb.Margin = new System.Windows.Forms.Padding(2);
            this.sendertb.Name = "sendertb";
            this.sendertb.ReadOnly = true;
            this.sendertb.Size = new System.Drawing.Size(76, 20);
            this.sendertb.TabIndex = 18;
            // 
            // customertb
            // 
            this.customertb.Location = new System.Drawing.Point(101, 16);
            this.customertb.Margin = new System.Windows.Forms.Padding(2);
            this.customertb.Name = "customertb";
            this.customertb.ReadOnly = true;
            this.customertb.Size = new System.Drawing.Size(76, 20);
            this.customertb.TabIndex = 17;
            this.customertb.TextChanged += new System.EventHandler(this.customertb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Авто_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Перевозка_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Товар_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Отправитель_id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Покупатель_id";
            // 
            // commitbtn
            // 
            this.commitbtn.Location = new System.Drawing.Point(101, 170);
            this.commitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.commitbtn.Name = "commitbtn";
            this.commitbtn.Size = new System.Drawing.Size(77, 19);
            this.commitbtn.TabIndex = 11;
            this.commitbtn.Text = "Создать";
            this.commitbtn.UseVisualStyleBackColor = true;
            this.commitbtn.Click += new System.EventHandler(this.commitbtn_Click);
            // 
            // foundcustomerbtn
            // 
            this.foundcustomerbtn.Location = new System.Drawing.Point(205, 16);
            this.foundcustomerbtn.Margin = new System.Windows.Forms.Padding(2);
            this.foundcustomerbtn.Name = "foundcustomerbtn";
            this.foundcustomerbtn.Size = new System.Drawing.Size(80, 19);
            this.foundcustomerbtn.TabIndex = 22;
            this.foundcustomerbtn.Text = "Определить";
            this.foundcustomerbtn.UseVisualStyleBackColor = true;
            this.foundcustomerbtn.Click += new System.EventHandler(this.foundcustomerbtn_Click);
            // 
            // foundsenderbtn
            // 
            this.foundsenderbtn.Location = new System.Drawing.Point(205, 44);
            this.foundsenderbtn.Margin = new System.Windows.Forms.Padding(2);
            this.foundsenderbtn.Name = "foundsenderbtn";
            this.foundsenderbtn.Size = new System.Drawing.Size(80, 19);
            this.foundsenderbtn.TabIndex = 23;
            this.foundsenderbtn.Text = "Определить";
            this.foundsenderbtn.UseVisualStyleBackColor = true;
            this.foundsenderbtn.Click += new System.EventHandler(this.foundsenderbtn_Click);
            // 
            // foundgruzbtn
            // 
            this.foundgruzbtn.Location = new System.Drawing.Point(205, 73);
            this.foundgruzbtn.Margin = new System.Windows.Forms.Padding(2);
            this.foundgruzbtn.Name = "foundgruzbtn";
            this.foundgruzbtn.Size = new System.Drawing.Size(80, 19);
            this.foundgruzbtn.TabIndex = 24;
            this.foundgruzbtn.Text = "Определить";
            this.foundgruzbtn.UseVisualStyleBackColor = true;
            this.foundgruzbtn.Click += new System.EventHandler(this.foundgruzbtn_Click);
            // 
            // foundtransferbtn
            // 
            this.foundtransferbtn.Location = new System.Drawing.Point(205, 140);
            this.foundtransferbtn.Margin = new System.Windows.Forms.Padding(2);
            this.foundtransferbtn.Name = "foundtransferbtn";
            this.foundtransferbtn.Size = new System.Drawing.Size(80, 19);
            this.foundtransferbtn.TabIndex = 25;
            this.foundtransferbtn.Text = "Определить";
            this.foundtransferbtn.UseVisualStyleBackColor = true;
            this.foundtransferbtn.Click += new System.EventHandler(this.foundtransferbtn_Click);
            // 
            // foundautobtn
            // 
            this.foundautobtn.Location = new System.Drawing.Point(205, 106);
            this.foundautobtn.Margin = new System.Windows.Forms.Padding(2);
            this.foundautobtn.Name = "foundautobtn";
            this.foundautobtn.Size = new System.Drawing.Size(80, 19);
            this.foundautobtn.TabIndex = 26;
            this.foundautobtn.Text = "Определить";
            this.foundautobtn.UseVisualStyleBackColor = true;
            this.foundautobtn.Click += new System.EventHandler(this.foundautobtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(362, 265);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // filter
            // 
            this.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter.FormattingEnabled = true;
            this.filter.Location = new System.Drawing.Point(358, 297);
            this.filter.Margin = new System.Windows.Forms.Padding(2);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(92, 21);
            this.filter.TabIndex = 28;
            this.filter.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Фильтр";
            this.label6.Visible = false;
            // 
            // filtertb
            // 
            this.filtertb.Location = new System.Drawing.Point(454, 297);
            this.filtertb.Margin = new System.Windows.Forms.Padding(2);
            this.filtertb.Name = "filtertb";
            this.filtertb.Size = new System.Drawing.Size(76, 20);
            this.filtertb.TabIndex = 30;
            this.filtertb.Visible = false;
            // 
            // commitfilterbtn
            // 
            this.commitfilterbtn.Location = new System.Drawing.Point(534, 299);
            this.commitfilterbtn.Margin = new System.Windows.Forms.Padding(2);
            this.commitfilterbtn.Name = "commitfilterbtn";
            this.commitfilterbtn.Size = new System.Drawing.Size(81, 19);
            this.commitfilterbtn.TabIndex = 31;
            this.commitfilterbtn.Text = "Применить";
            this.commitfilterbtn.UseVisualStyleBackColor = true;
            this.commitfilterbtn.Visible = false;
            this.commitfilterbtn.Click += new System.EventHandler(this.commitfilterbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(619, 297);
            this.removebtn.Margin = new System.Windows.Forms.Padding(2);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(56, 19);
            this.removebtn.TabIndex = 32;
            this.removebtn.Text = "Сброс";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Visible = false;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // zakaz2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 210);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.commitfilterbtn);
            this.Controls.Add(this.filtertb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.foundautobtn);
            this.Controls.Add(this.foundtransferbtn);
            this.Controls.Add(this.foundgruzbtn);
            this.Controls.Add(this.foundsenderbtn);
            this.Controls.Add(this.foundcustomerbtn);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "zakaz2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox autotb;
        private System.Windows.Forms.TextBox transfertb;
        private System.Windows.Forms.TextBox gruztb;
        private System.Windows.Forms.TextBox sendertb;
        private System.Windows.Forms.TextBox customertb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button commitbtn;
        private System.Windows.Forms.Button foundcustomerbtn;
        private System.Windows.Forms.Button foundsenderbtn;
        private System.Windows.Forms.Button foundgruzbtn;
        private System.Windows.Forms.Button foundtransferbtn;
        private System.Windows.Forms.Button foundautobtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filtertb;
        private System.Windows.Forms.Button commitfilterbtn;
        private System.Windows.Forms.Button removebtn;
    }
}