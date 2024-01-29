using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class TaxData
    {

        public double ProvincialTaxWithheld {get; set;}
        public double FederalTaxWithheld; { get; set; }
        public double DependentDeduction; { get; set; }
        public double TotalWithheld; { get; set; }
        public double TotalTakeHome; { get; set; }


    }
}
