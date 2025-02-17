using System;

using System.Data;
using System.Data.OleDb;

using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Reflection.Emit;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.IO;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private string constring = "Data Source=perevozkinew.db;Version=3;";
        private SQLiteConnection connection;
        private SQLiteDataAdapter dataAdapter;
        private DataSet dataSet;
        public Form1()
        {
            InitializeComponent();

        }


        private void Load(string name)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(constring))
                {
                    string zapros = "select * from " + name;
                    dataAdapter.SelectCommand = new SQLiteCommand(zapros, connection);
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, name);
                    dataGridView1.DataSource = dataSet.Tables[name];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно загрузить БД" + ex.Message);
            }
        }
        private void connectionbtn_Click(object sender, EventArgs e)
        {
            if (connectionbtn.Text == "Присоединиться")
            {
                label4.Visible = true;
                menubtn.Visible = true;
                statusbtn.Visible = true;
                comboBox1.Visible = true;
                openbtn.Visible = true;
                zakazbtn.Visible = true;
                dataGridView1.Visible = true;
                gruzbtn.Visible = true;
                senderbtn.Visible = true;
                customerbtn.Visible = true;
                autobtn.Visible = true;
                driverbtn.Visible = true;
                transferbtn.Visible = true;
                citybtn.Visible = true;
                schedulebtn.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                Timer timer = new Timer();
                timer.Tick += new EventHandler(timer_Tick);
                timer.Interval = 1000; // интервал обновления в миллисекундах
                timer.Start();
                this.Text = "Подключено!";
                connectionbtn.Text = "Отсоединиться";
                connection = new SQLiteConnection(constring);
                dataAdapter = new SQLiteDataAdapter();
                dataSet = new DataSet();
                connnectiontb.Text = constring;

                SQLiteConnection connection1 = new SQLiteConnection("Data Source=perevozkinew.db;Version=3;");
                connection1.Open();
                SQLiteCommand command1 = new SQLiteCommand("SELECT last_name FROM Customer;", connection1);
                SQLiteDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    string id = reader1.GetString(0);
                    comboBox3.Items.Add(id);
                }

                SQLiteConnection connection2 = new SQLiteConnection("Data Source=perevozkinew.db;Version=3;");
                connection2.Open();
                SQLiteCommand command2 = new SQLiteCommand("SELECT last_name FROM Driver;", connection2);
                SQLiteDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    string id2 = reader2.GetString(0);
                    comboBox4.Items.Add(id2);
                }
                SQLiteConnection connection3 = new SQLiteConnection("Data Source=perevozkinew.db;Version=3;");
                connection3.Open();
                SQLiteCommand command3 = new SQLiteCommand("SELECT last_name FROM Sender;", connection3);
                SQLiteDataReader reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    string id3 = reader3.GetString(0);
                    comboBox5.Items.Add(id3);
                }
            }
            else
            {
                menubtn_Click(sender, e);
            }

        }

        private void connnectiontb_TextChanged(object sender, EventArgs e)
        {

        }
        private void Load2(string name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                string zapros = "select * from Zakaz;";

                switch (name)
                {
                    case "Auto":
                        zapros = "select id, number as [Госномер], max_load as [Грузоподъёмность], model as [Модель] from Auto;";
                        break;
                    case "Customer":
                        zapros = "select id, last_name as [Фамилия], first_name as [Имя], patronomic as [Отчество], adress as [Адрес], phone as [Номер телефона], City_city as [Город] from Customer;";
                        break;
                    case "Sender":
                        zapros = "select id, last_name as [Фамилия], first_name as [Имя], patronomic as [Отчество], adress as [Адрес], phone as [Номер телефона], City_city as [Город] from Sender;";
                        break;
                    case "City":
                        zapros = "select city as [Город], contry as [Страна] from City;";
                        break;
                    case "Gruz":
                        zapros = "select id, weight as [Масса], arcticul as [Артикул] from Gruz;";
                        break;
                    case "Transfer":
                        zapros = "select id, date_start as [Дата отправки], date_end as [Дата приезда] from Transfer;";
                        break;
                    case "Driver":
                        zapros = "select Driver.id as [id], Driver.last_name as [Фамилия], Driver.first_name as [Имя], Driver.patronomic as [Отчество], Driver.exp as [Стаж], Driver.zagran as [Наличие визы (0/1)], Driver.Auto_id as [Auto_id], Auto.number as [Госномер] from Driver inner join Auto on Auto.id = Driver.Auto_id;";
                        break;
                    case "Zakaz":
                        zapros = "select Zakaz.id, Customer.last_name as [Заказчик], Gruz.weight as [Масса],Sender.last_name as [Отправитель], Driver.last_name as [Водитель], Auto.number as [Госномер], Transfer.date_start as [Дата отправки], Transfer.date_end as [Дата доставки], Zakaz.status as [Статус заказа] from (((((Zakaz inner join Customer on Zakaz.Customer_id = Customer.id) inner join Sender on Zakaz.Sender_id = Sender.id)  inner join Auto on Zakaz.Auto_id = Auto.id) inner join Driver on Driver.Auto_id = Auto.id) inner join Transfer on Transfer.id = Zakaz.Transfer_id) inner join Gruz on Gruz.id = Zakaz.Gruz_id;";
                        break;

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
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {

                string table = comboBox1.SelectedItem.ToString();
                Load2(table);
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }

        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            zakaz2 f5 = new zakaz2();
            f5.Show();
        }

        private void gruzbtn_Click(object sender, EventArgs e)
        {

            Gruz f6 = new Gruz();
            f6.Show();
        }

        private void autobtn_Click(object sender, EventArgs e)
        {
            Auto f7 = new Auto();
            f7.Show();
        }

        private void transferbtn_Click(object sender, EventArgs e)
        {
            Transfer f8 = new Transfer();
            f8.Show();
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            Customer f9 = new Customer();
            f9.Show();
        }

        private void senderbtn_Click(object sender, EventArgs e)
        {
            Sender f10 = new Sender();
            f10.Show();
        }

        private void driverbtn_Click(object sender, EventArgs e)
        {
            Driver f11 = new Driver();
            f11.Show();
        }

        private void shiftbtn_Click(object sender, EventArgs e)
        {
            Shift f12 = new Shift();
            f12.Show();
        }

        private void citytb_Click(object sender, EventArgs e)
        {
            City f13 = new City();
            f13.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                string zapros = "SELECT DISTINCT Transfer.date_start as [Отправлено], Transfer.date_end as [Дата доставки], Zakaz.id as [Номер заказа], Auto.number as [Госномер], Auto.model as [Автомобиль], Driver.last_name as [Фамилия водителя], City.city as [Город], Customer.adress as [Адрес], Zakaz.status as [Статус] FROM (((((Zakaz INNER JOIN Transfer ON Transfer.id = Zakaz.Transfer_id) INNER JOIN Auto ON Zakaz.Auto_id = Auto.id) INNER JOIN Driver ON Driver.Auto_id = Auto.id) INNER JOIN Customer ON Customer.id = Zakaz.Customer_id) INNER JOIN City ON Customer.City_city = City.city) Where Zakaz.status = 0 ORDER BY Transfer.date_start, Transfer.date_end, Auto.number;";
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

        private void statusbtn_Click(object sender, EventArgs e)
        {
            status s = new status();
            s.Show();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {


            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Form3")
                    Application.OpenForms[i].Close();
            }
            Application.OpenForms[0].Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows[0].IsNewRow)
            {
                MessageBox.Show("Нет данных для создания отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");

                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);

                Document document = new Document();
                string filePath = "report_"+comboBox1.Text+".pdf";
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();
                document.Add(new Phrase("Отчёт по таблице " + comboBox1.Text, font));
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                    table.AddCell(cell);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString(), font));
                            table.AddCell(pdfCell);
                        }
                    }
                }

                document.Add(table);
                document.Close();

                MessageBox.Show("Отчет создан: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                string zapros = "SELECT DISTINCT Transfer.date_start as [Отправлено], Transfer.date_end as [Дата доставки], Zakaz.id as [Номер заказа], Auto.number as [Госномер], Auto.model as [Автомобиль], Driver.last_name as [Фамилия водителя], City.city as [Город], Customer.adress as [Адрес], Zakaz.status as [Статус] FROM ((((Zakaz INNER JOIN Transfer ON Transfer.id = Zakaz.Transfer_id) INNER JOIN Auto ON Zakaz.Auto_id = Auto.id) INNER JOIN Driver ON Driver.Auto_id = Auto.id) INNER JOIN Customer ON Customer.id = Zakaz.Customer_id) INNER JOIN City ON Customer.City_city = City.city Where Zakaz.status = 0 ORDER BY Transfer.date_start, Transfer.date_end, Auto.number;";
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
            if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows[0].IsNewRow)
            {
                MessageBox.Show("Нет данных для создания отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");

                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);

                Document document = new Document();
                string filePath = "report_raspisanie.pdf";
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();
                document.Add(new Phrase("Расписание заказов",font));
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                    table.AddCell(cell);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString(), font));
                            table.AddCell(pdfCell);
                        }
                    }
                }

                document.Add(table);
                document.Close();

                MessageBox.Show("Отчет создан: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                try
                {
                    string zapros = "SELECT * FROM Zakaz;";
                    string y = "2022-2024";
                    switch (comboBox2.Text)
                    {
                        case "2022":
                            y = "2022";
                            zapros = "SELECT Zakaz.id as 'id', Sender.last_name as 'ФИО отправителя', Customer.last_name as 'ФИО Получателя', Transfer.date_start as 'Дата отправления', Transfer.date_end as 'Дата получения', Zakaz.status as 'Статус' FROM (((Zakaz inner join Transfer on Transfer.id = Zakaz.Transfer_id) inner join Sender on Zakaz.Sender_id = Sender.id) inner join Customer on Customer.id = Zakaz.Customer_id) Where Transfer.date_start >= '2022-01-01' and Transfer.date_start<='2022-12-31';";
                            break;
                        case "2023":
                            y = "2023";
                            zapros = "SELECT Zakaz.id as 'id', Sender.last_name as 'ФИО отправителя', Customer.last_name as 'ФИО Получателя', Transfer.date_start as 'Дата отправления', Transfer.date_end as 'Дата получения', Zakaz.status as 'Статус' FROM (((Zakaz inner join Transfer on Transfer.id = Zakaz.Transfer_id) inner join Sender on Zakaz.Sender_id = Sender.id) inner join Customer on Customer.id = Zakaz.Customer_id) Where Transfer.date_start >= '2023-01-01' and Transfer.date_start<='2023-12-31';";
                            break;
                        case "2024":
                            y = "2024";
                            zapros = "SELECT Zakaz.id as 'id', Sender.last_name as 'ФИО отправителя', Customer.last_name as 'ФИО Получателя', Transfer.date_start as 'Дата отправления', Transfer.date_end as 'Дата получения', Zakaz.status as 'Статус' FROM (((Zakaz inner join Transfer on Transfer.id = Zakaz.Transfer_id) inner join Sender on Zakaz.Sender_id = Sender.id) inner join Customer on Customer.id = Zakaz.Customer_id) Where Transfer.date_start >= '2024-01-01' and Transfer.date_start<='2024-12-31';";
                            break;
                        case null:
                            MessageBox.Show("Нет данных для создания отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
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
                    if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows[0].IsNewRow)
                    {
                        MessageBox.Show("Нет данных для создания отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");

                        BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                        iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);

                        Document document = new Document();
                        string filePath = "report_"+y+".pdf";
                        PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                        document.Open();
                        document.Add(new Phrase("Отчёт за "+y+" год", font));
                        PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                            table.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString(), font));
                                    table.AddCell(pdfCell);
                                }
                            }
                        }

                        document.Add(table);
                        document.Close();

                        MessageBox.Show("Отчет создан: " + filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при создании отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

       
  
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string data = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (MessageBox.Show("Удалить данную строку из таблицы?", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    string zapros = "DELETE FROM " + comboBox1.Text + " WHERE id = " + data + ";";
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
                        Load2(comboBox1.Text.ToString());
                    }
                    catch (Exception ex)
                    {
                        Load2(comboBox1.Text.ToString());
                        
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("Можно выбирать только столбец id!");
            }
        }

       
        private void Form1_Load_3(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                ///string zapros = "SELECT Zakaz.id as [Номер заказа], Zakaz.status as [Статус заказа], Transfer.date_start as [Дата отправки], Transfer.date_end as [Дата доставки], Gruz.weight as [Масса], Sender.last_name as [Отправитель], Auto.number as [Госномер] from (((((Zakaz inner join Customer on Zakaz.Customer_id) inner join Sender on Zakaz.Sender_id = Sender.id) inner join Gruz on Zakaz.Gruz_id = Gruz.id) inner join Transfer on Zakaz.Transfer_id = Transfer.id) inner join Auto on Zakaz.Auto_id = Auto.id) where Customer.last_name = '"+comboBox3.Text+"';";
                string zapros = "SELECT Zakaz.id as [Номер заказа], Zakaz.status as [Статус заказа], Transfer.date_start as [Дата отправки], Transfer.date_end as [Дата доставки], Sender.last_name as [Отправитель] FROM ((Zakaz INNER JOIN Customer on Zakaz.Customer_id = Customer.id) INNER JOIN Transfer ON Transfer.id = Zakaz.Transfer_id) INNER JOIN Sender ON Sender.id = Zakaz.Sender_id WHERE Customer.last_name = '" + comboBox3.Text+"';";
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
            if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows[0].IsNewRow)
            {
                MessageBox.Show("Нет данных для создания отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");

                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);

                Document document = new Document();
                string filePath = "report_Customer_" + comboBox3.Text + ".pdf";
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();
                document.Add(new Phrase("Отчёт по пользователю " + comboBox3.Text, font));
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                    table.AddCell(cell);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString(), font));
                            table.AddCell(pdfCell);
                        }
                    }
                }
                document.Add(table);
                document.Close();
                MessageBox.Show("Отчет создан: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                ///string zapros = "SELECT Zakaz.id as [Номер заказа], Zakaz.status as [Статус заказа], Transfer.date_start as [Дата отправки], Transfer.date_end as [Дата доставки], Gruz.weight as [Масса], Sender.last_name as [Отправитель], Auto.number as [Госномер] from (((((Zakaz inner join Customer on Zakaz.Customer_id) inner join Sender on Zakaz.Sender_id = Sender.id) inner join Gruz on Zakaz.Gruz_id = Gruz.id) inner join Transfer on Zakaz.Transfer_id = Transfer.id) inner join Auto on Zakaz.Auto_id = Auto.id) where Customer.last_name = '"+comboBox3.Text+"';";
                string zapros = "SELECT Zakaz.id as [Номер заказа], Zakaz.status as [Статус заказа], Transfer.date_start as [Дата отправки], Transfer.date_end as [Дата доставки], Sender.last_name as [Отправитель], Customer.last_name as [Заказчик], Auto.number as [Госномер] FROM ((Zakaz INNER JOIN Customer on Zakaz.Customer_id = Customer.id) INNER JOIN Transfer ON Transfer.id = Zakaz.Transfer_id) INNER JOIN Sender ON Sender.id = Zakaz.Sender_id INNER JOIN Auto ON Auto.id = Zakaz.Auto_id INNER JOIN Driver on Driver.Auto_id = Auto.id WHERE Driver.last_name = '" + comboBox4.Text + "';";
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
            if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows[0].IsNewRow)
            {
                MessageBox.Show("Нет данных для создания отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");

                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);

                Document document = new Document();
                string filePath = "report_Driver_" + comboBox4.Text + ".pdf";
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();
                document.Add(new Phrase("Отчёт по водителю " + comboBox4.Text, font));
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                    table.AddCell(cell);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString(), font));
                            table.AddCell(pdfCell);
                        }
                    }
                }
                document.Add(table);
                document.Close();
                MessageBox.Show("Отчет создан: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(constring))
            {
                ///string zapros = "SELECT Zakaz.id as [Номер заказа], Zakaz.status as [Статус заказа], Transfer.date_start as [Дата отправки], Transfer.date_end as [Дата доставки], Gruz.weight as [Масса], Sender.last_name as [Отправитель], Auto.number as [Госномер] from (((((Zakaz inner join Customer on Zakaz.Customer_id) inner join Sender on Zakaz.Sender_id = Sender.id) inner join Gruz on Zakaz.Gruz_id = Gruz.id) inner join Transfer on Zakaz.Transfer_id = Transfer.id) inner join Auto on Zakaz.Auto_id = Auto.id) where Customer.last_name = '"+comboBox3.Text+"';";
                string zapros = "SELECT Zakaz.id as [Номер заказа], Zakaz.status as [Статус заказа], Transfer.date_start as [Дата отправки], Transfer.date_end as [Дата доставки], Sender.last_name as [Отправитель], Customer.last_name as [Заказчик], Auto.number as [Госномер] FROM ((Zakaz INNER JOIN Customer on Zakaz.Customer_id = Customer.id) INNER JOIN Transfer ON Transfer.id = Zakaz.Transfer_id) INNER JOIN Sender ON Sender.id = Zakaz.Sender_id INNER JOIN Auto ON Auto.id = Zakaz.Auto_id INNER JOIN Driver on Driver.Auto_id = Auto.id WHERE Sender.last_name = '" + comboBox5.Text + "';";
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
            if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows[0].IsNewRow)
            {
                MessageBox.Show("Нет данных для создания отчета", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");

                BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12);

                Document document = new Document();
                string filePath = "report_Sender_" + comboBox5.Text + ".pdf";
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();
                document.Add(new Phrase("Отчёт по продавцу " + comboBox5.Text, font));
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                    table.AddCell(cell);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value?.ToString(), font));
                            table.AddCell(pdfCell);
                        }
                    }
                }
                document.Add(table);
                document.Close();
                MessageBox.Show("Отчет создан: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
 
 
    
