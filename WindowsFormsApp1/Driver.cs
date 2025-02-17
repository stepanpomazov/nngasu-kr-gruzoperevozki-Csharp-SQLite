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
    public partial class Driver : Form
    {
        private string constring = "Data Source=perevozkinew.db;Version=3;";
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;
        private SQLiteCommandBuilder commandBuilder;
        public Driver()
        {
            InitializeComponent();
        }

        private void commitbtn_Click(object sender, EventArgs e)
        {
            if (lastnametb.Text != "" || firstnametb.Text != "" || patronomictb.Text != "" || exptb.Text != "" || zagrancb.Text != "")
            {
                using (SQLiteConnection connection = new SQLiteConnection(constring))
                {
                    string zapros = "INSERT INTO Driver ('last_name','first_name','patronomic','exp','zagran','Auto_id') VALUES ('" + lastnametb.Text + "','" + firstnametb.Text + "','" + patronomictb.Text + "','" + exptb.Text + "','" + zagrancb.Text + "','" + textBox2.Text + "');";
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
                exptb.Focus();
            }
        }

        private void exptb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                zagrancb.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(737, 281);
            Load2("Auto", "", "", 9);
        }
       

        private void Load2(string name, string par, string text, int flag)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                string zapros;
                if (flag == 0)
                {
                    zapros = "Select * from " + name + " where " + par + " = '" + text + "' AND Auto.id NOT IN (SELECT Auto_id FROM Driver);";
                }
                else if (flag == 9)
                {
                    zapros = "Select id, Auto.number, Auto.max_load, Auto.model from " + name + " EXCEPT SELECT Auto_id,  Auto.number, Auto.max_load, Auto.model FROM Driver INNER JOIN Auto ON Auto.id = Driver.Auto_id;";
                }
                else
                {
                    zapros = "Select * from " + name + " where " + par + " = " + text + ";";
                }
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
        public int flag = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                try
                {
                    string it = comboBox2.SelectedItem.ToString();
                    switch (it)
                    {
                        case "Госномер":
                            Load2("Auto", "number", textBox1.Text.ToString(), 0);
                            break;
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string data = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                textBox2.Text = data;
            }
            else
            {
                MessageBox.Show("Можно выбирать только столбец id!");
            }

        }
    }
}
