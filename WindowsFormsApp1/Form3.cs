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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();

        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000; // интервал обновления в миллисекундах
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Студент 2го курса ИС-34 Помазов Степан. \r\n Вы проектируете информационную систему для транспортной компании,\r\nкоторая занимается перевозками грузов внутри страны и имеет контакты с\r\nзарубежными компаниями, осуществляющими перевозки за рубежом.\r\nОдной из основных задач, решаемых вашей системой является составление\r\nрасписания движения автотранспорта.\r\n");
        }
    }
}
