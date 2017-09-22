using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.psit.ms.presentation.test
{
    public class Product
    {
        private String name;
        private double price;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
