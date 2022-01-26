using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool HasBedSize { get; set; }
        public string FunctionalPurpose { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        public int Year { get; set; }
        public string CompanyName { get; set; }
        public long CompanyHeadCount { get; set; }
        public bool PubliclyTradedCompany { get; set; }
        public string CompanyLeader { get; set; }

        public Truck()
        {
            Make = "Ford";
            Model = "F-150";
            Wheels = 4;
            Year = 2021;
            HasBedSize = true;
            FunctionalPurpose = "Built to carry and transport things...";
            CompanyName = "Ford Motor Company";
            CompanyHeadCount = 186000;
            PubliclyTradedCompany = true;
            CompanyLeader = "Jim Farley";


        }
    }

}
