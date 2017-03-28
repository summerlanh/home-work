using PetTracker.Model;
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

namespace PetTracker
{
    /// <summary>
    /// Interaction logic for UpdatePetTracker.xaml
    /// </summary>
    public partial class UpdatePetTracker : Window
    {
        public UpdatePetTracker()
        {
            InitializeComponent(); 
            ShowInTaskbar = false;
        }

        public PetTrackerModel PetTrackerModel { get; set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (PetTrackerModel == null)
            {
                PetTrackerModel = new PetTrackerModel();
                PetTrackerModel.CreatedDate = DateTime.Now;
            }
            uxGrid.DataContext = PetTrackerModel;
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {                        
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
