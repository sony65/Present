using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GiftLibrary;

namespace LB5._2.Factories
{
    public class CaramelFactory : IFactory
    {
        public Sweetness Create()
        {
            return new Caramel();
        }
    }
}
