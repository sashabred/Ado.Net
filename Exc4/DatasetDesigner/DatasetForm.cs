using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatasetDesigner
{
    public partial class DatasetForm : Form
    {
        public DatasetForm()
        {
            InitializeComponent();
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet northwindDataSet = new NorthwindDataSet();
            NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter = new NorthwindDataSetTableAdapters.CustomersTableAdapter();
            customersTableAdapter.Fill(northwindDataSet.Customers);
            foreach  (NorthwindDataSet.CustomersRow NWCustomer in northwindDataSet.Customers.Rows) 
            {
                CustomersListBox.Items.Add(NWCustomer.CompanyName);
            }

        }
    }
}
