using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
    public class Caramel : Candy
    {
        public CaramelKind Kind { get; set; }
        public Taste Taste { get; set; }
        public Shell Shell { get; set; }
    }

    public enum CaramelKind
    {
        ЖЕВАТЕЛЬНАЯ,
        ЛЕДЕНЕЦ,
        ТВЕРДАЯ
    }
}
