using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
    public abstract class Candy: Sweetness
    {
        public CandyShape Shape { get; set; }
    }

    public enum CandyShape
    {
        КВАДРАТНАЯ,
        КРУГЛАЯ,
        ПРЯМОУГОЛЬНАЯ,
        ДРУГАЯ
    }
}
