using Sanichoci.Component.GameObject;
using Sanichoci.Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game.Ability
{
    public interface IAbility : IDescribable, ICooldown
    {
        IAGameObject[] Targets { get; set; }

        float CastRange { get; set; }

        float EffectRange { get; set; }

        ICost[] Costs { get; set; }

        void OnAttach();
        void OnDetach();
    }
}
