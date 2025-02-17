using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_laba7._0
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=C:\\Users\\nshoh\\source\\repos\\DB_laba7.0\\DB_laba7.0\\bin\\Debug\\plane.db;Version=3;";
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;

        public Form1()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);
            dataAdapter = new SQLiteDataAdapter();
            dataSet = new DataSet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData("Самолет");
            List<string> tableNames = GetTableNamesFromDatabase();
            comboBox1.Items.AddRange(tableNames.ToArray());
        }

        private List<string> GetTableNamesFromDatabase()
        {
            List<string> tableNames = new List<string>();
            try
            {
                connection.Open();
                DataTable schemaTable = connection.GetSchema("Tables");
                connection.Close();

                foreach (DataRow row in schemaTable.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    tableNames.Add(tableName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении названий таблиц: " + ex.Message);
            }
            return tableNames;
        }

        private void LoadData(string tableName)
        {
            try
            {
                string query = "SELECT * FROM " + tableName;
                dataAdapter.SelectCommand = new SQLiteCommand(query, connection);
                dataSet.Clear();
                dataAdapter.Fill(dataSet, tableName);
                dataGridView1.DataSource = dataSet.Tables[tableName];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            try
            {
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(dataAdapter);
                dataAdapter.Update(dataSet.Tables[dataGridView1.DataSource.ToString()]);
                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem.ToString();
            LoadData(selectedTable);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlQuery = textBox2.Text;
            try
            {
                connection.Open();
                if (sqlQuery.ToLower().Contains("select"))
                {
                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sqlQuery, connection))
                    {
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        dataGridView1.DataSource = dataSet.Tables[0];
                    }
                }
                else
                {
                    using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (sqlQuery.ToLower().Contains("delete"))
                        {
                            MessageBox.Show("Удалено: " + rowsAffected + " записей");
                        }
                        else
                        {
                            MessageBox.Show("Изменено: " + rowsAffected + " записей");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении SQL-запроса: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }

}




