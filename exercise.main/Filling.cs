using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Filling : Product
    {
        private FillingType _type;
        private readonly ProductLookup _lookup = new();
        public Filling(FillingType type) : base(type)
        {
            _type = type;
            this.CalculatePrice();
        }

        private float CalculatePrice()
        {           
          this.Price = _lookup.LookupPriceByType(_type);
          return this.Price;       
        }

        public override string ToString()
        {
            return $"{_type.ToString()}";
        }


    }
}
