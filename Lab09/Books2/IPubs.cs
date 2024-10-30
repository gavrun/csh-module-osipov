using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books2
{
    internal interface IPubs
    {
        void Subs();
        bool IfSubs { get; set; }
    }
}
