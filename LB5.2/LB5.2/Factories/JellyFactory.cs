using GiftLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5._2.Factories
{
    public class JellyFactory: IFactory
    {
        public Sweetness Create()
        {
            return new Jelly();
        }
    }
}
