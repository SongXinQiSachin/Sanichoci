using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game.Interface
{
    public interface ICost
    {
        bool CanCost(ICaster caster);
    }
}
