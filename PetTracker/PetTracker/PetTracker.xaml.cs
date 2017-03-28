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
using PetTracker.Model;

namespace PetTracker
{
    /// <summary>
    /// Interaction logic for PetTracker.xaml
    /// </summary>
    public partial class PetTracker : Window
    {
        public PetTracker()
        {
            InitializeComponent();
            ShowInTaskbar = false;
        }

        public PetTrackerModel PetTrackerModel { get; set; }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            PetTrackerModel = new PetTrackerModel
            {
                Number = Convert.ToInt32(uxNumber),
                Breed = uxBreed.Text,
                Description = uxDescription.Text,
                Price = Convert.ToDecimal(uxPrice),
                Quantity = Convert.ToInt32(uxQuantity),
                Cost = Convert.ToDecimal(uxCost),
            };

            DialogResult = true;
            Close();
        }

        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
