using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using DBConnection;

namespace DBCpnncetion
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection();
       // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            this.connection.StateChange += new StateChangeEventHandler(this.Connection_StateChange);

        }
        static string GetConnectionStringByName (string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        string connectionString = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        private void connectDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных " +
                    connection.Database + " выполнено успешно " + "\nСервер: " +
                    connection.DataSource);
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (SqlException XcpSQL)
            {
                foreach (SqlError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, 
                        "Источник ошибки:" + se.Source,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Ошибка соединения с базой данных");
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnectDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        private async void asyncConnectionDBToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            try 
                {
                    if(connection.State != ConnectionState.Open) 
                    {
                    connection.ConnectionString = connectionString;
                    await connection.OpenAsync();
                    MessageBox.Show("Соединение с базой данных " +
                        connection.Database + " выполнено успешно " + "\nСервер: " +
                        connection.DataSource);
                    }
                    else
                {
                    MessageBox.Show("Соединение с базой данных уже установлено");
                }
                }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }
            

        }

        private void Connection_StateChange(object sender, StateChangeEventArgs e)
        {
            connectDBToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            asyncConnectionDBToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            disconnectDBToolStripMenuItem.Enabled = (e.CurrentState == ConnectionState.Open);
        }

        private void listOfConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    string str = String.Format("Name = {0} \nProviderName = {1}\nConnectionString = {2}",
                    cs.Name, cs.ProviderName, cs.ConnectionString);
                    MessageBox.Show(str, "Connection parameters");

                }
            }
        }

        private void buttonProductsCount_Click(object sender, EventArgs e)
        {
            using (connection)
            {
                if (connection.State == ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Products";
                    try
                    {
                        int num = (int)command.ExecuteScalar();
                        label1.Text = num.ToString();

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Connect to DB");
                }
            }
        }

        private void buttonProductCount2_Click(object sender, EventArgs e)
        {
            try
            {
                int number = WorkWithDataBase.ExecuteScalarMethod(connectionString, "SELECT COUNT(*) FROM Products");
                productCountLabel.Text = number.ToString(); 
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listOfProductsBut_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand com = connect.CreateCommand();
                    com.CommandText = "Select ProductName, UnitPrice, QuantityPerUnit FROM Products";
                    connect.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem newitem =
                        listView1.Items.Add(reader["ProductName"].ToString());
                        newitem.SubItems.Add(reader.GetDecimal(1).ToString());
                        newitem.SubItems.Add(reader["QuantityPerUnit"].ToString());
                    }
                         
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void butTransaction_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                try
                {
                    SqlTransaction sqlTran = connection.BeginTransaction();
                    SqlCommand com = connection.CreateCommand();
                    com.Transaction = sqlTran;
                    com.CommandText = "INSERT INTO Products (ProductName, UnitPrice, QuantityPerUnit) VALUES ('Wrong size', 12, '1 boxes')";
                    com.ExecuteNonQuery();
                    com.CommandText = "INSERT INTO Products (ProductName, UnitPrice, QuantityPerUnit) VALUES ('Wrong color', 25,'100 ml')";
                    com.ExecuteNonQuery();
                    sqlTran.Commit();
                    MessageBox.Show("Строки записаны в базу данных");
                    try
                    {
                        sqlTran.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        MessageBox.Show(exRollback.Message);
                    }

                }
                catch (SqlException ex)
                {
                    
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
