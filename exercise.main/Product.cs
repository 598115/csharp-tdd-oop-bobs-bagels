using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Product
    {
        private Guid _id;
        private float _price;
        public Product(float price)
        {
            _id = Guid.NewGuid();
            _price = price;
        }

        public Guid Id { get { return _id; } set { _id = value; } }

        public float Price { get { return _price; } set { _price = value; } }

        public void changePrice(float v)
        {
            throw new NotImplementedException();
        }

    }
}
