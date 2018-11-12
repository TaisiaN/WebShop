using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopProject.Models
{
    public class CustomerOrder
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
        public string Quantity { get; set; }
    }
}