using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
    public class Jelly : Candy
    {
        public Taste Taste { get; set; }
        public Shell Shell { get; set; }
        public Consistency Consistency { get; set; }
    }
    public enum Consistency
    {
        ЖЕЛЕ,
        МАРМЕЛАД
    }
}

