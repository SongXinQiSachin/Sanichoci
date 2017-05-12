using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface IHP
    {
        float MaxHP
        {
            get;
            set;
        }

        float CurrentHP
        {
            get;
            set;
        }
    }
}
