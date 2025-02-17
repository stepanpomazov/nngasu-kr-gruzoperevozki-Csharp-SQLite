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
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }
        private string constring = "Data Source=perevozkinew.db;Version=3;";

        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;
        private SQLiteCommandBuilder commandBuilder;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void commitbtn_Click(object sender, EventArgs e)
        {
            if (numbertb.Text != "" || modeltb.Text != "" || maxloadtb.Text != "" )
            {
                if (Regex.IsMatch(numbertb.Text,@"[А,В,Е,К,М,Н,О,Р,С,Т,У,Х][0-9]{3}[А,В,Е,К,М,Н,О,Р,С,Т,У,Х]{2}[0-9]{2,3}") && numbertb.Text.Length >=8 && numbertb.Text.Length<=9)
                {
                    try
                    {
                        Convert.ToInt32(maxloadtb.Text);
                        using (SQLiteConnection connection = new SQLiteConnection(constring))
                        {
                            string zapros = "INSERT INTO Auto ('number','model','max_load') VALUES ('" + numbertb.Text + "','" + modeltb.Text + "','" + maxloadtb.Text + "');";
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
                    catch(Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Некорректный госномер");
                }
                
            }
            else
            {
                MessageBox.Show("Проверьте поля ввода, возможно они остались пустыми");
            }
            
        }

        private void numbertb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                modeltb.Focus();
            }
        }

        private void modeltb_TextChanged(object sender, EventArgs e)
        {

        }

        private void modeltb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maxloadtb.Focus();
            }
        }
    }
}
