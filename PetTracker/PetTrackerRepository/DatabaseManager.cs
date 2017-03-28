using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetTrackerDB;

namespace PetTrackerRepository
{
    public class DatabaseManager
    {
        private static readonly PetTrackerEntities entities;
        
        static DatabaseManager()
        {
            entities = new PetTrackerEntities();
            entities.Database.Connection.Open();
        }
        
        public static PetTrackerEntities Instance
        {
            get
            {
                return entities;
            }
        }
    }
}
