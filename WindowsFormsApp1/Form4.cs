using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        private string constring = "Data Source=perevozkinew.db;Version=3;";

        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;
        private SQLiteCommandBuilder commandBuilder;
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(606, 441);
            zakaztb.Visible=true;
            searchbtn.Visible=true;
            forgetbtn.Visible=true;
            dataGridView1.Visible=true;  
            button1.Visible = false;
            menubtn.Location = new Point(33,19);
        }

        private void forgetbtn_Click(object sender, EventArgs e)
        {
            phonetb.Visible=true;
            searchbtn2.Visible=true;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(zakaztb.Text);
                using (SQLiteConnection connection = new SQLiteConnection(constring))
                {
                    string zapros = "SELECT Customer.last_name as [Фамилия],Zakaz.id as [Номер заказа],Zakaz.status as [Статус заказа], Gruz.arcticul as [Артикул], Gruz.weight as [Вес], Transfer.date_start as [Отправлено], Transfer.date_end as [Дата выдачи] from (((Zakaz INNER JOIN Transfer ON Zakaz.Transfer_id = Transfer.id) INNER JOIN Gruz ON Zakaz.Gruz_id = Gruz.id) INNER JOIN Customer ON Zakaz.Customer_id = Customer.id) WHERE Zakaz.id = " + zakaztb.Text + ";";
                    try
                    {
                        using (SQLiteDataAdapter command = new SQLiteDataAdapter(zapros, connection))
                        {
                            connection.Open();
                            using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(zapros, connection))
                            {
                                DataSet dataSet = new DataSet();
                                dataAdapter.Fill(dataSet);
                                dataGridView1.DataSource = dataSet.Tables[0];
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Ошибка! Вводить можно только числа..."+ex.Message);
            }
            
        }

        private void searchbtn2_Click(object sender, EventArgs e)
        {
            if (phonetb.Text != null)
            {
                if (Regex.IsMatch(phonetb.Text, @"^\+7\d{10}$"))
                {
                    using (SQLiteConnection connection = new SQLiteConnection(constring))
                    {
                        string zapros = "SELECT Customer.last_name as [Фамилия],Zakaz.id as [Номер заказа],Zakaz.status as [Статус заказа], Gruz.arcticul as [Артикул], Gruz.weight as [Вес], Transfer.date_start as [Отправлено], Transfer.date_end as [Дата выдачи] from (((Zakaz INNER JOIN Transfer ON Zakaz.Transfer_id = Transfer.id) INNER JOIN Gruz ON Zakaz.Gruz_id = Gruz.id) INNER JOIN Customer ON Zakaz.Customer_id = Customer.id) WHERE Customer.phone = '" + phonetb.Text + "';";
                        try
                        {
                            using (SQLiteDataAdapter command = new SQLiteDataAdapter(zapros, connection))
                            {
                                connection.Open();
                                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(zapros, connection))
                                {
                                    DataSet dataSet = new DataSet();
                                    dataAdapter.Fill(dataSet);
                                    dataGridView1.DataSource = dataSet.Tables[0];
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ошибка. Введите свой телефонный номер в формате +7XXXXXXXXXX");
                }
            }
            else
            {
                MessageBox.Show("Ошибка. Введите свой телефонный номер в формате +7XXXXXXXXXX");
            }

        }

       

        private void menubtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms[0].Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000; // интервал обновления в миллисекундах
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void zakaztb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
