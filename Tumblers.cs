using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm

{
    internal class Tumblers : Merchandies
    {
        public enum Color { Red, Green, Blue, RedBlue, Greenblue }
        static int Count = 0;
        Type _TypeOfColor;

        public Tumblers(string name, decimal price, int point, string sku, string numberOfProduct, Type ColorType, Type TypeOfColor) : base(name, price, point, sku, numberOfProduct, ColorType)
        {
            _TypeOfColor = _TypeOfColor;
        }
        public override string ToString()
        {
            return base.ToString() + $"_TypeOfColor : {_TypeOfColor}";
        }
    }
}
