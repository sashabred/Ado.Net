using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQsql_1
{
    [Table(Name = "Orders")]
    public class Order
    {
        private int _orderID = 0;
        private string _customerID;
        private EntityRef<Customer> _customer;
        public Order()
        {
            this._customer = new EntityRef<Customer>();
        }

        [Column(Storage="_orderID", DbType ="Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated =true)]
        public int OrderID 
            {
                get { return this._orderID; } 
            }

        [Column(Storage="_customerID", DbType = "NChar(5)")]
        public string CustomerID
        {
            get { return this._customerID; }
            set { this._customerID = value; }
        }

        [Association(Storage = "_customer", ThisKey = "CustomerID")]
        public Customer Customer
        {
            get { return this._customer.Entity; }
            set { this._customer.Entity = value;}
        }

        public override string ToString()
        {
            return CustomerID + "\t" + OrderID;
        }
    }
}
