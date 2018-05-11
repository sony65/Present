using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
    public class ListBoxWriter : IPrintable
    {
        public void Print(Gift gift)
        {
            var sweets = gift.Sweets;
            foreach  (var sweetness in sweets.Keys)
            {
                sweetness.Info = sweetness.Name + " " + sweets[sweetness];
            }
        }

    }
}
