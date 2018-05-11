using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
    public class Box: Package
    {
        public bool RemovableLid { get; set; }
        public override string KindofPackage
        {
            get
            {
                return "Коробка";
            }
        }
    }
}
