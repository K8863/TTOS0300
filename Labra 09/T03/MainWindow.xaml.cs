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

namespace T03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonLaske_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int length, height, width;

                if (int.TryParse(inputLength.Text, out length) && int.TryParse(inputHeight.Text, out height) && int.TryParse(inputWidth.Text, out width))
                {
                    resultWinArea.Text = ((length * height) / 100).ToString() + " cm^2";
                    resultGlassArea.Text = (((length - (2 * width)) * (height - (2 * width))) / 100).ToString() + " cm^2";
                    resultFrame.Text = ((2 * length + 2 * height) / 10).ToString() + " cm";
                }
                else
                {
                    MessageBox.Show("Täytä kentät kokonaisluvuilla.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
