using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Product
    {
        private string _nameProduct;
        private int _idProduct;
        private decimal _priceProduct;
        public int IdProduct {
            get { return _idProduct; }
            set { _idProduct = value; }
        }
        
        public string NameProduct {
            get { return _nameProduct; }
            set { _nameProduct = value; }
        }
        public decimal Price
        {
            get { return _priceProduct; }
            set { _priceProduct = value; }
        }

        public Product (int id )
        {
            IdProduct = id;

        }
        public Product(int id , string name)
        {
            IdProduct = id;
            NameProduct = name;
        }
        public Product(int id , string name , decimal price)
        {
            IdProduct = id;
            NameProduct = name;
            Price = price;

        }
        
        
        
    }
}
