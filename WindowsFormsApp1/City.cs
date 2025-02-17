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
    public partial class City : Form
    {
        private string constring = "Data Source=perevozkinew.db;Version=3;";
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;
        private SQLiteCommandBuilder commandBuilder;
        public City()
        {
            InitializeComponent();
        }

        private void commitbtn_Click(object sender, EventArgs e)
        {
            if (citytb.Text != "" || countrytb.Text != "")
            {
                using (SQLiteConnection connection = new SQLiteConnection(constring))
                {
                    string zapros = "INSERT INTO City ('city','contry') VALUES ('" + citytb.Text + "','" + countrytb.Text + "');";
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

        private void citytb_TextChanged(object sender, EventArgs e)
        {

        }

        private void citytb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                countrytb.Focus();
            }
        }
    }
}
