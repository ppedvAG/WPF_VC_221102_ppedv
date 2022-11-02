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

namespace HalloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Btn_BspButton.Content = "Code-seitige Belegung";
        }

        private void Btn_BspButton_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Violet);

            (sender as Button).Content = "Button wurde geklickt";
        }
    }
}