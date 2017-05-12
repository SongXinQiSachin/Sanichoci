using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface ISP
    {
        float MaxSP
        {
            get;
            set;
        }

        float CurrentSP
        {
            get;
            set;
        }
    }
}
