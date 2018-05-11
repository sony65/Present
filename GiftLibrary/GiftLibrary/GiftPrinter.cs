using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
    public class GiftPrinter
    {
        public void ConsolePrint(Gift gift)
        
            {
                var sweets = gift.Sweets;
                foreach (var sweetness in sweets)
                {
                    Console.WriteLine(sweetness.Key.Name + " " + sweetness.Value);
                }
            }
        public void TextBoxPrint(Gift gift)
        {
            var sweets = gift.Sweets;
            foreach (var sweetness in sweets.Keys)
            {
                sweetness.Info = sweetness.Name + " " + sweets[sweetness];
            }
        }
    }
    
}
