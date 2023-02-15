using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Prog_124_Midterm
{
    /// <summary>
    /// Interaction logic for MemberInformation_Window.xaml
    /// </summary>
    public partial class MemberInformation_Window : Window
    {
        public MemberInformation_Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtBox1fName.Text == "" && txtbox2lName.Text == "")
            {
                MessageBox.Show("Please enter the correct text");
            }
            else
            {
                lbDisplayone.Items.Add("First Name" + txtBox1fName.Text + "last name" + txtbox2lName.Text + GroupBox1.ContentTemplateSelector);
            }
        }
    }
}
