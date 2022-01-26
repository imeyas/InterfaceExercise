using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string CompanyName { get; set; }
        public long CompanyHeadCount { get; set; }
        public bool PubliclyTradedCompany { get; set; }
        public string CompanyLeader { get; set; }
    }
}
