using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Midterm
{

    public class Data
    {
        static ObservableCollection<Member> _members;
        static ObservableCollection<Product> _products;
        static Member curentMember = null;
        static Product curentProduct = null;

        static Data()
        {
            _members = new ObservableCollection<Member>();
            _products = new ObservableCollection<Product>();
        }

        internal static ObservableCollection<Member> Members { get => _members; set => _members = value; }
        internal static ObservableCollection<Product> Products { get => _products; set => _products = value; }
        internal static Member CurentMembers { get => curentMember; set => curentMember = value; }
        internal static Product CurentProducts { get => curentProduct; set => curentProduct = value; }

        static void AddMemberToCollection(Member)
        {
            _members.Add(new Member);
        }
        static void AddProductToCollection(Product)
        {
            _products.Add(new Product);
        }
        static void UpdataCurrentMember(Member)
        {
            curentMember = _members;
        }
        static void UpdataCurrentProduct(Product)
        {
            curentProduct = _products;
        }
    }

}
