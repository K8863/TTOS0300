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

namespace T00
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
            txbHello.Text = "Hello " + txtName.Text;
            MessageBox.Show("Terve " + txtName.Text, "Messuboksi");
            txbMessages.Text = "Painoit buttosta btnSayHello";
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            // Kutsutaan näkyviin About-niminen ikkuna
            About aboutWin = new About();
            // Huom! Ikkuna voi olla joko modaalinen tai tavallinen
            //aboutWin.ShowDialog();  // Modaalinen
            aboutWin.Show();
        }
    }
}
