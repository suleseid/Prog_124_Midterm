using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_124_Midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Product> _products;
        ObservableCollection<Member> _members;
        public MainWindow()
        {
            InitializeComponent();
            lb1display.ItemsSource = Data.products;
            lb1display.ItemsSource = Data.members;
            Data.Products.Add(new drink("Hotlatte", 7, 200, Drink.Size.Tall, 165.99));
            Preload();
        }
        public void Preload()
        {
            Data.Products.Add(new drink("Butter Crossiant", 7, 200, Drink.Size.Venti, 4577.87));
        }

        private void btnAddNewProduct_Click(object sender, RoutedEventArgs e)
        {
            AddNewProductWindow addNewProductWindow = new AddNewProductWindow();
            addNewProductWindow.Show();
        }

        private void btn4MemberInfo_Click(object sender, RoutedEventArgs e)
        {
            MemberInformation_Window memberInformationWindow = new MemberInformation_Window();
            memberInformationWindow.Show();
        }

        private void RichtxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lb1display_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn2BuyProduct_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
