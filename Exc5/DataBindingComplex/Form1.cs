using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingComplex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        private void bindGridButton_Click(object sender, EventArgs e)
        {
            BindingSource productsBindingSource = new BindingSource(northwindDataSet, "Products");
            productsGrid.DataSource = productsBindingSource;
            bindingNavigator1.BindingSource = productsBindingSource;
            productsTableAdapter.Fill(northwindDataSet.Products);

        }

        private void productsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
