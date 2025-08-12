using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    internal class ProductLookup
    {
        private readonly Dictionary<Enum, float> _priceLookup = new Dictionary<Enum, float>();
        private readonly Dictionary<Enum, string>  _SKUlookup = new Dictionary<Enum, string>();

        public ProductLookup()
        {
            _priceLookup.Add(BagelType.Onion, 0.49f);
            _priceLookup.Add(BagelType.Plain, 0.39f);
            _priceLookup.Add(BagelType.Everything, 0.49f);
            _priceLookup.Add(BagelType.Sesame, 0.49f);
            _priceLookup.Add(CoffeeType.Black, 0.99f);
            _priceLookup.Add(CoffeeType.White, 1.19f);
            _priceLookup.Add(CoffeeType.Capuccino, 1.29f);
            _priceLookup.Add(CoffeeType.Latte, 1.29f);
            _priceLookup.Add(FillingType.Bacon, 0.12f);
            _priceLookup.Add(FillingType.Egg, 0.12f);
            _priceLookup.Add(FillingType.Cheese, 0.12f);
            _priceLookup.Add(FillingType.Cream_Cheese, 0.12f);
            _priceLookup.Add(FillingType.Smoked_Salmon, 0.12f);
            _priceLookup.Add(FillingType.Ham, 0.12f);
            _priceLookup.Add(FillingType.None, 0.0f);

            _SKUlookup.Add(BagelType.Onion, "BGLO");
            _SKUlookup.Add(BagelType.Plain, "BGLP");
            _SKUlookup.Add(BagelType.Everything, "BGLE");
            _SKUlookup.Add(BagelType.Sesame, "BGLS");
            _SKUlookup.Add(CoffeeType.Black, "COFB");
            _SKUlookup.Add(CoffeeType.White, "COFW");
            _SKUlookup.Add(CoffeeType.Capuccino, "COFC");
            _SKUlookup.Add(CoffeeType.Latte, "COFL");
            _SKUlookup.Add(FillingType.Bacon, "FILB");
            _SKUlookup.Add(FillingType.Egg, "FILE");
            _SKUlookup.Add(FillingType.Cheese, "FILC");
            _SKUlookup.Add(FillingType.Cream_Cheese, "FILX");
            _SKUlookup.Add(FillingType.Smoked_Salmon, "FILS");
            _SKUlookup.Add(FillingType.Ham, "FILH");
        }

        public float LookupPriceByType(Enum type)
        {
            if (_priceLookup.ContainsKey(type))
            {
                float price = _priceLookup[type];
                return price;
            }
            Console.WriteLine($"Could not find type {type.ToString()} in price lookup");
            return -1;
        }

        public string LookupSKUByType(Enum type)
        {
            if (_priceLookup.ContainsKey(type))
            {
                string sku = _SKUlookup[type];
                return sku;
            }
            Console.WriteLine($"Could not find type {type.ToString()} in price lookup");
            return "";
        }
    }
}
