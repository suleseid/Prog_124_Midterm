using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    internal class Mugs : Merchandies
    {
        public enum design { Shape, Size };
        // static int Count = 0;//
        Type _Style;

        public Mugs(string name, decimal price, int point, string sku, string numberOfProduct, Type ColorType, Type _Style) : base(name, price, point, sku, numberOfProduct, ColorType)
        {
            _Style = _Style;
        }
        public override string ToString()
        {
            return base.ToString() + $"_Style : {_Style}";
        }
    }
}
