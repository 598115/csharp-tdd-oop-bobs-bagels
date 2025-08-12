using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Bagel : Product
    {
        private Filling _filling;
        private ProductLookup _lookup = new();
        private readonly BagelType _type;
        public Bagel(Filling filling, BagelType type) : base(type)
        {
           _filling = filling;
           _type = type; 
            this.CalculatePrice();
            this.SKU = _lookup.LookupSKUByType(type);
        }

        public Bagel(BagelType type) : base(type)
        {
            _type = type;
            this.CalculatePrice();
            this.SKU = _lookup.LookupSKUByType(type);
            _filling = new Filling(FillingType.None);
        }

        public Filling Filling { get => _filling; set { _filling = value; } }
        public Filling ChooseFillings(Filling filling)
        {
            _filling = filling;

            this.Price += _lookup.LookupPriceByType(filling.Type);

            return _filling;
        }

        private float CalculatePrice()
        {
            if (_filling == null)
            {
                this.Price = _lookup.LookupPriceByType(_type);
            }
            else 
            {
                this.Price = _lookup.LookupPriceByType(_type) + _filling.Price;
            }
            return this.Price;
        }

        public override string ToString()
        {
            return _type.ToString();
        }
    }
}
