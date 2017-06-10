using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sanichoci.Game.Interface;
using Sanichoci.OGO.AGO;

namespace Sanichoci.Game.Ability
{
    public abstract class AbstractAbility : IAbility
    {
        public AbstractAbility()
        {
        }

        public abstract AbstractAGO[] Targets { get; set; }
        public abstract float CastRange { get; set; }
        public abstract float EffectRange { get; set; }
        public abstract ICost[] Costs { get; set; }
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract float Cooldown { get; set; }
        public abstract float CooldownRemain { get; set; }

        public abstract void OnAttach();
        public abstract void OnDetach();
    }
}
