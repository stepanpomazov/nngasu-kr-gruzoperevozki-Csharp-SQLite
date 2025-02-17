using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class status : Form
    {
        private string constring = "Data Source=perevozkinew.db;Version=3;";
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;
        private SQLiteCommandBuilder commandBuilder;
        public status()
        {
            InitializeComponent();
        }
        private void Load()
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                string zapros = "Select Zakaz.id, Zakaz.Customer_id, Customer.last_name,Customer.phone, Zakaz.status, Zakaz.Sender_id, Zakaz.Auto_id, Zakaz.Transfer_id, Zakaz.Gruz_id  from Zakaz inner join Customer ON Customer.id = Zakaz.Customer_id;";
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
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            comboBox1.Visible = true;
            button2.Visible = true;
            textBox2.Visible = true;
            this.Size = new Size(333, 341);
            Load();
            comboBox1.Items.Add("Фамилия покупателя");
            comboBox1.Items.Add("Номер телефона покупателя");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string data = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                textBox1.Text = data;
            }
            else
            {
                MessageBox.Show("Можно выбирать только id!");
            }
            
        }
        private void Load2(string par, string text)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                string zapros;
                
                zapros = "Select Zakaz.id, Zakaz.Customer_id, Customer.last_name,Customer.phone, Zakaz.status, Zakaz.Sender_id, Zakaz.Auto_id, Zakaz.Transfer_id, Zakaz.Gruz_id  from Zakaz inner join Customer ON Customer.id = Zakaz.Customer_id" + " where " + par + " = '" + text + "';";
                   
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string it = comboBox1.SelectedItem.ToString();
                switch (it)
                {
                    case "Фамилия покупателя":
                        Load2("last_name", textBox2.Text.ToString());

                        break;
                    case "Номер телефона покупателя":
                        Load2("phone", textBox2.Text.ToString());
                        break;
                }
            }
            
            catch(Exception ex)
                {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void commit_Click(object sender, EventArgs e)
        {
            try
            {
                string zapros;
                string it = comboBox2.SelectedItem.ToString();
                if (textBox1.Text != null)
                {
                    int id = Convert.ToInt32(textBox1.Text);
                    switch (it)
                    {
                        case "В доставке":
                           
                            using (SQLiteConnection connection = new SQLiteConnection(constring))
                            {
                                zapros = "UPDATE Zakaz set status = 0 where id = " + id + ";"; 
                                try
                                {
                                    using (SQLiteDataAdapter command = new SQLiteDataAdapter(zapros, connection))
                                    {
                                        connection.Open();
                                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(zapros, connection))
                                        {
                                            DataSet dataSet = new DataSet();
                                            dataAdapter.Fill(dataSet);

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
                            break;
                        case "Доставлен":
                            using (SQLiteConnection connection = new SQLiteConnection(constring))
                            {
                                zapros = "UPDATE Zakaz set status = 1 where id = " + id + ";"; try
                                {
                                    using (SQLiteDataAdapter command = new SQLiteDataAdapter(zapros, connection))
                                    {
                                        connection.Open();
                                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(zapros, connection))
                                        {
                                            DataSet dataSet = new DataSet();
                                            dataAdapter.Fill(dataSet);

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
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Для начала введите id заказа!");
                }
                    
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void autoupdbtn_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string datenow = now.ToString("yyyy-MM-dd");
            label3.Text = datenow;
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                
                string zapros = "UPDATE Zakaz set status = 1 WHERE Zakaz.id  IN (Select Zakaz.id FROM Zakaz INNER JOIN Transfer ON Zakaz.Transfer_id = Transfer.id WHERE Transfer.date_end <= '" + datenow +"');";
                try
                {
                    using (SQLiteDataAdapter command = new SQLiteDataAdapter(zapros, connection))
                    {
                        connection.Open();
                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(zapros, connection))
                        {
                            DataSet dataSet = new DataSet();
                            dataAdapter.Fill(dataSet);

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

        private void status_Load(object sender, EventArgs e)
        {

        }

        private void sbros_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                testtb.Visible = true;
                testbtn.Visible = true;

                string zapros = "UPDATE Zakaz set status = 0";
                try
                {
                    using (SQLiteDataAdapter command = new SQLiteDataAdapter(zapros, connection))
                    {
                        connection.Open();
                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(zapros, connection))
                        {
                            DataSet dataSet = new DataSet();
                            dataAdapter.Fill(dataSet);

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

        private void testbtn_Click(object sender, EventArgs e)
        {
            if (testtb.Text != "")
            {
                if (Regex.IsMatch(testtb.Text, @"^\d{4}-\d{2}-\d{2}$"))
                {
                    string datenow = testtb.Text;
                    using (SQLiteConnection connection = new SQLiteConnection(constring))
                    {

                        string zapros = "UPDATE Zakaz set status = 1 WHERE Zakaz.id  IN (Select Zakaz.id FROM Zakaz INNER JOIN Transfer ON Zakaz.Transfer_id = Transfer.id WHERE Transfer.date_end <= '" + datenow + "');";
                        try
                        {
                            using (SQLiteDataAdapter command = new SQLiteDataAdapter(zapros, connection))
                            {
                                connection.Open();
                                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(zapros, connection))
                                {
                                    DataSet dataSet = new DataSet();
                                    dataAdapter.Fill(dataSet);

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
                    MessageBox.Show("Нарушен формат ввода даты, нужно гггг-мм-дд");
                }
                    
            }
            else
            {
                MessageBox.Show("Вы оставили поле ввода пустым!");
            }
            

        }
    }
}
