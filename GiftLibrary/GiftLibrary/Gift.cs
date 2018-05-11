using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
    public class Gift: ICalcWeight
    {
       
        public Package Package { get; set; }
        public Dictionary<Sweetness, int>  Sweets { get; private set; }

        public Gift()
        {
            Sweets = new Dictionary<Sweetness, int>();
        }
       
       public double CalcWeight()
        {
            double weight = 0;

            foreach (var sweetness in Sweets)
            {
                weight += sweetness.Key.CalcWeight() * sweetness.Value;
            }

            return weight;
        }
    }
}
