using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
    public abstract class Sweetness: ICalcWeight
    {
        public Filling Filling { get; set; }
        public double FilingWeight { get; set; }
        public double SelfWeight { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Info { get; set; }
        public double CalcWeight()
        {
            double w;
            w = FilingWeight + SelfWeight;
            return w;
        }
    }
}
