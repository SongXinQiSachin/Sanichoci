using Sanichoci.Game.Ability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface ICaster
    {
        void UseAbility(IAbility ability);

        List<IAbility> Abilities { get; }
    }
}
