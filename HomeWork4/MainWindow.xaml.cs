using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace HomeWork4
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(uxTextBox.Text, @"^[A-Z]\d[A-Z]\d[A-Z]\d$"))
                uxButton.IsEnabled = true;
            else if (Regex.IsMatch(uxTextBox.Text, @"^\d{5}(-\d{4})?$"))
                uxButton.IsEnabled = true;
            else
                uxButton.IsEnabled = false;
        }

    }
}
