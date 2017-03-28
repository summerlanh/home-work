using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetTrackerDB;

namespace PetTrackerRepository
{
    public class PetTrackerModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public decimal? Value { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class PetTrackerRepository
    {
        public PetTracker ToDBModel(PetTrackerModel petTrackerModel)
        {
            var petTrackerDB = new PetTracker()
            {
                PetId = petTrackerModel.Id,
                PetNumber = petTrackerModel.Number,
                PetBreed = petTrackerModel.Breed,
                PetDescription = petTrackerModel.Description,
                PetPrice = petTrackerModel.Price,
                PetQuantity = petTrackerModel.Quantity,
                PetCost = petTrackerModel.Cost,
                PetValue = petTrackerModel.Value,
                PetCreatedDate = petTrackerModel.CreatedDate,
            };
            return petTrackerDB;
        }

        public PetTrackerModel Add(PetTrackerModel petTrackerModel)
        {
            var petTrackerDB = ToDBModel(petTrackerModel);
            DatabaseManager.Instance.PetTrackers.Add(petTrackerDB);
            DatabaseManager.Instance.SaveChanges();

            petTrackerModel = new PetTrackerModel
            {
                Id = petTrackerDB.PetId,
                Breed = petTrackerDB.PetBreed,
                Description = petTrackerDB.PetDescription,
                Price = petTrackerDB.PetPrice,
                Quantity = petTrackerDB.PetQuantity,
                Cost = petTrackerDB.PetCost,
                Value = petTrackerDB.PetValue,
                CreatedDate = petTrackerDB.PetCreatedDate,
            };
            return petTrackerModel;
        }

        public bool Remove(int petNumber)
        {
            var items = DatabaseManager.Instance.PetTrackers.Where(t => t.PetNumber == petNumber);

            if (items.Count() == 0)
            {
                return false;
            }

            DatabaseManager.Instance.PetTrackers.Remove(items.First());
            DatabaseManager.Instance.SaveChanges();

            return true;
        }

        public bool Update(PetTrackerModel petTrackerModel)
        {
            var original = DatabaseManager.Instance.PetTrackers.Find(petTrackerModel.Id);

            if (original != null)
            {
                DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(ToDBModel(petTrackerModel));
                DatabaseManager.Instance.SaveChanges();
            }

            return false;
        }

        public List<PetTrackerModel> GetAll()
        {
            var items = DatabaseManager.Instance.PetTrackers.
                Select(t => new PetTrackerModel
            {
                    Id = t.PetId,
                    Number = t.PetNumber,
                    Breed = t.PetBreed,
                    Description = t.PetDescription,
                    Price = t.PetPrice,
                    Quantity = t.PetQuantity,
                    Cost = t.PetCost,
                    Value = t.PetValue,
                    CreatedDate = t.PetCreatedDate,
                }).ToList();

            return items;
        }
    }
}

