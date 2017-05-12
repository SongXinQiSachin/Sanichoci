using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Deprecated.Game.Ability
{
    public abstract class AbstractAbilityData : IAbilityData
    {
        public abstract float Cooldown { get; set; }
        public abstract float CooldownRamain { get; set; }
        public abstract object Target { get; set; }
        public abstract float CastRange { get; set; }
        public abstract float EffectRange { get; set; }
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract float HPCost { get; set; }
        public abstract float MPCost { get; set; }
    }
}
