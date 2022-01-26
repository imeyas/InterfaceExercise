using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }
        public string MainPurpose { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        public int Year { get; set; }
        public string CompanyName { get; set; }
        public long CompanyHeadCount { get; set; }
        public bool PubliclyTradedCompany { get; set; }
        public string CompanyLeader { get; set; }

        public Car()
        {
            Make = "Tesla";
            Model = "S3XY";
            Wheels = 4;
            Year = 2021;
            HasTrunk = true;
            MainPurpose = "Built to transport people as passengers...";
            CompanyName = "Tesla Incorporated";
            CompanyHeadCount = 70757;
            PubliclyTradedCompany = true;
            CompanyLeader = "Elon Musk";
        }
    }
}
