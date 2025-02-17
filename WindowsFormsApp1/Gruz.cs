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
    public partial class Gruz : Form
    {
        private string constring = "Data Source=perevozkinew.db;Version=3;";
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;
        private SQLiteCommandBuilder commandBuilder;
        public Gruz()
        {
            InitializeComponent();
        }

        private void commitbtn_Click(object sender, EventArgs e)
        {
            if (weighttb.Text != "" || arcticultb.Text != "")
            {
                try
                {
                    Convert.ToInt32(weighttb.Text);
                    Convert.ToInt32(arcticultb.Text);
                    using (SQLiteConnection connection = new SQLiteConnection(constring))
                    {
                        string zapros = "INSERT INTO Gruz ('weight','arcticul') VALUES ('" + weighttb.Text + "','" + arcticultb.Text + "');";
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
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
                
                
            else
            {
                MessageBox.Show("Проверьте поля ввода, возможно они остались пустыми");
            }
            
        }

        private void weighttb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                arcticultb.Focus();
            }
        }
    }
}
