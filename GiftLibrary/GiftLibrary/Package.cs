using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
    public abstract class Package
    {
        public Color Color { get; set; }
        public Size Size { get; set; }
        public abstract string KindofPackage { get; }
    }
    public enum Color
    {
        КРАСНЫЙ,
        СИНИЙ,
        ЗОЛОТОЙ,
        СЕРЕБРЯНЫЙ
    }
    public enum Size
    {
        МАЛЕНЬКАЯ,
        СРЕДНЯЯ,
        БОЛЬШАЯ

    }
}
