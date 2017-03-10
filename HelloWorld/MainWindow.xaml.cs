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
using System.Data.Entity;


namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Models.User user = new Models.User();

        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;         
        }

        public override void EndInit()
        {
            base.EndInit();
            uxContainer.DataContext=user;
            var sample = new SampleEntities();
            sample.Users.Load();
            uxList.ItemsSource = sample.Users.Local;
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            //int x = 1;
            //x = x / (x - 1);

            MessageBox.Show("Submitting password:" + uxPassword.Password);

            var window = new SecondWindow();
            Application.Current.MainWindow = window;
            Close();
            window.Show();
        }
    

        private void uxTextChanged(object sender, TextChangedEventArgs e)
        {
            uxSubmit.IsEnabled = (uxName.Text != string.Empty  && uxPassword.Password!=string.Empty);
        }

    
        private void uxPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            uxSubmit.IsEnabled = (uxName.Text != "" && uxPassword.Password != "");
        }
    }
}
