using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class ProductBundle : Product
    {

        private List<Product> _products = new();
        private float _discount = 0;
        private int _count = 0;
        private BundleType _type;
        private BagelType _bagelType;

        public ProductBundle(BundleType type) : base(type)
        {
            _type = type;
        }

        public List<Product> Products { get { return _products; } }
        
        public float Discount { get { return _discount; } set { _discount = value; } }

        public void BagelDeal6(BagelType type, Filling filling, Filling filling2, Filling filling3, Filling filling4, Filling filling5, Filling filling6)
        {
            this.Price = 2.49f;
            _count = 6;
            _type = BundleType.bagel6;
            _bagelType = type;

            Bagel bagel1 = new(filling, type);
            Bagel bagel2 = new(filling2, type);
            Bagel bagel3 = new(filling3, type);
            Bagel bagel4 = new(filling4, type);
            Bagel bagel5 = new(filling5, type);
            Bagel bagel6 = new(filling6, type);

            _products.Add(bagel1);
            _products.Add(bagel2);
            _products.Add(bagel3);
            _products.Add(bagel4);
            _products.Add(bagel5);
            _products.Add(bagel6);

            if(type.Equals(BagelType.Plain))
            {
                _discount = 0.0f;
                this.Price = 2.34f;
                addFillingCost();
                return;
            }
            _discount = 0.45f;
            addFillingCost();
        }

        public void BagelDeal12(BagelType type, Filling filling, Filling filling2, Filling filling3, Filling filling4, Filling filling5, Filling filling6,
             Filling filling7, Filling filling8, Filling filling9, Filling filling10, Filling filling11, Filling filling12)
        {
            this.Price = 3.99f;
            _count = 12;
            _type = BundleType.bagel12;
            _bagelType = type;

            Bagel bagel1 = new(filling, type);
            Bagel bagel2 = new(filling2, type);
            Bagel bagel3 = new(filling3, type);
            Bagel bagel4 = new(filling4, type);
            Bagel bagel5 = new(filling5, type);
            Bagel bagel6 = new(filling6, type);
            Bagel bagel7 = new(filling7, type);
            Bagel bagel8 = new(filling8, type);
            Bagel bagel9 = new(filling9, type);
            Bagel bagel10 = new(filling10, type);
            Bagel bagel11 = new(filling11, type);
            Bagel bagel12 = new(filling12, type);

            _products.Add(bagel1);
            _products.Add(bagel2);
            _products.Add(bagel3);
            _products.Add(bagel4);
            _products.Add(bagel5);
            _products.Add(bagel6);
            _products.Add(bagel7);
            _products.Add(bagel8);
            _products.Add(bagel9);
            _products.Add(bagel10);
            _products.Add(bagel11);
            _products.Add(bagel12);

            if (type.Equals(BagelType.Plain))
            {
                _discount = 0.69f;
                addFillingCost();
                return;
            }
            _discount = 1.89f;
            addFillingCost();
        }

        public void CoffeeAndBagelDeal(Filling filling, BagelType type)
        {
            this.Price = 1.25f;
            _count = 1;
            _type = BundleType.coffeeBagel;
            _bagelType = type;

            Bagel bagel = new(filling, type);
            Coffee coffee = new(CoffeeType.Black);

            _products.Add(bagel);
            _products.Add(coffee);

            if (type.Equals(BagelType.Plain))
            {
                _discount = 0.13f;
                addFillingCost();
                return;
            }
            _discount = 0.23f;
            addFillingCost();
        }

        private void addFillingCost()
        {
            foreach (Product p in _products)
            {
                if(p.Type.Equals(BagelType.Plain)) { }
                else
                {
                    if (p is Bagel b)
                    {
                        this.Price += b.Filling.Price;
                    }
                }
            }
        }

        public override string ToString()
        {
            CultureInfo local = new("en-GB");

            if (_type.Equals(BundleType.bagel6) || _type.Equals(BundleType.bagel12))
            {
                return $"{_bagelType} Bagel x {_count} --- " + this.Price.ToString("C", local)
                      +$"\n                    -({_discount.ToString("C", local)})" ;
            }

            if (_type.Equals(BundleType.coffeeBagel))
            {
                return $"Coffee and {_bagelType} Bagel  ---  " + this.Price.ToString("C", local)
                      + $"\n                            -({_discount.ToString("C", local)})";
            }
            return "";
        }

    }
}
