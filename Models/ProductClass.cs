using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    internal class ProductClass
    {
        private int _id;
        private string _name;
        private float _price;
        private double _discountPercentage;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public float price
        {
            get { return _price; }
            set { _price = value; }
        }
        public double discountPercentage
        {
            get { return _discountPercentage; }
            set { _discountPercentage = value; }
        }
        public double GetDiscountedCost()
        {
             return _price - (_price * (_discountPercentage/100));
        }
        
    }
}
