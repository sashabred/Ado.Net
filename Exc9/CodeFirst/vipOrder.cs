using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    [Table("VipOrders")]
    public class VipOrder : Order
    {
        public string status { get; set; }
    }
}