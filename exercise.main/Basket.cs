using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Basket
    {
        private List<Product> _items;
        private int _capacity;
        private int _count;
        private Role _role;

        public Basket(List<Product> items, int capacity, Role role)
        {
            _items = items;
            _capacity = capacity;
            _role = role;
        }
        public Basket(int capacity, Role role)
        {
            _items = new List<Product>();
            _capacity = capacity;
            _role = role;
        }
        public Basket(int capacity)
        {
            _items = new List<Product>();
            _capacity = capacity;
        }
        public int Capacity {get {return _capacity;} }
        public int Count { get { return _count; } }

        public Bagel AddItem(Product item)
        {
            throw new NotImplementedException();
        }

        public Bagel RemoveItem(Guid v)
        {
            throw new NotImplementedException();
        }

        public bool ChangeCapacity(int v)
        {
            throw new NotImplementedException();
        }

        public float GetBasketTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}
