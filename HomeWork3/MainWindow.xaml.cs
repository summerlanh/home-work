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

namespace HomeWork3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Models.User> users = new List<Models.User>();

        public MainWindow()
        {
            InitializeComponent();
            users.Add(new Models.User { Name = "Dave", Password = "1DavePwd" });
            users.Add(new Models.User { Name = "Steve", Password = "2StevePwd" });
            users.Add(new Models.User { Name = "Lisa", Password = "3LisaPwd" });
            uxList.ItemsSource = users;
        }
        
        private void NameColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            var usersAscending =
                from user in users
                orderby user.Name
                select user;
            uxList.ItemsSource = usersAscending;
        }

        private void PasswordColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            var usersAscending =
                from user in users
                orderby user.Password
                select user;
            uxList.ItemsSource = usersAscending;
        }
    }
}
