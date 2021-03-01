using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teams.Models
{
    public enum Conference // This a class that is an int, but we want to assign to each item an int.
                           // This is starting at AFC=1 and ends at NFC=1+1=2
    {
        AFC =1,
        NFC
    }
}
