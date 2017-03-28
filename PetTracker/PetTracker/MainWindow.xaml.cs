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
using PetTracker.Model;


namespace PetTracker
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

        private void uxListAll_Click(object sender, RoutedEventArgs e)
        {
            LoadPetTracker();
        }

        public void LoadPetTracker()
        {
            var petTracker = App.PetTrackerRepository.GetAll();

            uxPetTrackerList.ItemsSource = petTracker
                .Select(t => PetTrackerModel.ToModel(t))
                .ToList();
        }

        private void uxNew_Click(object sender, RoutedEventArgs e)
        {
            var petTrackerWindow = new UpdatePetTracker();
            petTrackerWindow.PetTrackerModel = null;

            if (petTrackerWindow.ShowDialog() == true)
            {
                App.PetTrackerRepository.Add(petTrackerWindow.PetTrackerModel.ToRepositoryModel());
                LoadPetTracker();
            }
        }

        private void uxUpdate_Click(object sender, RoutedEventArgs e)
        {
            PetTrackerUpdate();
        }

        private void uxRemove_Click(object sender, RoutedEventArgs e)
        {
            PetTrackerRemove();
        }

        public int FindNumber { get; set; }

        public void PetTrackerRemove()
        {
            var findTrackerWindow = new FindTracker();

            if (findTrackerWindow.ShowDialog() == true)
            {
                if (findTrackerWindow.uxNumber.Text != "")
                {
                    FindNumber = Convert.ToInt32(findTrackerWindow.uxNumber.Text);

                    var selectedRepositoryModel = App.PetTrackerRepository.GetAll().Find(t => t.Number == FindNumber);

                    if (selectedRepositoryModel == null)
                    {
                        MessageBox.Show("Can't fint this record.");
                    }
                    else if (selectedRepositoryModel != null)
                    {
                        var selectedModel = PetTrackerModel.ToModel(selectedRepositoryModel);
                        var petTrackerWindow = new UpdatePetTracker();
                        petTrackerWindow.uxSubmit.Content = "Delete";

                        petTrackerWindow.PetTrackerModel = selectedModel;

                        if (petTrackerWindow.ShowDialog() == true)
                        {
                            App.PetTrackerRepository.Remove(FindNumber);
                        }
                    }
                    LoadPetTracker();
                }
            }
        }

        public void PetTrackerUpdate()
        {
            var findTrackerWindow = new FindTracker();

            if (findTrackerWindow.ShowDialog() == true)
            {
                if (findTrackerWindow.uxNumber.Text != "")
                {
                    FindNumber = Convert.ToInt32(findTrackerWindow.uxNumber.Text);

                    var selectedRepositoryModel = App.PetTrackerRepository.GetAll().Find(t => t.Number == FindNumber);

                    if (selectedRepositoryModel == null)
                    {
                        MessageBox.Show("Can't fint this record.");
                    }
                    else if (selectedRepositoryModel != null)
                    {
                        var selectedModel = PetTrackerModel.ToModel(selectedRepositoryModel);
                        var petTrackerWindow = new UpdatePetTracker();
                        petTrackerWindow.uxSubmit.Content = "Update";

                        petTrackerWindow.PetTrackerModel = selectedModel;

                        if (petTrackerWindow.ShowDialog() == true)
                        {
                            App.PetTrackerRepository.Update(petTrackerWindow.PetTrackerModel.ToRepositoryModel());
                        }
                    }
                    LoadPetTracker();
                }
            }
        }
    }
}
