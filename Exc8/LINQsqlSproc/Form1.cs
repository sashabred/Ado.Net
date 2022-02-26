using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LINQsqlSproc
{
    public partial class Form1 : Form
    {
        Northwnd db = new Northwnd(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void orderDetailsButton_Click(object sender, EventArgs e)
        {
            string param = textBox1.Text;
            var custquery = db.CustOrdersDetail(Convert.ToInt32(param));
            string mag = "";
            foreach (CustOrdersDetailResult custOrdersDetail in custquery)
            {
                mag = mag + custOrdersDetail.ProductName + "\n";
            }
            if (mag == "")
                mag = "No results";
            MessageBox.Show(mag);
            param = "";
            textBox1.Text = "";
        }

        private void orderHistoryButton_Click(object sender, EventArgs e)
        {
            string param = textBox2.Text;
            var custquery = db.CustOrderHist(param);
            string mag = "";
            foreach (CustOrderHistResult custOrdHist in custquery)
            {
                mag= mag+custOrdHist.ProductName + "\n";
            }
            MessageBox.Show(mag);
            param = "";
            textBox2.Text = "";
        }
    }
}
