using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadDataSetXml
{
    public partial class Form1 : Form
    {
        DataSet NorthwindDataSet = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadSchemaButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.ReadXmlSchema("Northwind.xsd");
            customersGrid.DataSource = NorthwindDataSet.Tables["Customers"];
            ordersGrid.DataSource = NorthwindDataSet.Tables["Orders"];

        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.ReadXml("Northwind.xml");
        }
    }
}
