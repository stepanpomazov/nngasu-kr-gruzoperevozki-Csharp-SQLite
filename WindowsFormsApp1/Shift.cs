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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Shift : Form
    {
        private string constring = "Data Source=perevozkinew.db;Version=3;";
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;
        private SQLiteCommandBuilder commandBuilder;
        public Shift()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void commitbtn_Click(object sender, EventArgs e)
        {
            if (datetb.Text != "" || autocb.Text != "" || drivercb.Text != "")
            {
                using (SQLiteConnection connection = new SQLiteConnection(constring))
                {
                    string zapros = "INSERT INTO Work_shift ('date','Auto_id','Driver_id') VALUES ('" + datetb.Text + "','" + autocb.Text + "','" + drivercb.Text + "');";
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

        private void datetb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                autocb.Focus();
            }
        }

        private void autoidtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                drivercb.Focus();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;

            // Формируем дату в формате гггг-мм-дд
            datetb.Text = selectedDate.ToString("yyyy-MM-dd");
        }

        private void Shift_Load(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=perevozkinew.db;Version=3;");
            connection.Open();

            // Запрос данных
            SQLiteCommand command = new SQLiteCommand("SELECT id FROM Auto;", connection);
            SQLiteDataReader reader = command.ExecuteReader();

            // Заполнение ComboBox

            while (reader.Read())
            {
                int autoid = reader.GetInt32(0);
                autocb.Items.Add(autoid);
            }
            SQLiteConnection connection1 = new SQLiteConnection("Data Source=perevozkinew.db;Version=3;");
            connection1.Open();
            SQLiteCommand command1 = new SQLiteCommand("SELECT id FROM Driver;", connection1);
            SQLiteDataReader reader1 = command1.ExecuteReader();

            // Заполнение ComboBox

            while (reader1.Read())
            {
                int driverid = reader1.GetInt32(0);
                drivercb.Items.Add(driverid);
            }
        }
    }
}
