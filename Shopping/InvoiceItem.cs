using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class InvoiceItem
    {
        private int _id;
        private int _quantity;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Product productObject
        {
            get;set;
        }
        public Invoice invoiceItem { get; set; }
     
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public int TotalRowPrice { get 
            {
                return Convert.ToInt32(productObject.Price) * Quantity;
            }}

        public List<InvoiceItem> invoiceItems =new()
        {
            
        };
        

       
    }
}
