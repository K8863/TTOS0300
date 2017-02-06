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

namespace T00_WPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Hello " + textBox.Text;
            MessageBox.Show("Terve " + textBox.Text, "Messuboksi");
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            // Kutsutaan näkyviin About-niminen ikkuna
            About aboutWin = new T00_WPF.About();
            // Huom! Ikkuna voi olla joko modaalinen tai tavallinen
            //aboutWin.ShowDialog();  // Modaalinen
            aboutWin.Show();
        }
    }
}
