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
        private Enum _type;
        private string _SKU;
          
        public Product(Enum type)
        {
            _id = Guid.NewGuid();
            _price = 0;
            _type = type;
            _SKU = "";
        }

        public Guid Id { get { return _id; } set { _id = value; } }

        public float Price { get { return _price; } set { _price = value; } }
        public Enum Type { get { return _type; } set { _type = value; } }

        public string SKU { get { return _SKU; } set { _SKU = value; } }

        public float changePrice(float nprice)
        {
            if (nprice < 0)
            {
                _price = 0;
                return 0;
            }
            _price = nprice;
            return _price;
        }

    }
}
