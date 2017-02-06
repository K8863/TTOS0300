﻿using System;
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
        private int countTrucks;
        private int countCars;
        public MainWindow()
        {
            InitializeComponent();
            countTrucks = 0;
            countCars = 0;
            textBlockTrucks.Text = countTrucks.ToString();
            textBlockCars.Text = countCars.ToString();
        }

        private void buttonTrucks_Click(object sender, RoutedEventArgs e)
        {
            countTrucks++;
            textBlockTrucks.Text = countTrucks.ToString();
        }

        private void buttonCars_Click(object sender, RoutedEventArgs e)
        {
            countCars++;
            textBlockCars.Text = countCars.ToString();
        }
    }
}