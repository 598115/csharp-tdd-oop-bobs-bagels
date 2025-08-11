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
        public Bagel(float price, Filling filling) : base(price)
        {
           _filling = filling; 
        }

        public Bagel(float price) : base(price)
        {
            _filling = new Filling(0.39f, FillingType.Plain);
        }

        public Filling Filling { get { return _filling; } set { _filling = value; } }
        public Filling ChooseFillings(Filling filling)
        {
            _filling = filling;
            return _filling;
        }
    }
}
