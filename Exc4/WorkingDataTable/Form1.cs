using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingDataTable
{
    public partial class Form1 : Form
        

    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customersDataGridView.DataSource = northwindDataSet1.Customers;
            customersDataGridView.MultiSelect = false;
            customersDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            customersDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void fillTableButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(northwindDataSet1.Customers);
        }

        private void updateRowVersionDisplay()
        {
            try
            {
                currentDRVTextBox.Text = GetSelectedRow() [customersDataGridView.CurrentCell.OwningColumn.Name, DataRowVersion.Current].ToString();
            }
            catch (Exception ex)
            {
                currentDRVTextBox.Text = ex.Message;
            }
            try
            {
                originalDRVTextBox.Text = GetSelectedRow()[customersDataGridView.CurrentCell.OwningColumn.Name,
                    DataRowVersion.Original].ToString();
            }
            catch (Exception ex)
            {
                originalDRVTextBox.Text = ex.Message;
            }
            rowStateTextBox.Text = GetSelectedRow().RowState.ToString();
        }
        private void addRowButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.CustomersRow newRow= (NorthwindDataSet.CustomersRow)northwindDataSet1.Customers.NewRow();
            newRow.CustomerID = "WINGT";
            newRow.CompanyName = (companyNameTextBox.Text == "" ? "Wingtip Toys": companyNameTextBox.Text);
            newRow.ContactName = "Steve Lasker";
            newRow.ContactTitle = "CEO";
            newRow.Address = "1234 Main Street";
            newRow.City = "Buffalo";
            newRow.Region = "NY";
            newRow.PostalCode = "98052";
            newRow.Country = "USA";
            newRow.Phone = "206-555-0111";
            newRow.Fax = "206-555-0112";

            try
            {
                northwindDataSet1.Customers.Rows.Add(newRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Row Failed");
            }
        }
        private NorthwindDataSet.CustomersRow GetSelectedRow()
        {
            string selectedCustomerID = customersDataGridView.CurrentRow.Cells["CustomerID"].Value.ToString();
            NorthwindDataSet.CustomersRow selectedRow = northwindDataSet1.Customers.FindByCustomerID(selectedCustomerID);
            return selectedRow;
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }

        private void updateValueButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow()[customersDataGridView.CurrentCell.OwningColumn.Name] =
                cellValueTextBox.Text;
            updateRowVersionDisplay();
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customersDataGridView_Click(object sender, EventArgs e)
        {
            cellValueTextBox.Text = customersDataGridView.CurrentCell.Value.ToString();
            updateRowVersionDisplay();
        }

        private void acceptChangeButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().AcceptChanges();
            updateRowVersionDisplay();
        }

        private void rejectChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().RejectChanges();
            updateRowVersionDisplay();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
