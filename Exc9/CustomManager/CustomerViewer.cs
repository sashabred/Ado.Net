using CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomManager
{
    public partial class CustomerViewer : Form
    {
        SampleContext context = new SampleContext();
        
        byte[] Ph;
        public CustomerViewer()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());
            InitializeComponent();
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    FirstName = this.textBoxName.Text,
                    LastName = this.textBoxLastname.Text,
                    Email = this.textBoxMail.Text,
                    Age = Int32.Parse(this.textBoxAge.Text),
                    Photo = Ph,
                    Orders = orderListBox.SelectedItems.OfType<Order>().ToList()

                };
                context.Customers.Add(customer);

                context.SaveChanges();
                Output();
                textBoxName.Text = String.Empty;
                textBoxMail.Text = String.Empty;
                textBoxAge.Text = String.Empty;
                textBoxLastname.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                Image bm = new Bitmap(diag.OpenFile());
                ImageConverter converter = new ImageConverter();
                Ph = (byte[])converter.ConvertTo(bm, typeof(byte[]));
            }
        }

        private void CustomerViewer_Load(object sender, EventArgs e)
        {
            context.Orders.Add(new Order
            {
                ProductName = "Аудио",
                Quantity = 12,
                PurchaseDate = DateTime.Parse("12.01.2016")
            });
            context.Orders.Add(new Order
            {
                ProductName = "Видео",
                Quantity = 22,
                PurchaseDate = DateTime.Parse("10.01.2016")
            });
     
            context.VipOrders.Add(new VipOrder
            {
                ProductName = "Авто",
                Quantity = 101,
                PurchaseDate = DateTime.Parse("10.01.2016"),
                status = "Высокий"
            });
            try
            {
                context.SaveChanges();
                orderListBox.DataSource = context.Orders.ToList();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        MessageBox.Show("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
         
            

        }
        private void Output()
        {
            if (this.customerRadioButton.Checked == true)
                GridView.DataSource = context.Customers.ToList();
            else if (this.orderRadioButton.Checked == true)
                GridView.DataSource = context.Orders.ToList();
            else if (this.vipRadioButton.Checked == true)
                GridView.DataSource = context.VipOrders.ToList();

        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
           
            Output();
            var query = from b in context.Customers
                        orderby b.FirstName
                        select b;
            
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (GridView.CurrentRow == null) return;
                var customer = GridView.CurrentRow.DataBoundItem as
                Customer;
                if (customer == null) return;
                labelID.Text = Convert.ToString(customer.CustomerId);
                textBoxCustomer.Text = customer.ToString();
                textBoxName.Text = customer.FirstName;
                textBoxLastname.Text = customer.LastName;
                textBoxMail.Text = customer.Email;
                textBoxAge.Text = Convert.ToString(customer.Age);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (labelID.Text == String.Empty) return;
            var id = Convert.ToInt32(labelID.Text);
            var customer = context.Customers.Find(id);
            if (customer == null) return;
            customer.FirstName = this.textBoxName.Text;
            customer.LastName = this.textBoxLastname.Text;
            customer.Email = this.textBoxMail.Text;
            customer.Age = Int32.Parse(this.textBoxAge.Text);
            context.Entry(customer).State = EntityState.Modified;
            context.SaveChanges();
            Output();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (labelID.Text == String.Empty) return;
            var id = Convert.ToInt32(labelID.Text);
            var customer = context.Customers.Find(id);
            context.Entry(customer).State = EntityState.Deleted;
            context.SaveChanges();
            Output();
        }

        private void vipRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }    
}
