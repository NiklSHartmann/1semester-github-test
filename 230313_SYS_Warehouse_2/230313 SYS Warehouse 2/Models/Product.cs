using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230313_SYS_Warehouse_2.Models
{
    public class Product
    {
        //Properties
        public int ProductNumber { get; set; }
        public string ProductName { get; set; }
        public decimal NetPrice { get; set; }
        public decimal GrossPrice { get; set; }
        public int Qty { get; set; }

        // Constructor
        public Product(int prodNum, string prodName, decimal netPrice, decimal grossPrice, int qty)
        {
            this.ProductNumber = prodNum;
            this.ProductName = prodName;
            this.NetPrice = netPrice;
            this.GrossPrice = grossPrice;
            this.Qty = qty;
        }
    }
}
