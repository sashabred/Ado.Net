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

namespace DBCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            using (sqlConnection1)
            {
                try
                {
                    sqlConnection1.Open();
                    SqlDataReader reader = sqlCommand1.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");

                        }
                        results.Append(Environment.NewLine);
                        ResultsTextBox.Text = results.ToString();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message,"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (sqlConnection1)
            {
                sqlCommand2.CommandText = "CREATE TABLE SalesPersons (" +
                "[SalesPersonID] [int] IDENTITY(1,1) NOT NULL, " +
                "[FirstName] [nvarchar](50) NULL, " +
                "[LastName] [nvarchar](50) NULL)";
                try
                {
                    sqlConnection1.Open();
                    sqlCommand2.ExecuteNonQuery();
                    MessageBox.Show("Таблица SalesPersons создана");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void butQueryParam_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            try
            {
                sqlCmdQueryParam.Parameters["@City"].Value = CityTextBox.Text;
                sqlConnection1.Open();
                SqlDataReader reader = sqlCmdQueryParam.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                ResultsTextBox.Text = results.ToString();
            }
            catch (SqlException ex)
            {          
            MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection1.Close();
            }
        }

        private void butProcedureParam_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            try
            {
                sqlCmdProcedure.Parameters["@CategoryName"].Value =
                CategoryNameTextBox.Text;
                sqlCmdProcedure.Parameters["@OrdYear"].Value = OrdYearTextBox.Text;
                sqlConnection1.Open();
                SqlDataReader reader = sqlCmdProcedure.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                ResultsTextBox.Text = results.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection1.Close();
            }
        }
    }
}
