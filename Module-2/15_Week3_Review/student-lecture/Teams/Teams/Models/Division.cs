using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teams.Models
{
    public enum Division // This a class that is an int, but we want to assign to each item an int.
    {  // This is starting at North=1 and ends at West=1+1+1+1=4

        North = 1,
        East,
        South,
        West
    }
}
