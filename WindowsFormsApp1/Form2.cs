using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Form1 f1 = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="1234")
            {
                f1.Show();
                this.Close();
            }
            else {
                MessageBox.Show("Ошибка! Нужно ввести правильный пароль...");
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }
    }
}
