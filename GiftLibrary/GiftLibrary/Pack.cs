using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
    public class Pack : Package
    {
        public Tape Tape { get; set; }
        public override string KindofPackage
        {
            get
            {
                return "Пакет";
            }
        }
    }
    public enum Tape
    {
        АТЛАСНАЯ,
        ПЛАСТИКОВАЯ,
        ДЕКОРАТИВНАЯ_ЛЕНТА,
        ШНУРОК

    }
}
