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
    public partial class Zakaz : Form
    {
        private string constring = "Data Source=perevozkinew.db;Version=3;";
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;
        private SQLiteCommandBuilder commandBuilder;
        public Zakaz()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void commitbtn_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                string zapros = "INSERT INTO Zakaz ('Customer_id','Sender_id','Gruz_id','Transfer_id','Auto_id') VALUES ('" + customertb.Text+ "','"+sendertb.Text+"','"+gruztb.Text+"','"+transfertb.Text+ "','"+autotb.Text+"');";
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

        private void transfertb_TextChanged(object sender, EventArgs e)
        {

        }

        private void gruztb_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendertb_TextChanged(object sender, EventArgs e)
        {

        }

        private void customertb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void autotb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
