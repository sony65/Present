using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
   public class Printer: IPrintable
    {
        public void Print(Gift gift)
        {
            var sweets = gift.Sweets;
            foreach (var sweetness in sweets)
            {
                Console.WriteLine(sweetness.Key.Name + " " + sweetness.Value);
            }
        }
    }
}
