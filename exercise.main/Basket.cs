using System;
using System.Collections.Generic;
using System.Globalization;
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

        public Product? AddItem(Product item)
        {
            if (_count <= _capacity)
            {
                _items.Add(item);
                _count++;
                return item;
            }
            else return null;
        }

        public Product? RemoveItem(Guid id)
        {
            if (_count == 0) { return null; }

            foreach (Product item in _items)
            {
                if (item.Id == id)
                {
                    _items.Remove(item);
                    _count--;
                    return item;
                }
            }
            return null;
        }

        public bool ChangeCapacity(int ncapacity)
        {
            if(_role == Role.Manager && ncapacity >= 0)
            {
                _capacity = ncapacity;
                return true;
            }
            return false;
        }

        public float GetBasketTotalPrice()
        {
            if(_count <= 0) { return 0; }
            float cost = _items.Sum(x => x.Price);
            return cost;
        }

        public void PrintReceipt()
        {
            float total = GetBasketTotalPrice();
            CultureInfo local = new("en-GB");

            string text = 
                "=============[ Bob's Bagels Receipt ]===============\n" +
                "====================================================\n\n";
            foreach (Product item in _items)
            {
                if (item is ProductBundle) { text += $"{item.ToString()}\n\n"; continue; }
                text += $"{item.ToString()}  ---  {item.Price.ToString("C", local)}\n\n";
            }

            text += $"\n\n\nTotal:  {total.ToString("C", local)}\n====================================================";

            Console.WriteLine(text);
        }
      
        
    }
}
