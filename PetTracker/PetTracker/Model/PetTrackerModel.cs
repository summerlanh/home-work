using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTracker.Model
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

        public PetTrackerRepository.PetTrackerModel ToRepositoryModel()
        {
            var repositoryModel = new PetTrackerRepository.PetTrackerModel
            {
                Id = Id,
                Number = Number,
                Breed = Breed,
                Description = Description,
                Price = Price,
                Quantity = Quantity,
                Cost = Cost,
                Value = Value,
                CreatedDate = CreatedDate
            };
            return repositoryModel; 
        }

        public static PetTrackerModel ToModel(PetTrackerRepository.PetTrackerModel repositoryModel)
        {
            var petTrackerModel = new PetTrackerModel
            {
                Id = repositoryModel.Id,
                Number = repositoryModel.Number,
                Breed = repositoryModel.Breed,
                Description = repositoryModel.Description,
                Price = repositoryModel.Price,
                Quantity = repositoryModel.Quantity,
                Cost = repositoryModel.Cost,
                Value = repositoryModel.Value,
                CreatedDate = repositoryModel.CreatedDate
            };
            return petTrackerModel;
        }
    }
}
