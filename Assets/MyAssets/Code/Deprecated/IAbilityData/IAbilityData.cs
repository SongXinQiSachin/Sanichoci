using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Deprecated.Game.Ability
{
    public interface IAbilityData
    {
        float Cooldown { get; set; }
        float CooldownRamain { get; set; }

        object Target { get; set; }

        float CastRange { get; set; }

        float EffectRange { get; set; }

        string Name { get; set; }
        string Description { get; set; }

        float HPCost { get; set; }
        float MPCost { get; set; }
    }
}
