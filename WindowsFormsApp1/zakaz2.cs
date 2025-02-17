using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class zakaz2 : Form
    {
        private string constring = "Data Source=perevozkinew.db;Version=3;";
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;
        private SQLiteCommandBuilder commandBuilder;
        public zakaz2()
        {
            InitializeComponent();
            
        }

        private void commitbtn_Click(object sender, EventArgs e)
        {
            if (customertb.Text != "" || sendertb.Text != "" || gruztb.Text != "" || transfertb.Text != "" || autotb.Text != "")
            {
                using (SQLiteConnection connection = new SQLiteConnection(constring))
                {
                    string zapros = "INSERT INTO Zakaz ('Customer_id','Sender_id','Gruz_id','Transfer_id','Auto_id') VALUES ('" + customertb.Text + "','" + sendertb.Text + "','" + gruztb.Text + "','" + transfertb.Text + "','" + autotb.Text + "');";
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
                MessageBox.Show("Некорректные данные!");
            }
            }
        private void Load(string name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                string zapros = "Select * from "+ name;
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
        private void Load2(string name,string par, string text, int flag)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                string zapros;
                if (flag == 0)
                {
                    zapros = "Select * from " + name + " where " + par + " = '" + text + "';";
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
        private void foundcustomerbtn_Click(object sender, EventArgs e)
        {
            flag = 1;
            this.Size = new Size(937, 445);
            dataGridView1.Visible = true;
            filter.Visible = true;
            filtertb.Visible = true;
            label6.Visible = true;
            commitfilterbtn.Visible = true;
            removebtn.Visible = true;
            filter.Items.Clear();

            Load("Customer");
            filter.Items.Add("Фамилия покупателя");
            filter.Items.Add("Номер телефона покупателя");

        }
        
       
        private void foundsenderbtn_Click(object sender, EventArgs e)
        {
            flag = 2;
            this.Size = new Size(937, 445);
            filter.Visible = true;
            dataGridView1.Visible = true;
            filtertb.Visible = true;
            label6.Visible = true;
            removebtn.Visible = true;
            filter.Items.Clear();

            Load("Sender");
            filter.Items.Add("Фамилия продавца");
            filter.Items.Add("Номер телефона продавца");

        }

        private void foundgruzbtn_Click(object sender, EventArgs e)
        {
            flag = 3;
            this.Size = new Size(937, 445);
            filter.Visible = true;
            dataGridView1.Visible = true;
            filtertb.Visible = true;
            label6.Visible = true;
            commitfilterbtn.Visible = true;
            removebtn.Visible = true;
            filter.Items.Clear();
            Load("Gruz");
            filter.Items.Add("Артикул");
        }

        private void foundtransferbtn_Click(object sender, EventArgs e)
        {
            if (customertb.Text == "" || sendertb.Text == "" || gruztb.Text == "")
            {
                MessageBox.Show("Для начала введите данные о Заказчике, Отправителе, Товаре, Автомобиле");
            }
            else
            {
                flag = 4;
                this.Size = new Size(937, 445);
                filter.Visible = true;
                dataGridView1.Visible = true;
                filtertb.Visible = true;
                label6.Visible = true;
                commitfilterbtn.Visible = true;
                removebtn.Visible = true;
                filter.Items.Clear();
                Load("Transfer");
                filter.Items.Add("Фамилия водителя авто");
                filter.Visible = false;
                label6.Visible = false;
                commitfilterbtn.Visible = false;
                filtertb.Visible = false;


                DateTime now = DateTime.Now;
                string datenow = now.ToString("yyyy-MM-dd");
                using (SQLiteConnection connection = new SQLiteConnection(constring))
                {
                    string zapros = "SELECT * FROM Transfer WHERE Transfer.date_start >= '" + datenow + "';";
                    try
                    {
                        connection.Open();
                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(zapros, connection))
                        {
                            DataSet dataSet = new DataSet();
                            dataAdapter.Fill(dataSet);
                            dataGridView1.DataSource = dataSet.Tables[0];
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
            
        }

        private void foundautobtn_Click(object sender, EventArgs e)
        {
            if (customertb.Text == "" || sendertb.Text == "" || gruztb.Text == "")
            {
                MessageBox.Show("Для начала введите данные о Заказчике, Отправителе и Товаре");
            }
            else
            {
                flag = 5;
                this.Size = new Size(937, 445);
                dataGridView1.Visible = true;
                filter.Visible = true;
                filtertb.Visible = true;
                label6.Visible = true;
                commitfilterbtn.Visible = true;
                removebtn.Visible = true;
                filter.Items.Clear();
                ///Load("Auto");
                filter.Items.Add("Фамилия водителя");
                filter.Items.Add("Госномер");
                filter.Items.Add("Наличие визы");

                ///string zapros = "Select Driver.Auto_id, Auto.number, Auto.max_load, Auto.model from (Auto inner join Driver on Auto.id = Driver.Auto_id) where Driver.Auto_id IN (SELECT Auto.id FROM (Auto LEFT JOIN Zakaz ON Auto.id = Zakaz.Auto_id LEFT JOIN Gruz ON Zakaz.Gruz_id = Gruz.id AND Zakaz.status = 0) GROUP BY Auto.id HAVING  COALESCE(SUM(Gruz.weight), 0) < Auto.max_load) ORDER BY Driver.Auto_id;";
                ///string zapros = "SELECT Driver.Auto_id, Auto.number, Auto.max_load, Auto.model FROM (Auto inner join Driver ON Auto.id = Driver.Auto_id) WHERE Auto.id NOT IN (SELECT Auto.id FROM Auto INNER JOIN Zakaz ON Auto.id = Zakaz.Auto_id INNER JOIN Gruz ON Zakaz.Gruz_id = Gruz.id WHERE Zakaz.status = 0 GROUP BY Auto.id, Auto.max_load HAVING SUM(Gruz.weight) > Auto.max_load);";
                int customerID = Convert.ToInt32(customertb.Text); 
                int senderID = Convert.ToInt32(sendertb.Text); 


                bool isCustomerCityAbroad = IsCityAbroadForCustomer(customerID, constring);
                bool isSenderCityAbroad = IsCityAbroadForSender(senderID, constring);
                using (SQLiteConnection connection = new SQLiteConnection(constring))
                {
                    string zapros = "";
                    connection.Open();
                    if (isCustomerCityAbroad == true || isSenderCityAbroad == true)
                    {
                        zapros = "SELECT Driver.Auto_id, Auto.number, Auto.max_load, Auto.model FROM (Auto inner join Driver ON Auto.id = Driver.Auto_id) WHERE Driver.zagran = 1 AND Auto.id NOT IN (SELECT Auto.id FROM Auto INNER JOIN Zakaz ON Auto.id = Zakaz.Auto_id INNER JOIN Gruz ON Zakaz.Gruz_id = Gruz.id WHERE Zakaz.status = 0 GROUP BY Auto.id, Auto.max_load HAVING SUM(Gruz.weight) > Auto.max_load);";
                    }
                    else
                    {
                        zapros = "SELECT Driver.Auto_id, Auto.number, Auto.max_load, Auto.model FROM (Auto inner join Driver ON Auto.id = Driver.Auto_id) WHERE Auto.id NOT IN (SELECT Auto.id FROM Auto INNER JOIN Zakaz ON Auto.id = Zakaz.Auto_id INNER JOIN Gruz ON Zakaz.Gruz_id = Gruz.id WHERE Zakaz.status = 0 GROUP BY Auto.id, Auto.max_load HAVING SUM(Gruz.weight) > Auto.max_load);";

                    }

                    //string zapros = @"
                    //SELECT Driver.Auto_id, Auto.number, Auto.max_load, Auto.model FROM(Auto inner join Driver ON Auto.id = Driver.Auto_id) WHERE Auto.id NOT IN
                    //(SELECT 
                    //    Auto.id 
                    //FROM 
                    //    Auto 
                    //INNER JOIN 
                    //    Zakaz ON Auto.id = Zakaz.Auto_id 
                    //INNER JOIN 
                    //    Gruz ON Zakaz.Gruz_id = Gruz.id 
                    //INNER JOIN 
                    //    Driver ON Auto.id = Driver.Auto_id 
                    //INNER JOIN 
                    //    Sender ON Sender_id = @SenderID
                    //INNER JOIN 
                    //    Customer ON Customer_id = @CustomerID
                    //INNER JOIN 
                    //    City AS SenderCity ON Sender.City_city = SenderCity.city 
                    //INNER JOIN 
                    //    City AS CustomerCity ON Customer.City_city = CustomerCity.city 
                    //WHERE 
                    //    Zakaz.status = 0
                    //    AND (
                    //        (SenderCity.contry != 'Россия' OR CustomerCity.contry != 'Россия' AND Driver.zagran = 0) 
                    //        OR (SenderCity.contry = 'Россия' AND CustomerCity.contry = 'Россия' AND Driver.zagran = 1)
                    //    )
                    //GROUP BY 
                    //    Auto.id, Auto.max_load 
                    //HAVING 
                    //    SUM(Gruz.weight) > Auto.max_load);";

                    using (SQLiteCommand command = new SQLiteCommand(zapros, connection))
                    {
                        try
                        { 

                            DataTable dataTable = new DataTable();

                            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                            {
                                adapter.Fill(dataTable);
                            }

                            dataGridView1.DataSource = dataTable;
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
            }
        }

        static bool IsCityAbroadForCustomer(int customerID, string connectionString)
        {
            string query = @"
            SELECT 
                COUNT(*)
            FROM 
                City
            INNER JOIN
                Customer ON City.city = Customer.City_city
            WHERE 
                Customer.id = @CustomerID
                AND City.contry != 'Россия';";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        static bool IsCityAbroadForSender(int senderID, string connectionString)
        {
            string query = @"
            SELECT 
                COUNT(*)
            FROM 
                City
            INNER JOIN
                Sender ON City.city = Sender.City_city
            WHERE 
                Sender.id = @SenderID
                AND City.contry != 'Россия';";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SenderID", senderID);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void commitfilterbtn_Click(object sender, EventArgs e)
        {
            if (filtertb.Text != null)
            {
                try
                {
                    string it = filter.SelectedItem.ToString();
                    switch (it)
                    {
                        case "Фамилия покупателя":
                            Load2("Customer", "last_name", filtertb.Text.ToString(),0);
                            break;
                        case "Номер телефона покупателя":
                            Load2("Customer", "phone", filtertb.Text.ToString(),0);
                            break;
                        case "Фамилия продавца":
                            Load2("Sender", "last_name", filtertb.Text.ToString(),0);
                            break;
                        case "Номер телефона продавца":
                            Load2("Sender", "phone", filtertb.Text.ToString(),0);
                            break;
                        case "Артикул":
                            Load2("Gruz", "arcticul", filtertb.Text.ToString(),0);
                            break;
                        case "Фамилия водителя":
                            Load2("Driver", "last_name", filtertb.Text.ToString(),0);
                            break;
                        case "Госномер":
                            Load2("Auto", "number", filtertb.Text.ToString(),0);
                            break;
                        case "Наличие визы":
                            Load2("Driver", "zagran", filtertb.Text,1);
                            break;
                       
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            flag = 0;
            this.Size = new Size(406, 296);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            filter.Items.Clear();
            filter.Text = "";
            filtertb.Text = "";
            filter.Visible = false;
            filtertb.Visible = false;
            label6.Visible = false;
            commitfilterbtn.Visible = false;
            removebtn.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string data = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                switch (flag)
                {
                    case 1:
                        customertb.Text = data;
                        sendertb.Focus();
                        break;
                    case 2:
                        sendertb.Text = data;
                        gruztb.Focus();
                        break;
                    case 3:
                        gruztb.Text = data;
                        transfertb.Focus();
                        break;
                    case 4:
                        transfertb.Text = data;
                        autotb.Focus();
                        break;
                    case 5:
                        autotb.Text = data;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Можно выбирать только столбец id!");
            }
            
        }

        private void customertb_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
