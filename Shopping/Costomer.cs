using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Costomer
    {
        private string _name;
        private int _id;
        private string _tel;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name { 
            get { return _name; }
            set { _name = value; }
        }
        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
         public Costomer(int id )
        {
            _id = id;
        }
        
        public Costomer(int id, string name) {
            _id = id;
            _name = name;
        
        }
        public Costomer(int id , string name , string tel) { 
            _id = id;
            _name = name;
            _tel = tel;      
        }
        
    }
}
