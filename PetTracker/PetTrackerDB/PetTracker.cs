//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetTrackerDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class PetTracker
    {
        public int PetId { get; set; }
        public string PetBreed { get; set; }
        public string PetDescription { get; set; }
        public decimal PetPrice { get; set; }
        public int PetQuantity { get; set; }
        public decimal PetCost { get; set; }
        public Nullable<decimal> PetValue { get; set; }
        public System.DateTime PetCreatedDate { get; set; }
        public int PetNumber { get; set; }
    }
}
