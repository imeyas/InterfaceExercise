using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool HasCargoHold { get; set; }
        public string ReasonWhyMade { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        public int Year { get; set; }
        public string CompanyName { get; set; }
        public long CompanyHeadCount { get; set; }
        public bool PubliclyTradedCompany { get; set; }
        public string CompanyLeader { get; set; }

        public SUV()
        {
            Make = "Tesla";
            Model = "Model Y";
            Wheels = 4;
            Year = 2022;
            HasCargoHold = true;
            ReasonWhyMade = "SUVs, unlike cars and trucks are built to comfortably transport people...";
            CompanyName = "Tesla Incorpoated";
            CompanyHeadCount = 70757;
            PubliclyTradedCompany = true;
            CompanyLeader = "Elon Musk";
        }
    }
}
