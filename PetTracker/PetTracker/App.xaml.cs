using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PetTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static PetTrackerRepository.PetTrackerRepository petTrackerRepository;

        static App()
        {
            petTrackerRepository = new PetTrackerRepository.PetTrackerRepository();
        }

        public static PetTrackerRepository.PetTrackerRepository PetTrackerRepository
        {
            get
            {
                return petTrackerRepository;
            }
        }
    }
}
