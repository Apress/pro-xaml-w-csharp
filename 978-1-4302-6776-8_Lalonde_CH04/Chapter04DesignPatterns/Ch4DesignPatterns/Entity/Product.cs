using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4DesignPatterns.Entity
{
    public class Product
    {
        private int _Id;
        private string _Name;
        private double _Price;
        private int _CountOnHand;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public int CountOnHand
        {
            get { return _CountOnHand; }
            set { _CountOnHand = value; }
        }
    }
}
