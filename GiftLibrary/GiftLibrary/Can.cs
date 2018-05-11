using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftLibrary
{
    public class Can: Package
    {
        public SnapKind SnapKind { get;  set;}
        public override string KindofPackage
        {
            get
            {
                return "Банка";
            }
        }
    }

    public enum SnapKind
    {
        КРЫШКА,
        ЗАМОК,
        ЗАЩЕЛКА
    }
}
