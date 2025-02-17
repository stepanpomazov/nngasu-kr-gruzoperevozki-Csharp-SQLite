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

namespace WindowsFormsApp1
{
    public partial class Customer : Form
    {
        private string constring = "Data Source=perevozkinew.db;Version=3;";
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;
        private SQLiteCommandBuilder commandBuilder;
        public Customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void commitbtn_Click(object sender, EventArgs e)
        {
            if (lastnametb.Text != "" || firstnametb.Text != "" || patronomictb.Text != "" || adresstb.Text != "" || phonetb.Text != "" || comboBox1.Text != "")
            {
                if (Regex.IsMatch(phonetb.Text, @"^\+7\d{10}$"))
                {
                    using (SQLiteConnection connection = new SQLiteConnection(constring))
                    {
                        string zapros = "INSERT INTO Customer ('last_name','first_name','patronomic','adress','phone','City_city') VALUES ('" + lastnametb.Text + "','" + firstnametb.Text + "','" + patronomictb.Text + "','" + adresstb.Text + "','" + phonetb.Text + "','" + comboBox1.Text + "');";
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
                    MessageBox.Show("Ошибка. Введите свой телефонный номер в формате +7XXXXXXXXXX");
                }
            }
            else
            {
                MessageBox.Show("Проверьте поля ввода, возможно они остались пустыми");
            }
            
        }

        private void lastnametb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                firstnametb.Focus();
            }
        }

        private void firstnametb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                patronomictb.Focus();
            }
        }

        private void patronomictb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adresstb.Focus();
            }
        }

        private void adresstb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                phonetb.Focus();
            }
        }

        private void phonetb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               comboBox1.Focus();
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=perevozkinew.db;Version=3;");
            connection.Open();

            // Запрос данных
            SQLiteCommand command = new SQLiteCommand("SELECT city FROM City;", connection);
            SQLiteDataReader reader = command.ExecuteReader();

            // Заполнение ComboBox
            
            while (reader.Read())
            {
                string city = reader.GetString(0);
                comboBox1.Items.Add(city);
            }
        }
    }
}
