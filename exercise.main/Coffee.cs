using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Coffee : Product
    {
        private CoffeeType _type;
        private readonly ProductLookup _lookup = new ProductLookup();
        public Coffee(CoffeeType type) : base(type)
        {
            _type = type;
            this.Price = CalculatePrice();
        }

        private float CalculatePrice()
        {
            this.Price = _lookup.LookupPriceByType(_type);
            return this.Price;
        }

        public override string ToString()
        {
            return _type.ToString();
        }
    }
    
}
