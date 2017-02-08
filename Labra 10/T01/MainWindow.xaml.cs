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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace T01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string checkedBoxes;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Check(CheckBox chb)
        {
            if ((bool)chb.IsChecked)
            {
                checkedBoxes += chb.Content.ToString() + " ";
            }
            txtList.Text = checkedBoxes;
        }
        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            Check(chbBeer);
            Check(chbCoke);
            Check(chbPizza);
            Check(chbChocolate);
            checkedBoxes = "";
        }
    }
}
