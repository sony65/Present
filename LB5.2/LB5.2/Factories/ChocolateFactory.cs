using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiftLibrary;

namespace LB5._2.Factories
{
    public class ChocolateFactory : IFactory
    {
        public Sweetness Create()
        {
            return new Chocolate();
        }
    }
}
