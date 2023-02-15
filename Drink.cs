using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    abstract internal class Drink : Product
    {
        public enum Size { Tall, Venti, Grande, Trenta }
        Size _drinkSize;

        protected Drink(string name, decimal price, int point, string sku, string numberOfProduct, Size drinkSize) : base(name, price, point, sku, numberOfProduct)
        {
            _drinkSize = _drinkSize;
        }
        public Size drinkSize
        {
            get => _drinkSize;
        }

        public override string ToString()
        {
            return base.ToString() + $"-drinkSize: {_drinkSize.ToString()}";
        }

        public override bool InStock()
        {
            if (drinkSize <= Size.Venti) return false;
            return true;
        }
    }
}

