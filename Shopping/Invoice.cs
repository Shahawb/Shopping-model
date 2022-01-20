using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Invoice
    {
       
        public DateTime _dateInvoce;

        public int IdInvoice {
            get;
            set ; 
        }
        public Costomer CostomerObject {
            get;
            set;
        }
        public DateTime Date { 
            get { return _dateInvoce; }
            set { _dateInvoce= value; }
        }
    }
}
