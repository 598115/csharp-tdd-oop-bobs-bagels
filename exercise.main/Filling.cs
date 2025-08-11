using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Filling : Product
    {
        private FillingType _type;
        public Filling(float price, FillingType type) : base(price)
        {
            _type = type;
        }
        public FillingType Type { get { return _type; } }
    }
}
