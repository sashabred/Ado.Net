using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataViewExample
{
    public partial class MainForm : Form
    {
        DataView customersDataView;
        DataView ordersDataView;
        public MainForm()
        {
            InitializeComponent();
        }

        private void customersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(northwindDataSet1.Customers);
            ordersTableAdapter1.Fill(northwindDataSet1.Orders);
            customersDataView = new DataView(northwindDataSet1.Customers);
            ordersDataView = new DataView(northwindDataSet1.Orders);    
            customersDataView.Sort = "CustomerID";
            customersGrid.DataSource = customersDataView;
        }

        private void setDataViewPropButton_Click(object sender, EventArgs e)
        {
            customersDataView.Sort = sortTextBox.Text;
            customersDataView.RowFilter = String.Format("City = '{0}'",filterTextBox.Text);
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            DataRowView newCustomRow = customersDataView.AddNew();
            newCustomRow["CustomerID"] = "WINGT";
            newCustomRow["CompanyName"] = "Wing Tip Toys";
            newCustomRow.EndEdit();
        }

        private void getOrdersButton_Click(object sender, EventArgs e)
        {
            string selectedCustomersId = (string)customersGrid.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
            DataRowView selectedRow = customersDataView[customersDataView.Find(selectedCustomersId)];
            ordersDataView = selectedRow.CreateChildView(northwindDataSet1.Relations["FK_Orders_Customers"]);
            ordersGrid.DataSource = ordersDataView;
        }
    }
}
