using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sanichoci.Game
{
    public interface IAttackState
    {
        float AllDamageIncrementPercent { get; }

        float CriticalPercent { get; }


        float MeleePhysicalDamage { get; }

        float RangedPhysicalDamage { get; }


        float DivineDamage { get; }

        float DarklingDamage { get; }


        float ElementDamage { get; }

        float VitalityDamage { get; }

        float CurseDamage { get; }


        float IceDamage { get; }

        float FireDamage { get; }

        float LightningDamage { get; }

        float PoisonDamage { get; }


        float ChaosDamage { get; }
    }
}
