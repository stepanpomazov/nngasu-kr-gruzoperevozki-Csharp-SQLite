using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Transfer : Form
    {
        private string constring = "Data Source=perevozkinew.db;Version=3;";
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;
        private SQLiteCommandBuilder commandBuilder;
        public Transfer()
        {
            InitializeComponent();
        }

        private void commitbtn_Click(object sender, EventArgs e)
        {
            var dt1 = DateTime.Parse(datestarttb.Text);
            var dt2 = DateTime.Parse(dateendtb.Text);

            DateTime now = DateTime.Now.Date;
            
            if (datestarttb.Text != "" || dateendtb.Text != "") 
            {
                if(dt1 <= dt2)
                {
                    if (dt1 >= now)
                    {
                        using (SQLiteConnection connection = new SQLiteConnection(constring))
                        {
                            string zapros = "INSERT INTO Transfer ('date_start','date_end') VALUES ('" + datestarttb.Text + "','" + dateendtb.Text + "');";
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
                        MessageBox.Show("Дата начала должна быть сегодняшней, либо позже!");
                    }
                }
                else
                {
                    MessageBox.Show("Дата начала должна быть меньше даты окончания!");
                }
                
            }
            else
            {
                MessageBox.Show("Проверьте поля ввода, возможно они остались пустыми");
            }
            
        }

        private void datestarttb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateendtb.Focus();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;

            // Формируем дату в формате гггг-мм-дд
            datestarttb.Text = selectedDate.ToString("yyyy-MM-dd");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker2.Value;

            // Формируем дату в формате гггг-мм-дд
            dateendtb.Text = selectedDate.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
