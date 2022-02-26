using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQsql_1
{
    [Table(Name = "Customers")]
    public class Customer
    {
        private string _customerID;
        private EntitySet<Order> _orders;

        [Column(IsPrimaryKey = true, Storage = "_customerID")]
        public string CustomerID 
            { 
                get  
                { 
                    return this._customerID; 
                }
                set
                {
                this._customerID = value;
                }
            }

        private string _city;
        [Column(Storage = "_city")]
        public String City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
            }
        }

        private string _companyName;
        [Column(Storage ="_companyName")]
        public String CompanyName
        {
            get
            {
                return this._companyName;
            }
            set 
            { 
                this._companyName = value; 
            }
        }

        public override string ToString()
        {
            return CustomerID+"\t"+City+"\t"+CompanyName;
        }

        public Customer()
        {
            this._orders = new EntitySet<Order>();
        }

        [Association(Storage ="_orders", OtherKey ="CustomerID")]
        public EntitySet<Order> Orders
        {
            get { return this._orders; }
            set { this._orders.Assign(value); }
        }
    }
}
