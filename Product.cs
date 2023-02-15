using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{
    public abstract class Product
    {
        string _Name;
        decimal _Price;
        int _Point = 0;
        string _Sku;
        string _NumberOfProduct;

       
        protected Product(string name, decimal price, int point, string sku, string numberOfProduct)
        {
            _Name = name;
            _Price = price;
            _Point = point;
            Random random = new Random();
            _Sku = random.Next(1000000, 1000000).ToString();
            _NumberOfProduct = numberOfProduct;
        }

        public abstract bool InStock();

        ObservableCollection<Product> products { get => products; set => products = value; }

        public override string ToString()
        {
            return $"Name: {_Name} -InStock: {InStock()}-Price: {_Price.ToString("c")} -Point: {_Point} - sku: {_Sku} _NumberOfProduct: {_NumberOfProduct}";
        }
    }
}
